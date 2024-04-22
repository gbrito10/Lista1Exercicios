using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            double media;

            Console.Write("Digite o primeiro valor");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor");
            b = int.Parse(Console.ReadLine());

            media = Math.Sqrt(a * b);

            Console.Write("A média geométrica é: {0}", media);
        }
    }
}
