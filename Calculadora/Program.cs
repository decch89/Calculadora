using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sumando1;
            double Sumando2;
            double Total_suma;
            double Total_suma2;


            Console.Write("*********SUMA**********\n");
            Console.Write("Ingrese el sumando 1:\n");
            Sumando1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el sumando 2:\n");
            Sumando2 = int.Parse(Console.ReadLine());
            Total_suma = Sumando1 + Sumando2 / 2;
            Total_suma2 = (Sumando1 + Sumando2) / 2;
            Console.Write("El total de la suma es: " + Total_suma + "\n");
            Console.Write("El total de la suma es: " + Total_suma2);
            Console.Read();


        }
    }
}
