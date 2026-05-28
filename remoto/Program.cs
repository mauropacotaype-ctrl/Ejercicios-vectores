using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de puntos (x, y)
        List<(double x, double y)> puntos = new List<(double, double)>
        {
            (5,4),(6,4),(7,4),(-5,4),(-7,4),(0,0),(3,3)
        };
        int contador = 0;
        foreach (var p in puntos)
        {
            double x = p.x;
            double y = p.y;

            // Circunferencia c1
            bool dentroC1 = Math.Pow(x - 5, 2) + Math.Pow(y - 4, 2) <= Math.Pow(2, 2);

            // Circunferencia c2
            bool dentroC2 = Math.Pow(x + 5, 2) + Math.Pow(y - 4, 2) <= Math.Pow(3, 2);

            if (dentroC1 || dentroC2)
            {
                contador++;
                Console.WriteLine($"Punto ({x},{y}) está dentro.");
            }
        }
        Console.WriteLine($"\nCantidad total de puntos dentro de las circunferencias: {contador}");
    }
}
