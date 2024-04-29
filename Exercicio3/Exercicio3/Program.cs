using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da diagonal do quadrado: ");
            double diagonal = Convert.ToDouble(Console.ReadLine());

            double lado = diagonal / Math.Sqrt(2);

            double area = lado * lado;

            Console.WriteLine($"A área do quadrado é: {area}");
        }
    }
}
