﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = { "JOÃO", "PEDRO", "MARIA" };
            Console.WriteLine("Digite um numero de 0 a 2: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("O nome selecionado foi: " + nome[i]);
            Console.ReadKey();
        }
    }
}
