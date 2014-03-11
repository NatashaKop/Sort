using System;

namespace sortMass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass =
                {
                    {8,2,5},
                    {5,3,7},
                    {4,10,-2},
                    {4,6,11},
                    {1,22,41}
                };
            int rows = 5;
            int columns = 3;
            int[] TempMass = new int[rows * columns];

            sortMatr s = new sortMatr(mass);
            //начальный массив
            s.PrintMass(rows, columns);

            //отсортированный пузырьком
            int[,] SortMass = s.OneToTwoBubbleSort(TempMass, mass, rows, columns);
            s.PrintMass(rows, columns);

            //отсортированный вставками
            int[,] SecondSort = s.OneToTwoInsertSort(TempMass, mass, rows, columns);
            s.PrintMass(rows, columns);

            Console.ReadKey();

        }
    }
}
