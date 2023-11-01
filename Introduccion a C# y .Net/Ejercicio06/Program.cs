namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Consigna
            //Escribir un programa que determine si un año es bisiesto.

            //Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.

            //Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.

            //IMPORTANTE
            //Utilizar sentencias de iteración, selectivas y el operador módulo(%).

    
            Console.Write("Ingrese el año de inicio: ");
            int añoInicio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el año de fin: ");
            int añoFin = int.Parse(Console.ReadLine());

            Console.WriteLine($"Años bisiestos entre {añoInicio} y {añoFin}:");

            for (int año = añoInicio; año <= añoFin; año++)
            {
                if (EsBisiesto(año))
                {
                    Console.WriteLine(año);
                }
            }

            Console.WriteLine("Presione cualquier tecla para cerrar la consola.");
            Console.ReadKey();
            

            static bool EsBisiesto(int año)
            {
                // Un año es bisiesto si es múltiplo de 4.
                // Los años múltiplos de 100 no son bisiestos, salvo si también son múltiplos de 400.

                return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
            }
        }

    }
}
}