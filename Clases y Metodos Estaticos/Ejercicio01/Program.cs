using System.ComponentModel.DataAnnotations;
using System;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Consigna
            //Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

            //bool Validar(int valor, int min, int max)

            //valor: dato a validar.
            //min: mínimo valor incluido.
            //max: máximo valor incluido.
            //Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango - 100 y 100.

            //Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

            //IMPORTANTE
            // Utilizar variables escalares, NO utilizar vectores/ arrays.

       
            int cantidadNumeros = 10;
            int suma = 0;
            int valorMinimo = int.MaxValue;
            int valorMaximo = int.MinValue;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (Validador.Validar(numero, -100, 100))
                    {
                        suma += numero;

                        if (numero < valorMinimo)
                            valorMinimo = numero;

                        if (numero > valorMaximo)
                            valorMaximo = numero;
                    }
                    else
                    {
                        Console.WriteLine("Número fuera del rango permitido. Inténtelo de nuevo.");
                        i--; // Decrementar el índice para volver a solicitar el mismo número.
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Inténtelo de nuevo.");
                    i--; // Decrementar el índice para volver a solicitar el mismo número.
                }
            }

            double promedio = (double)suma / cantidadNumeros;

            Console.WriteLine($"Valor mínimo ingresado: {valorMinimo}");
            Console.WriteLine($"Valor máximo ingresado: {valorMaximo}");
            Console.WriteLine($"Promedio de los números ingresados: {promedio}");

            Console.ReadLine(); // Para que la consola no se cierre inmediatamente.
            

        }

        class Validador
        {
            public static bool Validar(int valor, int min, int max)
            {
                return valor >= min && valor <= max;
            }
                
        }
    }
}