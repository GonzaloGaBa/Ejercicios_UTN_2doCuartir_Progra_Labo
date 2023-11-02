using System.Text;

namespace Ejercicio05
{
    internal class Program
    {
        //Consigna
        //Crear una aplicación de consola que permita al usuario ingresar un número entero.

        //Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

        //Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

        //Mostrar en la consola el resultado.

        //Por ejemplo, si se ingresa el número 2 la salida deberá ser:

        //Tabla de multiplicar del número 2:
        //2 x 1 = 2
        //2 x 2 = 4
        //2 x 3 = 6
        //2 x 4 = 8
        //2 x 5 = 10
        //2 x 6 = 12
        //2 x 7 = 14
        //2 x 8 = 16
        //2 x 9 = 18

        static void Main()
        {
            Console.Write("Ingrese un número entero: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                string tablaMultiplicar = ObtenerTablaMultiplicar(numero);
                Console.WriteLine(tablaMultiplicar);
            }
            else
            {
                Console.WriteLine("Error: Ingrese un número entero válido.");
            }
        }

        static string ObtenerTablaMultiplicar(int numero)
        {
            StringBuilder resultado = new StringBuilder();
            resultado.AppendLine($"Tabla de multiplicar del número {numero}:");

            for (int i = 1; i <= 9; i++)
            {
                int producto = numero * i;
                resultado.AppendLine($"{numero} x {i} = {producto}");
            }

            return resultado.ToString();
        }


    }
}