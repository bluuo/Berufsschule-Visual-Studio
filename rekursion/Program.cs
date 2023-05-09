using System;

namespace first_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie eine ganze Zahl ein:");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int fakultätErgebnis = faculty(zahl);
            Console.WriteLine("Die Fakultät von:" + zahl + "ist" + fakultätErgebnis);
        }

        static public int faculty(int i)
        {
            if (i == 0)
            {
                return 0;
            }
            else
            {
                int r = i + faculty(i - 1);
                return r;
            };
        }

    }
}