//Двумерный массив заполненый змейкой
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество столбцов: ");
            int Columns = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество строк: ");
            int Line = Int32.Parse(Console.ReadLine());
            int[,] ArrayOfNumbers = new int[Columns, Line];
            int Count = 1;
            for(int y = 0; y < Line; y++)
            {
                if(y % 2 == 0)
                {
                    for(int x = 0; x < Columns; x++)
                    {
                        ArrayOfNumbers[x, y] = Count;
                        Count++;
                    }
                } else
                {
                    for (int x = Columns-1; x >= 0; x--)
                    {
                        ArrayOfNumbers[x, y] = Count;
                        Count++;
                    }
                }
            }
            for (int i = 0; i < Line; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(ArrayOfNumbers[j, i] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
