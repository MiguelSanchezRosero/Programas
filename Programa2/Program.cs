using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int VALOR1 = 25;
            int VALOR2 = 5;
            int VALOR3 = 2;
            int Resultado = 0;

            Resultado = (VALOR1 + VALOR2) * VALOR3;
            Console.WriteLine("");
            Console.WriteLine("La suma de {0} mas {1}, multiplicado por {2}, es igual a {3}", VALOR1, VALOR2, VALOR3, Resultado);

        }
    }
}