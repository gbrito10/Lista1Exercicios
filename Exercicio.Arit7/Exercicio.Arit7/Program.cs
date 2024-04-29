using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Arit7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double MilhaMaritimaParaMetro = 1852;
            const double MetroParaQuilometro = 0.001;

            Console.WriteLine("Digite a quantidade de milhas marítimas: ");
            double milhasMaritimas = Convert.ToDouble(Console.ReadLine());

            double quilometros = (milhasMaritimas * MilhaMaritimaParaMetro) * MetroParaQuilometro;

            Console.WriteLine($"{milhasMaritimas} milhas marítimas equivalem a {quilometros} quilômetros");

            
        }
    }
}
