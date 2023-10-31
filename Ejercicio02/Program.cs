namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            //Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

            double numero;
            int alCuadrado = 2;
            int alCubo = 3;

            Console.WriteLine("Ingrese un numero: ");
            string numeroIngresado = Console.ReadLine();

            if (double.TryParse(numeroIngresado, out numero))
            {
                Console.WriteLine("Dato numerico ingresado");
                if (numero > 0)
                {
                    double resultadoElevadoAlCuadrado = Math.Pow(numero, alCuadrado);
                    double resultadoElevadoAlCubo = Math.Pow(numero, alCubo);

                    Console.WriteLine("Usted ingreso el numero {0}. \n " +
                              "El resultado de elevarlo al cuadrado es de: {1}. \n " +
                              "El resultado de elevarlo al cubo es de: {2}."
                              , numero, resultadoElevadoAlCuadrado , resultadoElevadoAlCubo);
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número! \n Pd: Debe ser mayor que 0");
                }
                
            }
            else
            {
                Console.WriteLine("Dato ingresado Incorrectamente, debe Ingresar un numero");
            }

          
        }
    }
}