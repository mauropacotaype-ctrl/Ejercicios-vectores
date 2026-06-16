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
        Console.Write("Ingrese el tamaño del vector: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] vector = new int[n];

        Console.WriteLine("\nIngrese los elementos del vector:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Vector[{i}] = ");
            vector[i] = int.Parse(Console.ReadLine()!);
        }

        int minimo = vector[0];

        for (int i = 1; i < n; i++)
        {
            if (vector[i] < minimo)
            {
                minimo = vector[i];
            }
        }

        Console.WriteLine($"\nEl elemento mínimo es: {minimo}");
    }
}
class Ejercicio7
{
    public void Ejecutar()
    {
    Console.Write("Ingrese el tamaño del vector: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] vector = new int[n];

        Console.WriteLine("\nIngrese los elementos del vector:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Vector[{i}] = ");
            vector[i] = int.Parse(Console.ReadLine()!);
        }

        int maximo = vector[0];

        for (int i = 1; i < n; i++)
        {
            if (vector[i] > maximo)
            {
                maximo = vector[i];
            }
        }

        Console.WriteLine($"\nEl elemento máximo es: {maximo}");
    }
    }
class Ejercicio8
{
    public void Ejecutar()
    {
        Console.Write("Ingrese el número de filas: ");
        int m = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el número de columnas: ");
        int n = int.Parse(Console.ReadLine()!);

        int[,] matriz = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Matriz[{i},{j}] = ");
                matriz[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        int minimo = matriz[0, 0];
        int maximo = matriz[0, 0];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matriz[i, j] < minimo)
                {
                    minimo = matriz[i, j];
                }

                if (matriz[i, j] > maximo)
                {
                    maximo = matriz[i, j];
                }
            }
        }

        Console.WriteLine($"\nMenor elemento: {minimo}");
        Console.WriteLine($"Mayor elemento: {maximo}");
    }
}
class Ejercicio9
{
    public void Ejecutar()
    {
        Console.Write("Ingrese el número de filas (m): ");
        int m = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el número de columnas (n): ");
        int n = int.Parse(Console.ReadLine()!);

        int[,] matriz = new int[m, n];

        Console.WriteLine("\nIngrese los elementos de la matriz:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Matriz[{i},{j}] = ");
                matriz[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        Console.WriteLine("\nSuma de cada fila:");

        for (int i = 0; i < m; i++)
        {
            int suma = 0;

            for (int j = 0; j < n; j++)
            {
                suma += matriz[i, j];
            }

            Console.WriteLine($"Fila {i}: {suma}");
        }
    }
}
class Ejercicio10
{
    public void Ejecutar()
    {
           Console.Write("Ingrese el número de filas (m): ");
        int m = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el número de columnas (n): ");
        int n = int.Parse(Console.ReadLine()!);

        int[,] matriz = new int[m, n];

        Console.WriteLine("\nIngrese los elementos de la matriz:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Matriz[{i},{j}] = ");
                matriz[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        Console.WriteLine("\nSuma de cada columna:");

        for (int j = 0; j < n; j++)
        {
            int suma = 0;

            for (int i = 0; i < m; i++)
            {
                suma += matriz[i, j];
            }

            Console.WriteLine($"Columna {j}: {suma}");
        }
    }
}
class Ejercicio11
{
    public void Ejecutar()
    {
        Console.Write("Ingrese el número de filas y columnas (m): ");
        int m = int.Parse(Console.ReadLine()!);
        int n = m;

        int[,] matriz = new int[m, n];

        Console.WriteLine("\nIngrese los elementos de la matriz:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Matriz[{i},{j}] = ");
                matriz[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        int suma = 0;

        for (int i = 0; i < m; i++)
        {
            suma += matriz[i, i];
        }

        Console.WriteLine($"\nSuma de la diagonal principal: {suma}");
    }
}
class Ejercicio12
{
    public void Ejecutar()
    {
        Console.Write("Ingrese el número de filas y columnas (m): ");
        int m = int.Parse(Console.ReadLine()!);
        int n = m; 

        int[,] matriz = new int[m, n];

        Console.WriteLine("\nIngrese los elementos de la matriz:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Matriz[{i},{j}] = ");
                matriz[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        int suma = 0;

        for (int i = 0; i < m; i++)
        {
            suma += matriz[i, n - 1 - i];
        }

        Console.WriteLine("\nMatriz ingresada:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nSuma de la diagonal secundaria: {suma}");
    }
}
class Ejercicio13
{
    public void Ejecutar()
    {
        Console.Write("Ingrese el número de filas (m): ");
        int m = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el número de columnas (n): ");
        int n = int.Parse(Console.ReadLine()!);

        int[,] matriz = new int[m, n];

        Console.WriteLine("\nIngrese los elementos de la matriz:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        // Cantidad de elementos del borde
        int tam = 2 * m + 2 * n - 4;
        int[] v = new int[tam];

        int k = 0;

        // Fila superior (izq -> der)
        for (int j = 0; j < n; j++)
            v[k++] = matriz[0, j];

        // Columna derecha (arriba -> abajo)
        for (int i = 1; i < m; i++)
            v[k++] = matriz[i, n - 1];

        // Fila inferior (der -> izq)
        for (int j = n - 2; j >= 0; j--)
            v[k++] = matriz[m - 1, j];

        // Columna izquierda (abajo -> arriba)
        for (int i = m - 2; i > 0; i--)
            v[k++] = matriz[i, 0];

        Console.WriteLine("\nVector de bordes en sentido horario:");

        for (int i = 0; i < v.Length; i++)
        {
            Console.Write(v[i] + " ");
        }

        Console.WriteLine();
    }
}
class Ejercicio14
{
    public void Ejecutar()
    {
        Console.Write("Ingrese el tamaño de la matriz (m x n): ");
        int n = int.Parse(Console.ReadLine()!);

        int[,] matriz = new int[n, n];

        Console.WriteLine("\nIngrese los elementos de la matriz:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        int suma = 0;

        Console.WriteLine("\nElementos que forman la letra N:\n");

          
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0 || j == n - 1 || i == j)
                {
                    Console.Write(matriz[i, j] + " ");
                    suma += matriz[i, j];
                }
            }
        }

        Console.WriteLine($"Suma = {suma}\n\n");

         Console.WriteLine("Su forma en N es:\n"); 
        for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == 0 || j == n - 1 || i == j)
                            Console.Write($"{matriz[i, j],4}");
                        else
                            Console.Write("    ");
                    }
                    Console.WriteLine();
                }
    }
}