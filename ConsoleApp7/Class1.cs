namespace ClassLibrary1
{
    public class Class1
    {
        public static int[] CalculateColumnAverages(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (rows == 0 || cols == 0)
            {
                throw new ArgumentException("Матрица пуста");
            }
            int[] columnAverages = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += matrix[i, j];
                }
                columnAverages[j] = sum / rows;
            }
            return columnAverages;
        }
    }
}
