using System;

namespace _01._03._2023HM
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Play obj = new Play();
            obj.Enter();
            Shop[] obj3 = new Shop[5];
            for (int i = 0; i < 5; i++)
            {
                obj3[i] = new Shop();
            }
            for (int i = 0; i < 5; i++)
            {
                obj3[i].Dispose();
            }
            Console.WriteLine("\n");
            ///////////////
            Shop[] obj1 = new Shop[10];
            Shop obj2 = new Shop();
            obj2.Enter();
            for (int i = 0; i<10; i++)
            {
                obj1[i] = new Shop();
            }
            for (int i = 0; i<10; i++)
            {
                obj1[i].Dispose();
            }
            /////////////////
            Console.WriteLine("\n");
        }
    }
}
