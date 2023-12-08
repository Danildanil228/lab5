struct Train
{
    public int TrainNumber;
    public string Direction;
    public DateTime ArrivalTime;
    public DateTime DepartureTime;
    public int Distance;
}
class Program
{
    static void Main()
    {
        Console.Write("Введите количество поездов: ");
        int numberOfTrains = int.Parse(Console.ReadLine());
        Train[] trains = new Train[numberOfTrains];
        for (int i = 0; i < numberOfTrains; i++)
        {
            try
            {
                Console.Write($"Введите номер поезда {i + 1}: ");
                trains[i].TrainNumber = int.Parse(Console.ReadLine());
                Console.Write($"Введите направление поезда {i + 1}: ");
                trains[i].Direction = Console.ReadLine();
                Console.Write($"Введите время отбытия поезда {i + 1} (гггг-мм-дд чч:мм): ");
                trains[i].ArrivalTime = DateTime.Parse(Console.ReadLine());
                Console.Write($"Введите время прибытия поезда {i + 1} (гггг-мм-дд чч:мм): ");
                trains[i].DepartureTime = DateTime.Parse(Console.ReadLine());
                Console.Write($"Введите расстояние поезда {i + 1} (в км): ");
                trains[i].Distance = int.Parse(Console.ReadLine());
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine("Поезда, пребывающие в пути более суток:");
        for (int i = 0; i < numberOfTrains; i++)
        {
            TimeSpan travelDuration = trains[i].DepartureTime - trains[i].ArrivalTime;
            if (travelDuration.TotalDays > 1)
            {
                Console.WriteLine($"Номер поезда: {trains[i].TrainNumber}");
                Console.WriteLine($"Направление: {trains[i].Direction}");
                Console.WriteLine($"Время прибытия: {trains[i].ArrivalTime}");
                Console.WriteLine($"Время отбытия: {trains[i].DepartureTime}");
                Console.WriteLine($"Расстояние: {trains[i].Distance} км");
                Console.WriteLine();
            }
        }
        Console.ReadLine();
    }
}
