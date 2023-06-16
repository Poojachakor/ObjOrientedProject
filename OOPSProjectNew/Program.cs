namespace OOPSProjectNew
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[] rowSums = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                }
                rowSums[i] = sum;
            }

            Console.WriteLine("Sum of each row:");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Row {i + 1}: {rowSums[i]}");
            }
        }
    }
    
}

    
