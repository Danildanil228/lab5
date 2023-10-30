Random random = new Random();
int[] mas = new int[10];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(1, 100);
    Console.WriteLine(mas[i] + " ");
}
Console.WriteLine();
Console.WriteLine("индексы тех элементов, значения которых больше, чем у стоящих справа от него: ");
int count = 0;
for (int i = 0; i < mas.Length - 1; i++)
{
    if (mas[i] > mas[i+1])
    {
        Console.WriteLine(i);
        count++;
    }    

    
}
Console.WriteLine("количество: " + count);
