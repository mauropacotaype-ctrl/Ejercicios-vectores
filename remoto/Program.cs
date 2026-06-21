using System;

class Program
{
    static void Main()
    {
        // Días de cada mes (año no bisiesto)
        int[] diasMes =
        {31, 28, 31, 30,  31, 30, 31, 31, 30, 31, 30, 31  };
        Console.Write("Ingrese el mes (1-12): ");
        int mes = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el día: ");
        int dia = int.Parse(Console.ReadLine()!);

        int numeroDia = 0;

        // Sumar los días de los meses anteriores
        for (int i = 0; i < mes - 1; i++)
        {
            numeroDia += diasMes[i];
        }
        // Agregar el día ingresado
        numeroDia += dia;
        Console.WriteLine("El día corresponde al número: " + numeroDia);
    }
}


