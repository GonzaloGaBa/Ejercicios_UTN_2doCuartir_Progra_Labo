namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Consigna
            //Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos(excluido el mismo)
            //que son divisores del número.

            //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

            //Escribir una aplicación que encuentre los 4 primeros números perfectos.

            //IMPORTANTE
            //Utilizar sentencias de iteración y selectivas.

            int contador = 4;
            int numero = 1; // Comenzamos desde 1 para buscar números perfectos positivos
            List<int> numerosPerfectos = new List<int>();

            for (int i = 0; i < contador;)
            {
                if (EsNumeroPerfecto(numero))
                {
                    numerosPerfectos.Add(numero);
                    i++; // Incrementar el contador solo cuando encontramos un número perfecto
                }

                numero++;
            }

            // Mostrar los números perfectos almacenados en la lista
            Console.WriteLine("Los números perfectos almacenados en la lista:");
            foreach (var numPerfecto in numerosPerfectos)
            {
                Console.WriteLine(numPerfecto);
            }

            Console.WriteLine("Presione cualquier tecla para cerrar la consola.");
            Console.ReadKey();
        }

        static bool EsNumeroPerfecto(int numero)
        {
            int sumaDivisores = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                }
            }

            return sumaDivisores == numero;
        }
    }
}