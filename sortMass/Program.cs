using System;

namespace sortMass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass =
                {
                    {8,2},
                    {5,3},
                    {4,10}
                };
            int rows = 3;
            int columns = 2;
            int[] TempMass = new int[rows * columns];

            sortMatr s = new sortMatr(mass);
            //начальный массив
            s.PrintMass(rows, columns);

            //отсортированный пузырьком
            int[,] SortMass = s.OneToTwo(TempMass, mass, rows, columns);
            s.PrintMass(rows, columns);

            //отсортированный вставками
            int[,] SecondSort = s.InsertSort();
            s.PrintMass(rows, columns);

            Console.ReadKey();

        }
    }
}
