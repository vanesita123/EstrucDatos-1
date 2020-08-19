using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable1 = 0;
            int variable2 = 0;
            int variable3 = 0;
            int suma = 0;
            variable1 = int.Parse(Console.ReadLine());
            variable2 = int.Parse(Console.ReadLine());
            variable3 = int.Parse(Console.ReadLine());
            suma = variable1 + variable2 + variable3;
            Console.WriteLine(suma);
            Console.ReadKey();
        }

        //public static void Main(string[] args)
        //{
        //    int a = 5;
        //    int b = 30;
        //    int c = 4;

        //    int suma = a + b + c;
        //    Console.WriteLine("La suma es " + suma);
        //    Console.ReadLine();
        //}
    }
}
