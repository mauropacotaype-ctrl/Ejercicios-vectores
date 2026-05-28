 
            Console.Write( "introduce un numero entero positivo para calcular su factorial: " );
            int numero = int.Parse( Console.ReadLine() );

            if ( numero < 0)
            { 
                Console.WriteLine( " valor no calido ( debe ser positivo y entero )" );
                return;
            }

            else{
            int factorial = 1;
            for ( int i = 1 ; i <= numero ; i++ )
                        {
                            factorial = factorial *i;
                        }
            Console.WriteLine( "el factorial de " + numero + " es: " + factorial );         
                    }