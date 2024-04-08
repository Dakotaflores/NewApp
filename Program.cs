// See https://aka.ms/new-console-template for more information
using System;

namespace CalculoAreaLote
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario las dimensiones del lote
            Console.WriteLine("Ingrese el ancho del lote en metros:");
            double ancho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el largo del lote en metros:");
            double largo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el precio por metro cuadrado del lote:");
            double precioPorMetroCuadrado = Convert.ToDouble(Console.ReadLine());

            // Calcular el área del lote
            double area = CalcularArea(ancho, largo);

            // Calcular el precio total del lote
            double precioTotal = CalcularPrecioTotal(area, precioPorMetroCuadrado);

            // Mostrar resultados
            Console.WriteLine($"El área del lote es: {area} metros cuadrados");
            Console.WriteLine($"El precio total del lote es: {precioTotal} dólares");
        }

        // Método para calcular el área del lote
        static double CalcularArea(double ancho, double largo)
        {
            return ancho * largo;
        }

        // Método para calcular el precio total del lote
        static double CalcularPrecioTotal(double area, double precioPorMetroCuadrado)
        {
            return area * precioPorMetroCuadrado;
        }
    }
}

