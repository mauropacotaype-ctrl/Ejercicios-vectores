class Program
{
    static void Main()
    {   
        Console.WriteLine("La suma de los cuadrados de los primeros 100 números enteros naturales es:\n ");
        Console.WriteLine("La formula empleada es: n(n+1)(2n+1)/6 "  );
        int a = 100;
        int resultado = (a*(a+1)*(2*a+1))/6;
        Console.WriteLine("El resultado es: " + resultado);   
    }
}
