using System.ComponentModel.DataAnnotations;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int numero;

            while (continuar)
            {
                Console.WriteLine("Ingrese un número entero:");

                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    // Aquí puedes hacer lo que necesites con el número, en este caso, simplemente sumarlo.

                    Console.Write("¿Desea continuar? (S/N): ");
                    string respuesta = Console.ReadLine();

                    continuar = Validador.ValidarRespuesta(respuesta);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                }
            }

            Console.WriteLine("Programa finalizado.");
        }
        class Validador
        {
            public static bool ValidarRespuesta(string respuesta)
            {
                return respuesta.ToUpper() == "S";
            }
        }
    }
}