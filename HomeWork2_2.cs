//написание цифр прописью
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        static string[] nums_1_9 = "ноль один два три четыре пять шесть семь восемь девять".Split();
        static string[] nums_10_19 = "десять одиннадцать двенадцать тринадцать четырнадцать пятнадцать шестнадцать семнадцать восемнадцать девятнадцать".Split();
        static string[] nums_20_90 = "ноль десять двадцать тридцать сорок пятьдесят шестьдесят семьдесят восемьдесят девяносто".Split();
        static string[] nums_100_900 = "ноль сто двести триста четыреста пятьсот шестьсот семьсот восемьсот девятьсот".Split();
        static string[] razrad = @" тысяч миллион".Split();


        static void Main(string[] args)
        {
            String n;
            Console.WriteLine("Введите число от 1 до 1000000");
            n = Console.ReadLine();
            foreach (var s in solve(splitIntoCategories(n))) Console.Write(s + " ");
            Console.WriteLine();
            
        }
        //разбить на разряды
        static IEnumerable<string> splitIntoCategories(string s)
        {
            s = s.PadLeft(s.Length + 3 - s.Length % 3, '0');
            return Enumerable.Range(0, s.Length / 3).Select(i => s.Substring(i * 3, 3));
        }
        //вывести название цифр в разряде
        static IEnumerable<string> solve(IEnumerable<string> n)
        {
            var ii = 0;
            foreach (var s in n)
            {
                var countdown = n.Count() - ++ii;
                yield return
                    String.Format(@"{0} {1} {2} {3}",
                        s[0] == '0' ? "" : nums_100_900[getDigit(s[0])],
                        getE1(s[1], s[2]),
                        getE2(s[1], s[2], countdown),
                        s == "000" ? "" : getRankName(s, countdown)
                    );
            }

        }
        //вторая цифра разряда
        private static string getE1(char p1, char p2)
        {
            if (p1 != '0')
            {
                if (p1 == '1')
                    return nums_10_19[getDigit(p2)];
                return nums_20_90[getDigit(p1)];
            }
            return "";
        }
        //третья цифра разряда
        private static string getE2(char p1, char p2, int cd)
        {
            if (p1 != '1')
            {
                if (p2 == '0')
                {
                    return "";
                } else if(p2 == '1' && cd == 1)
                {
                    return "одна";
                }
                return (p2 == '2' && cd == 1) ? "две" : nums_1_9[getDigit(p2)];
            } 
            return "";
        }
        private static int getDigit(char p1)
        {
            return Int32.Parse(p1.ToString());
        }
        //вывести название разрядов
        private static string getRankName(string s, int ii)
        {
            if (ii == 0) return "";
            var r = razrad[ii];
            if (s[1] == '1') return r + (ii == 1 ? "" : "ов");

            if (new[] { '2', '3', '4' }.Contains(s[2]))
            {
                return r + "и";
            }
            else if (s[2] == '1') return r + "а";
            return r;
        }
    }
}

