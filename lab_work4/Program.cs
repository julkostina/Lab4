using System;
using System.Security.Cryptography.X509Certificates;

namespace lab_work4
{
    class Program
    {
        
        public delegate int Addition(int[,] arr,int rows,int cols);

        static void Main(string[] args)
        {
            // anonimous method 
            Addition FindSum = delegate (int[,] arr,int r, int c)
            {
                int res = 0;


                for (int i = 0; i < r; i++)
                {
                    int row = 0;
                    for (int j = 0; j < c; j++)
                    {
                        row += arr[i,j];
                    }
                    res += row;
                }
                return res;
            };
            // lambda expression
            Addition FindSumOfArray = (int[,]arr,int r,int c) =>
            {
                int res = 0;
                for (int i = 0; i < r; i++)
                {
                    int row = 0;
                    for (int j = 0; j < c; j++)
                    {
                        row += arr[i,j];
                    }
                    res += row;
                }
                return res;
            };

            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6, }, { 7, 8, 9 } };
            Console.WriteLine($"Sum of two dimansional aray: {FindSumOfArray(arr, 3,3)}");

            Operations.Add(int.MaxValue, 1);
            Operations.Subtract(int.MinValue, 1);
            Operations.Multiply(int.MinValue, 2);
        }

    }
}