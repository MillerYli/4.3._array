using System;

namespace mynamespase
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            
            for(int i = name.Length-1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}