namespace Ejercicio09
{
    internal class Program
    {
        //Consigna
        //El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

        //En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.

        static void Main()
        {
            Console.Write("Ingrese un número para calcular su factorial: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
            {
                long factorial = CalcularFactorial(numero);
                Console.WriteLine($"El factorial de {numero} es: {factorial}");
            }
            else
            {
                Console.WriteLine("Error: Ingrese un número entero no negativo.");
            }
        }

        static long CalcularFactorial(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return 1; // El factorial de 0 y 1 es siempre 1.
            }

            long resultado = 1;

            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}