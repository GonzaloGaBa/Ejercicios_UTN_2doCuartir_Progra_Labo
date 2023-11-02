namespace Ejercicio06
{
    internal class Program
    {
        //Consigna
        //Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase(estáticos) que realicen el cálculo del área que corresponda:

        //public double CalcularAreaCuadrado(double longitudLado) { }

        //public double CalcularAreaTriangulo(double base, double altura) { }

        //public double CalcularAreaCirculo(double radio) { }

        //El ingreso de los datos como la visualización se deberán realizar desde el método Main().

        static void Main()
        {
            Console.WriteLine("1. Calcular área de un cuadrado");
            Console.WriteLine("2. Calcular área de un triángulo");
            Console.WriteLine("3. Calcular área de un círculo");
            Console.Write("Seleccione una opción (1-3): ");

            if (int.TryParse(Console.ReadLine(), out int opcion) && opcion >= 1 && opcion <= 3)
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la longitud del lado del cuadrado: ");
                        if (double.TryParse(Console.ReadLine(), out double longitudLadoCuadrado))
                        {
                            double areaCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(longitudLadoCuadrado);
                            Console.WriteLine($"El área del cuadrado es: {areaCuadrado}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Ingrese una longitud válida.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese la base del triángulo: ");
                        if (double.TryParse(Console.ReadLine(), out double baseTriangulo))
                        {
                            Console.Write("Ingrese la altura del triángulo: ");
                            if (double.TryParse(Console.ReadLine(), out double alturaTriangulo))
                            {
                                double areaTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                                Console.WriteLine($"El área del triángulo es: {areaTriangulo}");
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
                        break;

                    case 3:
                        Console.Write("Ingrese el radio del círculo: ");
                        if (double.TryParse(Console.ReadLine(), out double radioCirculo))
                        {
                            double areaCirculo = CalculadoraDeArea.CalcularAreaCirculo(radioCirculo);
                            Console.WriteLine($"El área del círculo es: {areaCirculo}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Ingrese un radio válido.");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: Seleccione una opción válida (1-3).");
            }
        }

    }
    class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return Math.Pow(longitudLado, 2);
        }

        public static double CalcularAreaTriangulo(double @base, double altura)
        {
            return 0.5 * @base * altura;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}