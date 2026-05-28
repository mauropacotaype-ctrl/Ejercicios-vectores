using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Operacion de suma y productos de dos fracciones");
        Console.WriteLine("Fraccion 1:");
        Console.WriteLine("Inserte un numero para el numerador:");
        int A = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Inserte un numero para el denominador:");
        int B = int.Parse(Console.ReadLine()!);

        if (A < 0 || B <= 0)
        {
            Console.WriteLine("Error: Numerador debe ser mayor o igual a 0 y denominador debe ser mayor a 0.");
            return;
        }
        Console.WriteLine("Fraccion 2:");
        Console.WriteLine("Inserte un numero para el numerador:");
        int C = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Inserte un numero para el denominador:");
        int D = int.Parse(Console.ReadLine()!);
        double Suma ;
        double Producto ;
    if (A >= 0 && B > 0 && C >= 0 && D > 0)
        {
            Suma = (double)((A * D) + (C * B)) / (B * D);
            Producto = (double)(A * C) / (B * D);
            Console.WriteLine("El resultado de la suma es: " + Suma);
            Console.WriteLine("El resultado del producto es: " + Producto);
        }
        else
        {
            Console.WriteLine("Error: Numeradores deben ser mayores o iguales a 0 y denominadores deben ser mayores a 0."); 
        }
    }
}