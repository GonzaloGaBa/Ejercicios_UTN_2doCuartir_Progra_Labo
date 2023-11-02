namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

            //El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

            //public string ConvertirDecimalABinario(int numeroEntero) { }

            //El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

            //public int ConvertirBinarioADecimal(int numeroEntero) { }

            //IMPORTANTE
            //NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
            static void Main()
            {
                // Ejemplo de uso
                int numeroDecimal = 25;
                string binarioResult = Conversor.ConvertirDecimalABinario(numeroDecimal);
                Console.WriteLine($"El número binario equivalente a {numeroDecimal} es: {binarioResult}");

                string binarioInput = "11001";
                int decimalResult = Conversor.ConvertirBinarioADecimal(binarioInput);
                Console.WriteLine($"El número decimal equivalente a {binarioInput} es: {decimalResult}");

                Console.ReadLine(); // Para que la consola no se cierre inmediatamente.
            }

        }
        class Conversor
        {
            public static string ConvertirDecimalABinario(int numeroEntero)
            {
                if (numeroEntero < 0)
                {
                    throw new ArgumentException("El número debe ser no negativo.");
                }

                if (numeroEntero == 0)
                {
                    return "0";
                }

                string binario = "";

                while (numeroEntero > 0)
                {
                    int residuo = numeroEntero % 2;
                    binario = residuo.ToString() + binario;
                    numeroEntero /= 2;
                }

                return binario;
            }

            public static int ConvertirBinarioADecimal(string binario)
            {
                if (!EsBinarioValido(binario))
                {
                    throw new ArgumentException("La cadena no representa un número binario válido.");
                }

                int decimalResult = 0;
                int longitud = binario.Length;

                for (int i = 0; i < longitud; i++)
                {
                    int bit = binario[i] - '0';
                    int posicion = longitud - i - 1;

                    int potencia = 1;
                    for (int j = 0; j < posicion; j++)
                    {
                        potencia *= 2;
                    }

                    decimalResult += bit * potencia;
                }

                return decimalResult;
            }

            private static bool EsBinarioValido(string binario)
            {
                foreach (char bit in binario)
                {
                    if (bit != '0' && bit != '1')
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}