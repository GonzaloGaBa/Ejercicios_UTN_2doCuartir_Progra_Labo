namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Consigna
            Ingresar 5 números por consola, guardándolos en una variable escalar.
            Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
            */
            const int numeroMaximosIngresado = 5;
            int escalar;
            int valorMaximo = int.MaxValue;
            int valorMinimo = int.MinValue;
            double suma = 0;

            for (int i = 0; i < numeroMaximosIngresado; i++)
            {
                Console.WriteLine("Ingrese un numero");
                string numeroIngresado = Console.ReadLine();

                if (int.TryParse(numeroIngresado, out escalar))
                {
                    Console.WriteLine("Numero ingresado Correctamente");

                    //Cacular maximo.
                    if (escalar > valorMaximo)
                    {
                        valorMaximo = escalar;
                    }

                    //Calcular Minimo.
                    if (escalar < valorMinimo)
                    {
                        valorMinimo = escalar;
                    }

                    suma += escalar;
                }
                else
                {
                    Console.WriteLine("Dato incorrecto");
                }
            }

            double promedio = suma / numeroMaximosIngresado;

            Console.WriteLine($"Valor Maximo: {valorMaximo}");
            Console.WriteLine($"Valor Minimo: {valorMinimo}");
            Console.WriteLine($"Valor Promedio: {promedio}");

        }
    }
}