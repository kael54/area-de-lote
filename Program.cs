using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola, bienvenido a:");
        Console.WriteLine("Calculadora de precio de su lote");

        Console.WriteLine("Ingrese el ancho de su lote por favor:");
        double ancho = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el largo de su lote por favor:");
        double largo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el precio por metro cuadrado por favor:");
        double metro = Convert.ToDouble(Console.ReadLine());

        double area = ancho * largo;
        double precio = area * metro;

        Console.WriteLine($"El área de su lote es de: {area} metros cuadrados");
        Console.WriteLine($"El precio de su lote es: {precio}$");
    }
}
