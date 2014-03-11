using System;

namespace sortMass
{
    public class sortMatr
    {
        private int[,] mass;

        public sortMatr(int[,] m)
        {
            mass = m;
        }
        /// <summary>
        /// преобразует двумерный массив в одномерный
        /// </summary>
        /// <param name="mass">двумерный массив</param>
        /// <param name="rows">количество строк в массиве</param>
        /// <param name="columns">количество колонок в массиве</param>
        /// <returns>возвращает одномерный массив</returns>
        public int[] TwoToOne(int[]TempMass, int[,] mass, int rows, int columns)
        {   
            int k = 0; //переменная для хранения индекса временного массива
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                { 
                    TempMass[k] = mass[i, j];
                    k++;
                }
            return TempMass;       
        }   

        public int[] BubbleSort(int[] TempMass, int rows, int columns)
        {
            TwoToOne(TempMass, mass, rows, columns);
            int tmp = 0;
            for (int i = 0; i < TempMass.Length; i++)
            {
                for (int j = 0; j < TempMass.Length - i - 1; j++)
                {
                    if (TempMass[j] > TempMass[j + 1])
                    {
                        tmp = TempMass[j];
                        TempMass[j] = TempMass[j + 1];
                        TempMass[j + 1] = tmp;
                    }
                }
            }
            return TempMass;
        }


        public int[] InsertSort(int[] TempMass, int rows, int columns)
        {
            TwoToOne(TempMass, mass, rows, columns);
            int i, j, tmp;
            for (i = 1; i < rows*columns; ++i) // цикл проходов, i - номер прохода
            {
                tmp = TempMass[i];
                for (j = i - 1; j >= 0 && TempMass[j] > tmp; --j) // поиск места элемента в готовой последовательности 
                    TempMass[j + 1] = TempMass[j];    // сдвигаем элемент направо, пока не дошли
                TempMass[j + 1] = tmp; // место найдено, вставить элемент    
            }

            return TempMass;
        }

        /// <summary>
        /// выводит массив в виде матрицы
        /// </summary>
        /// <param name="rows">количество строк в массиве</param>
        /// <param name="columns">количество колонок в массиве</param>
        public void PrintMass(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
        /// <summary>
        /// преобразует одномерный массив в двумерный
        /// </summary>
        /// <param name="TempMass">одномерный массив</param>
        /// <param name="mass">двумерный массив</param>
        /// <param name="rows">количество строк в массиве</param>
        /// <param name="columns">количество колонок в массиве</param>
        public int[,] OneToTwoBubbleSort(int[] TempMass, int[,] mass, int rows, int columns)
        {
            BubbleSort(TempMass, rows, columns);

            int k = 0; //переменная для хранения индекса временного массива
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    mass[i, j] = TempMass[k];
                    k++;
                }
            return mass;

        }

        public int[,] OneToTwoInsertSort(int[] TempMass, int[,] mass, int rows, int columns)
        {
            InsertSort(TempMass, rows, columns);

            int k = 0; //переменная для хранения индекса временного массива
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    mass[i, j] = TempMass[k];
                    k++;
                }
            return mass;

        }
    }
}
