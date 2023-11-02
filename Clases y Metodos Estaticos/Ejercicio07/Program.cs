namespace Ejercicio07
{
    internal class Program
    {
        //Consigna
        //Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

        //El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

        //Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

        //Mostrar el resultado en la consola.

        static void Main()
        {
            Console.Write("Ingrese la base del triángulo en centímetros: ");
            if (double.TryParse(Console.ReadLine(), out double baseTriangulo) && baseTriangulo > 0)
            {
                Console.Write("Ingrese la altura del triángulo en centímetros: ");
                if (double.TryParse(Console.ReadLine(), out double alturaTriangulo) && alturaTriangulo > 0)
                {
                    double hipotenusa = CalcularHipotenusa(baseTriangulo, alturaTriangulo);
                    Console.WriteLine($"La longitud de la hipotenusa es: {hipotenusa} centímetros");
                }
                else
                {
                    Console.WriteLine("Error: Ingrese una altura válida.");
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese una base válida.");
            }
        }

        static double CalcularHipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            double cuadradoBase = Math.Pow(baseTriangulo, 2);
            double cuadradoAltura = Math.Pow(alturaTriangulo, 2);
            double sumaCuadrados = cuadradoBase + cuadradoAltura;

            double hipotenusa = Math.Sqrt(sumaCuadrados);
            return hipotenusa;
        }
    }
}