//последовательность чисел
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер элемента последовательности: ");
            int Number = Int32.Parse(Console.ReadLine());
            String[] Sequence = new String[Number];
            Sequence[0] = "1";
            int Count;
            for (int i = 1; i < Number; i++)
            {
                int Len = Sequence[i - 1].Length;
                for(int j = 0; j < Len; j+=Count)
                {
                    Count = 1;
                    if (j < Sequence[i - 1].Length - 1)
                    {
                        while (Sequence[i-1][j] == Sequence[i-1][j+Count])
                        {
                            Count++;
                            if (j + Count >= Sequence[i - 1].Length - 1) break;
                        }
                    }
                    Sequence[i] += Count.ToString() + Sequence[i-1][j];
                }
            }
            Console.Write("Элемент с номером {0} равен: ", Number);
            Console.WriteLine(Sequence[Number - 1]);
        }
    }
}
