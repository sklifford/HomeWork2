using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_1
{
    static class RomeDigit
    {
        static int MinValue = 0;
        static int MaxValue = 3999;
        public static string ConvertIntToRome(int number)
        {
            String Result = "";
            int TempValue = 0;
            if (number < MinValue || number > MaxValue)
            {
                Result = "Ошибка. Введите число от 1 до 3999";
                return Result;
            }
            for (int i = 1; i <= 1000; i *= 10)
            {
                TempValue = number % 10;
                TempValue *= i;
                switch(TempValue)
                {
                    case 1:
                        {
                            Result = "I" + Result;
                            break;
                        }
                    case 2:
                        {
                            Result = "II" + Result;
                            break;
                        }
                    case 3:
                        {
                            Result = "III" + Result;
                            break;
                        }
                    case 4:
                        {
                            Result = "IV" + Result;
                            break;
                        }
                    case 5:
                        {
                            Result = "V" + Result;
                            break;
                        }
                    case 6:
                        {
                            Result = "VI" + Result;
                            break;
                        }
                    case 7:
                        {
                            Result = "VII" + Result;
                            break;
                        }
                    case 8:
                        {
                            Result = "VIII" + Result;
                            break;
                        }
                    case 9:
                        {
                            Result = "IX" + Result;
                            break;
                        }
                    case 10:
                        {
                            Result = "X" + Result;
                            break;
                        }
                    case 20:
                        {
                            Result = "XX" + Result;
                            break;
                        }
                    case 30:
                        {
                            Result = "XXX" + Result;
                            break;
                        }
                    case 40:
                        {
                            Result = "XL" + Result;
                            break;
                        }
                    case 50:
                        {
                            Result = "L" + Result;
                            break;
                        }
                    case 60:
                        {
                            Result = "LX" + Result;
                            break;
                        }
                    case 70:
                        {
                            Result = "LXX" + Result;
                            break;
                        }
                    case 80:
                        {
                            Result = "LXXX" + Result;
                            break;
                        }
                    case 90:
                        {
                            Result = "XC" + Result;
                            break;
                        }
                    case 100:
                        {
                            Result = "C" + Result;
                            break;
                        }
                    case 200:
                        {
                            Result = "CC" + Result;
                            break;
                        }
                    case 300:
                        {
                            Result = "CCC" + Result;
                            break;
                        }
                    case 400:
                        {
                            Result = "CD" + Result;
                            break;
                        }
                    case 500:
                        {
                            Result = "D" + Result;
                            break;
                        }
                    case 600:
                        {
                            Result = "DC" + Result;
                            break;
                        }
                    case 700:
                        {
                            Result = "DCC" + Result;
                            break;
                        }
                    case 800:
                        {
                            Result = "DCCC" + Result;
                            break;
                        }
                    case 900:
                        {
                            Result = "CM" + Result;
                            break;
                        }
                    case 1000:
                        {
                            Result = "M" + Result;
                            break;
                        }
                    case 2000:
                        {
                            Result = "MM" + Result;
                            break;
                        }
                    case 3000:
                        {
                            Result = "MMM" + Result;
                            break;
                        }
                    default:
                            break;
                }
                number /= 10;
                if (number == 0)
                    return Result;
            }
                return Result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 4000;
            Console.SetBufferSize(Console.BufferWidth, Count);
            String[] RomeNumber = new String[Count];
            for (int i = 0; i < Count; i++)
            {
                RomeNumber[i] = RomeDigit.ConvertIntToRome(i);
            }
            foreach(String s in RomeNumber)
            {
                Console.WriteLine(s);
            }
        }
    }
}
