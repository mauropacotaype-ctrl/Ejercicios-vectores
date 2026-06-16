using System;


class Program
{
    static void Main()
    {
        Console.Write("Número de ejercicio: ");
        int n = int.Parse(Console.ReadLine()!);

        switch (n)
        {
            case 1:
                new Ejercicio1().Ejecutar();
                break;
            case 2:
                new Ejercicio2().Ejecutar();
                break;
                 case 3:
                new Ejercicio3().Ejecutar();
                break;
                 case 4:
                new Ejercicio4().Ejecutar();
                break;
                 case 5:
                new Ejercicio5().Ejecutar();
                break;
                 case 6:
                new Ejercicio6().Ejecutar();
                break;
                 case 7:
                new Ejercicio7().Ejecutar();
                break;
                 case 8:
                new Ejercicio8().Ejecutar();
                break;
                 case 9:
                new Ejercicio9().Ejecutar();
                break;
                case 10:
                new Ejercicio10().Ejecutar();
                break;
                case 11:
                new Ejercicio11().Ejecutar();
                break;
                case 12:
                new Ejercicio12().Ejecutar();
                break;
                case 13:
                new Ejercicio13().Ejecutar();
                break;
                case 14:
                new Ejercicio14().Ejecutar();
                break;
            default:
                Console.WriteLine("Ejercicio no encontrado");
                break;
        }
    }
}
class Ejercicio1
{
    public void Ejecutar()
    {
        Console.Write("Ingrese la cantidad de elementos del vector: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] vector = new int[n];
        double suma = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento [{i}]: ");
            vector[i] = int.Parse(Console.ReadLine()!);
            suma += vector[i];
        }

        double media = suma / n;

        Console.WriteLine("La media es: " + media); 
    }
}
class Ejercicio2
{
    public void Ejecutar()
    {
        int n = 5;
        int[] vector = new int[n];
        int sumaCuadrados = 0;

        for (int i = 0; i < n ; i++)
        {
            Console.Write($"Ingrese el elemento {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine()!);

            sumaCuadrados += vector[i] * vector[i];
        }

        Console.WriteLine($"\nLa suma de los cuadrados de las componentes es: {sumaCuadrados}");
    }
}
class Ejercicio3
{
    public void Ejecutar()
    {
        Console.Write("Ingrese el tamaño de los vectores: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] v = new int[n];
        int[] w = new int[n];

        Console.WriteLine("\nIngrese los elementos del vector V:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"V[{i}] = ");
            v[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("\nIngrese los elementos del vector W:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"W[{i}] = ");
            w[i] = int.Parse(Console.ReadLine()!);
        }

        int productoEscalar = 0;

        for (int i = 0; i < n; i++)
        {
            productoEscalar += v[i] * w[i];
        }

        Console.WriteLine($"\nEl producto escalar es: {productoEscalar}");
    }
}
class Ejercicio4
{
    public void Ejecutar()
    {
        Console.Write("Ingrese el tamaño del vector: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] vector = new int[n];
        int[] resultado = new int[n];

        Console.WriteLine("\nIngrese los elementos del vector:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Vector[{i}] = ");
            vector[i] = int.Parse(Console.ReadLine()!);
        }

        Console.Write("\nIngrese el número por el que desea multiplicar el vector: ");
        int numero = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            resultado[i] = vector[i] * numero;
        }

        Console.WriteLine("\nVector resultante:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(resultado[i] + " ");
        }

        Console.WriteLine();
    }
}
class Ejercicio5
{
    public void Ejecutar()
    {
        Console.Write("Ingrese el tamaño del vector: ");
        int n = int.Parse(Console.ReadLine()!);

        double[] vector = new double[n];
        double[] resultado = new double[n];

        Console.WriteLine("\nIngrese los elementos del vector:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Vector[{i}] = ");
            vector[i] = double.Parse(Console.ReadLine()!);
        }

        Console.Write("\nIngrese el número real a sumar: ");
        double numero = double.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            resultado[i] = vector[i] + numero;
        }

        Console.WriteLine("\nVector resultante:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(resultado[i] + " ");
        }

        Console.WriteLine();
    }
}
class Ejercicio6
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
    }
}
class Ejercicio7
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
    }
}
class Ejercicio8
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
    }
}
class Ejercicio9
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
    }
}
class Ejercicio10
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
    }
}
class Ejercicio11
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
    }
}
class Ejercicio12
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
    }
}
class Ejercicio13
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
    }
}
class Ejercicio14
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
    }
}