using System;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Consigna
            //Escribir un programa que imprima por consola un triángulo.
            //El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo.
            //IMPORTANTE
            //Utilizar sentencias de iteración y selectivas.

            // Solicitar la altura del triángulo al usuario
            Console.Write("Ingrese la altura del triángulo (número entero positivo): ");
            int altura = int.Parse(Console.ReadLine());

            // Verificar que la altura sea un número positivo
            if (altura <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
                return;
            }

            // Imprimir el triángulo
            for (int i = 1; i <= altura; i++)
            {
                // Imprimir asteriscos
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                // Cambiar de línea después de cada fila
                Console.WriteLine();
            }
        }
    }
}