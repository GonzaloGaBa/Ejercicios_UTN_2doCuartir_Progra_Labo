using System;
using System.Drawing;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Consigna
            //Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad(en años) y
            //la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

            //Se pide calcular el importe a cobrar teniendo en cuenta que el total
            //(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
            //hay que sumarle la cantidad de años trabajados multiplicados por $150,
            //y al total de todas esas operaciones restarle el 13 % en concepto de descuentos.

            //Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora,
            //el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.

            //IMPORTANTE
            //Utilizar sentencias de iteración y selectivas.

            //No es necesario ni se deben utilizar vectores/ arrays.

            //SOLICITAR LA CANTIDAD DE EMPLEADOS
            Console.WriteLine("Ingrese la cantidad de empleados:");
            int cantidadDeEmpleados = int.Parse(Console.ReadLine());

            // Inicializar variables para el total bruto y neto
            double totalBruto = 0;
            double totalNeto = 0;

            //ITERAR SOBRE CADA EMPLEADO
            for (int empleado = 0; empleado <= cantidadDeEmpleados; empleado++)
            {
                Console.WriteLine($"\nDatos del epmleado {empleado}");

                //SOLICITAR DATOS DEL EMPLEADO
                Console.WriteLine("Ingrese el nombre: ");
                string nombre = Console.ReadLine();

                //valor hora,
                Console.WriteLine("Ingrese el valor Hora: ");
                double valorHora = double.Parse(Console.ReadLine());

                //la antigüedad(en años) 
                Console.WriteLine("Ingrese años de antiguedad: ");
                int añosDeAntiguedad = int.Parse(Console.ReadLine());

                //la cantidad de horas trabajadas
                Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
                int cantidadDeHorasTrabajadas = int.Parse(Console.ReadLine());

                // Calcular el total bruto
                double totalBrutoEmpleado = (valorHora * cantidadDeHorasTrabajadas) + (añosDeAntiguedad * 150);

                // Calcular el descuento del 13%
                double descuento = totalBrutoEmpleado * 0.13;

                // Calcular el total neto
                double totalNetoEmpleado = totalBrutoEmpleado - descuento;

                // Acumular al total bruto y neto globales
                totalBruto += totalBrutoEmpleado;
                totalNeto += totalNetoEmpleado;

                // Mostrar el recibo
                Console.WriteLine($"\nRecibo para {nombre}:");
                Console.WriteLine($"Antigüedad: {añosDeAntiguedad} años");
                Console.WriteLine($"Valor hora: ${valorHora}");
                Console.WriteLine($"Total a cobrar bruto: ${totalBrutoEmpleado}");
                Console.WriteLine($"Total a cobrar neto: ${totalNetoEmpleado}");
            }

            // Mostrar el total bruto y neto de todos los empleados
            Console.WriteLine($"\nTotal a cobrar bruto de todos los empleados: ${totalBruto}");
            Console.WriteLine($"Total a cobrar neto de todos los empleados: ${totalNeto}");
        }
    }    
}