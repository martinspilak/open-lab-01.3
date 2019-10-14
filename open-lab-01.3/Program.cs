using System;

namespace open_lab_01._3
{
    class Program
    {
        public static int sum(int a)
        {
            return ++a;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sum(a));
        }





    }
}
