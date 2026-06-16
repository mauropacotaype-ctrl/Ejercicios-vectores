using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número del ejercicio: ");
        int ejercicio = int.Parse(Console.ReadLine());

        switch (ejercicio)
        {
            case 1:
                Ejercicio1();
                break;

            case 2:
                Ejercicio2();
                break;

            case 3:
                Ejercicio3();
                break;

            default:
                Console.WriteLine("Ese ejercicio no existe.");
                break;
        }
    }

    static void Ejercicio1()
    {
        Console.WriteLine("Ejecutando Ejercicio 1");
    }

    static void Ejercicio2()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
    }

    static void Ejercicio3()
    {
        Console.WriteLine("Ejecutando Ejercicio 3");
    }
}