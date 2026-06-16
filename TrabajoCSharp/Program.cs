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
        Console.WriteLine("Ejecutando Ejercicio 2");
    }
}
class Ejercicio3
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
    }
}
class Ejercicio4
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
    }
}
class Ejercicio5
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando Ejercicio 2");
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