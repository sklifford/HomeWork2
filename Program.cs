//массив заполненый по спирали (против часовой стрелки)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите размер стороны массива: ");
            int Line = Int32.Parse(Console.ReadLine());
            int[,] ArrayOfNumbers = new int[Line, Line];
            int StartIndex = Line / 2;
            int Count = 1;
            int StopLine = Line * Line;
            int Flag = 1;
            int Step = 1;
            int TempX = StartIndex, TempY = StartIndex;
            ArrayOfNumbers[StartIndex, StartIndex] = Count;
            while(Count < StopLine)
            {
                switch(Flag)
                {
                    case 1: //движение влево
                        {
                            for (int i = 1; i <= Step; i++)
                            {
                                ArrayOfNumbers[--TempX, TempY] = ++Count;
                                if (TempX == 0)
                                {
                                    Flag = 2;
                                    break;
                                }
                            }
                            Flag = 2;
                            break;
                        }
                    case 2: //движение вниз
                        {
                            for (int i = 1; i <= Step; i++)
                            {
                                ArrayOfNumbers[TempX, ++TempY] = ++Count;
                                if (TempY == Line - 1)
                                {
                                    Flag = 3;
                                    break;
                                }
                            }
                            Flag = 3;
                            Step++;
                            break;
                        }
                    case 3: //движение вправо
                        {
                            for (int i = 1; i <= Step; i++)
                            {
                                ArrayOfNumbers[++TempX, TempY] = ++Count;
                                if (TempX == Line - 1)
                                {
                                    Flag = 4;
                                    break;
                                }
                            }
                            Flag = 4;
                            break;
                        }
                    case 4: //движение вверх
                        {
                            for (int i = 1; i <= Step; i++)
                            {
                                ArrayOfNumbers[TempX, --TempY] = ++Count;
                                if (TempY == 0)
                                {
                                    Flag = 1;
                                    break;
                                }
                            }
                            Flag = 1;
                            Step++;
                            break;
                        }
                }
            }
            for (int i = 0; i < Line; i++)
            {
                for (int j = 0; j < Line; j++)
                {
                    Console.Write(ArrayOfNumbers[j, i] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
