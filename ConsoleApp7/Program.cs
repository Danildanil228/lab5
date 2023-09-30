Console.Write("Введите первое однозначное число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе однозначное число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введи произведение этих чисел c: ");
int c = int.Parse(Console.ReadLine());
if (a * b == c) Console.Write("Молодец, правильно!");
else
{
    Console.Write($"Неправильно, результат произведения чисел {a} и {b} будет равен ");
    Console.Write(a * b);
}