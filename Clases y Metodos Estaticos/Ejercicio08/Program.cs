namespace Ejercicio08
{
    internal class Program
    {
        //Consigna
        //Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual.Tener en cuenta los años bisiestos.

        //Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

        //Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
        static void Main()
        {
            Console.Write("Ingrese la fecha de nacimiento (formato: dd/mm/yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
            {
                int diasVividos = CalcularDiasVividos(fechaNacimiento);
                Console.WriteLine($"Número de días vividos hasta la fecha actual: {diasVividos} días");
            }
            else
            {
                Console.WriteLine("Error: Ingrese una fecha de nacimiento válida.");
            }
        }

        static int CalcularDiasVividos(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;

            // Calcular la diferencia de días entre la fecha actual y la fecha de nacimiento.
            TimeSpan diferencia = fechaActual - fechaNacimiento;

            // Retornar el número total de días vividos.
            return diferencia.Days;
        }
    }
}