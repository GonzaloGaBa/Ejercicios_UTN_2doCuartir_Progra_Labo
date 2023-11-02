namespace Ejercicio04
{
    internal class Program
    {
        //Consigna
        //Realizar un programa que permita realizar operaciones matemáticas simples(suma, resta, multiplicación y división).

        //Crear una clase llamada Calculadora que posea dos métodos estáticos(de clase):

        //Calcular(público) : Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.El método devolverá el resultado de la operación.

        //Validar(privado): Recibirá como parámetro el segundo operando.Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

        //Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

        //El usuario decidirá cuándo finalizar el programa.
        static void Main()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Write("Ingrese el primer operando: ");
                if (double.TryParse(Console.ReadLine(), out double primerOperando))
                {
                    Console.Write("Ingrese el segundo operando: ");
                    if (double.TryParse(Console.ReadLine(), out double segundoOperando))
                    {
                        Console.Write("Ingrese la operación (+, -, *, /): ");
                        char operacion = Console.ReadKey().KeyChar;
                        Console.WriteLine(); // Nueva línea después de la operación.

                        double resultado = Calculadora.Calcular(primerOperando, segundoOperando, operacion);
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Segundo operando inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Primer operando inválido.");
                }

                Console.Write("¿Desea realizar otra operación? (S/N): ");
                char respuesta = Console.ReadKey().KeyChar;
                continuar = (respuesta == 'S' || respuesta == 's');
                Console.WriteLine(); // Nueva línea después de la respuesta.
            }
        }
        class Calculadora
        {
            public static double Calcular(double primerOperando, double segundoOperando, char operacion)
            {
                switch (operacion)
                {
                    case '+':
                        return Sumar(primerOperando, segundoOperando);
                    case '-':
                        return Restar(primerOperando, segundoOperando);
                    case '*':
                        return Multiplicar(primerOperando, segundoOperando);
                    case '/':
                        if (Validar(segundoOperando))
                            return Dividir(primerOperando, segundoOperando);
                        else
                            Console.WriteLine("Error: División por cero.");
                        break;
                    default:
                        Console.WriteLine("Operación no válida.");
                        break;
                }

                return 0;
            }

            private static double Sumar(double a, double b)
            {
                return a + b;
            }

            private static double Restar(double a, double b)
            {
                return a - b;
            }

            private static double Multiplicar(double a, double b)
            {
                return a * b;
            }

            private static double Dividir(double a, double b)
            {
                return a / b;
            }

            private static bool Validar(double segundoOperando)
            {
                return segundoOperando != 0;
            }
        }


    }
}