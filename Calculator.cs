
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
            while (1 == 1)
            {
                int first_num, second_num;
                Console.Write("PLEASE İNPUT FİRST NUMBER :");
                first_num = Convert.ToInt32(Console.ReadLine());
                Console.Write("PLEASE İNPUT SECOND NUMBER :");
                second_num = Convert.ToInt32(Console.ReadLine());
                int operation, result;
                Console.WriteLine("PRESS 1 FOR ADDİTİON, 2 FOR SUBTRACTİON, 3 FOR MULTİPLİCATİON AND 4 FOR DİVİSİON");
                operation = Convert.ToInt32(Console.ReadLine());
                if (operation == 1)
                {
                    result = first_num + second_num;
                    Console.WriteLine("ADDİTİNG :" + result);
                }
                if (operation == 2)
                {
                    result = first_num - second_num;
                    Console.WriteLine("SUBTRACTİNG :" + result);
                }
                if (operation == 3)
                {
                    result = first_num * second_num;
                    Console.WriteLine("MULTİPLİCATİNG :" + result);
                }
                if (operation == 4)
                {
                   
                    Console.WriteLine("DİVİDİNG :" + (float)first_num / (float)second_num );
                }
            }
            Console.ReadKey();
        }
    }
}
