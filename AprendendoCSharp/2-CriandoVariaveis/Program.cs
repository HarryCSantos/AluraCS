﻿using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 32;

            double salario;
            salario = 1350.00;
            salario.ToString("0.00");

            Console.WriteLine("Sir you are " + idade + " years old and your current salary is $ " + salario);
            Console.ReadLine();
        }
    }
}
