namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Consigna
            //Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

            //Validar que el dato ingresado por el usuario sea un número.

            //Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

            //Si ingresa "salir", cerrar la consola.

            //Al finalizar, preguntar al usuario si desea volver a operar.Si la respuesta es afirmativa, iterar.De lo contrario, cerrar la consola.


            bool operador = true;

            while (operador)
            {
                Console.WriteLine("Ingrese un numero o presione 'salir'");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int numeroIngresado))
                {
                    List<int> primosHastaN = ObtenerPrimosHastaN(numeroIngresado);

                    Console.WriteLine($"Números primos hasta {numeroIngresado}:");
                    foreach (int primo in primosHastaN)
                    {
                        Console.Write($"{primo} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Dato incorrecto.Porfavor ingrese un numero o presione 'salir'");
                    if (input.ToLower() == "salir")
                    {
                        operador = false;
                    }
                }

                Console.Write("¿Desea volver a operar? (sí/no): ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() == "no")
                {
                    operador = false;
                }

            }

            Console.WriteLine("Hasta luego. Presione cualquier tecla para salir.");
            Console.ReadKey();


            static bool EsNumeroPrimo(int numeroIngresado)
            {
                if (numeroIngresado < 2)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(numeroIngresado); i++)
                {
                    if (numeroIngresado % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            static List<int> ObtenerPrimosHastaN(int n)
            {
                List<int> primos = new List<int>();

                for (int i = 2; i <= n; i++)
                {
                    if (EsNumeroPrimo(i))
                    {
                        primos.Add(i);
                    }
                }

                return primos;
            }
        }

    }
}