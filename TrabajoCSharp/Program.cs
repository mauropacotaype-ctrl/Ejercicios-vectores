using System;   
class Program 
{
    static void Main()
    {   
            Console.Write( "introduce un numero entero positivo para calcular su factorial: " );
            int numero = int.Parse( Console.ReadLine()! );
            int i =1;
            int j =1;
            int factorial = 1;
            if ( numero < 0)
                { 
                    Console.WriteLine( " valor no calido ( debe ser positivo y entero )" );
                return;
                }

            else{
            
                for ( i = 1 ; i <= numero ; i++ )
                    {
                        factorial = 1;
                        for ( j= 1 ;j<= i ; j++)
                            { 
                                factorial = factorial*j;
                            }
                            Console.WriteLine( "el factorial de " + i +" es: " + factorial );
                    }
                }
                Console.ReadKey();
    }
}
