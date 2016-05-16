//шар в кубе
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер стороны куба: ");
            int Diametr = Int32.Parse(Console.ReadLine());
            int[, ,] Cube = new int[Diametr, Diametr, Diametr];
            int X, Y, Z;
            int Radius = Diametr/2;

            for (X = 0; X < Diametr; X++ )
            {
                for(Y = 0; Y < Diametr; Y++)
                {
                    for(Z = 0; Z < Diametr; Z++)
                    {
                        if(Math.Sqrt(Math.Pow(X - Radius, 2) + Math.Pow(Y - Radius, 2) + Math.Pow(Z - Radius, 2)) < Radius)
                        {
                            Cube[X, Y, Z] = 1;
                        }
                    }
                }
            }

                for (int z = 0; z < Diametr; z++)
                {
                    for (int y = 0; y < Diametr; y++)
                    {
                        for (int x = 0; x < Diametr; x++)
                        {
                            Console.Write(Cube[x, y, z]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("_____________________");
                }
        }
    }
}
