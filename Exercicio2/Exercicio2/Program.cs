﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l;
            int area;

       
            Console.WriteLine("Digite o valor da aresta do quadrado");
            l = int .Parse(Console.ReadLine());

            area = l * l;

            Console.WriteLine("O valor da área do quadrado é: ");

            Console.WriteLine(area);

        }
    }
}
