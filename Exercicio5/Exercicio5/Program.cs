using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int media;
            string aux;

            Console.WriteLine("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor: ");
            d = int.Parse(Console.ReadLine());

            media = (a + b + c + d) / 4;

            Console.WriteLine("a média aritmética é: ");
            Console.WriteLine(media);
                
                
        }
    }
}
