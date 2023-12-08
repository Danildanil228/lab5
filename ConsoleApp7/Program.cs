using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Program
    {
        static void Main()
        {
            int n = 7;
            int m = 6;
            int[,] matrix = new int[n, m];
            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            try
            {
                int[] columnAverages = ClassLibrary1.Class1.CalculateColumnAverages(matrix);
                Console.WriteLine("Средние значения столбцов матрицы:");
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Столбец {j + 1}: {columnAverages[j]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
