
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (1==1)
            {
                string s;
                int a, b, c;
                Console.Write("Kaçıncı Sınıftasınız ?");
                s = Console.ReadLine();
                a = Int32.Parse(s);
                switch (a)
                {
                    case (1):
                        Console.WriteLine("Daha Yenisiniz! .d");
                        break;
                    case (2):
                        Console.WriteLine("Mirasçısınız! .d");
                        break;
                    case (3):
                        Console.WriteLine("Ev Sahibisiniz! .d");
                        break;
                    case (4):
                        Console.WriteLine("Misafirsiniz! .d");
                        break;
                    default:
                        Console.WriteLine("Okulu Uzatmışsınız! .d");
                        break;
                }
            }
           
            Console.ReadKey();
        }
    }
}
