using System;
namespace _01._03._2023HM
{
    public class Play : IDisposable
    {
        public string Name_Play;
        public string FIO_Autgor;
        public string Genre_Play;
        public int Year_Play;

        public Play() { }
        public Play(string NP, string FA, string GP, int YP)
        {
            Name_Play = NP;
            FIO_Autgor = FA;
            Genre_Play = GP;
            Year_Play = YP;
        }
        public void Dispose()
        {
            Console.WriteLine("Освобождение ресурсов!!!");
        }
        public void Enter()
        {
            Console.Write("Введите название пьесы ----->");
            Name_Play = Convert.ToString(Console.ReadLine());
            Console.Write("Введите ФИО автора ----->");
            FIO_Autgor = Convert.ToString(Console.ReadLine());
            Console.Write("Введите жанр пьесы ----->");
            Genre_Play = Convert.ToString(Console.ReadLine());
            Console.Write("Введите год выпуска пьесы ----->");
            Year_Play = Convert.ToInt32(Console.ReadLine());
        }

        ~Play()
        {
            Console.WriteLine("Освобождаем неупорядоченные ресурсы!!!");
        
            
        }
    }
    public class Shop: IDisposable
    {
        public string Name_Shop;
        public string Adres_Shop;
        public string Type_Shop;
        private int i;

        public Shop() { }
        public Shop(string NS, string AS, string TS)
        {
            Name_Shop = NS;
            Adres_Shop = AS;
            Type_Shop = TS;
        }

        public void Enter()
        {
            Console.Write("Введите название магазина ----->");
            Name_Shop = Convert.ToString(Console.ReadLine());
            Console.Write("Введите адрес магазина ----->");
            Adres_Shop = Convert.ToString(Console.ReadLine());
            Console.Write("Введите тип магазина ----->");
            Type_Shop = Convert.ToString(Console.ReadLine());
        }
        public void Dispose()
        {
            Console.WriteLine("Освобождение ресурсов!!!");
        }
        ~Shop()
        {
            Console.WriteLine("Освобождаем неупорядоченные ресурсы!!!");
            
        }
    }
}
