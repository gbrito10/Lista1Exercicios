using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int area;
            string aux;

            Console.Write("Digite a base o triângulo: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura o triângulo: ");
            b = int.Parse(Console.ReadLine());
            area = (a * b) / 2;

            Console.WriteLine("A area do triângulo é: ");
            Console.WriteLine(area);
        }
    }
}
