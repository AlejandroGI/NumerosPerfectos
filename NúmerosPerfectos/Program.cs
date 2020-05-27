//Los números perfectos son aquellos que la suma de sus divisores (exepto el mísmo número) da como resultado el mismo número
//En teoría, nadie a encontrado un patrón para los números mas altos (del 6 en adelante), incluso los algoritmos en internet
//hacen que e procesador del anfitrión se relentice y se demore horas en encontrar los números mayores a 5...

//La siguiente aplicación de consola será demaciado sencilla en tanto a interfáz, ya que será un algoritmo lo mejor optimizado por mi (AlejandroGI)
//para lograr la mejor performance de cómputo en el programa

/*
 * SUGERENCIAS DE OPTIMIZACIÓN:
 * -    Los divisores solo llegan hasta la mitad del número, ya que no cabe la mitad de un volumen en otro trozo un poco mayor a dicha mitad. (los divisores solo son hasta la mitád del número)        LISTO
 * -    Si la operación de suma de sus divisores se pasó del número, el número no es perfecto. Por lo que se puede comenzar la suma desde los últimos divisores                                         LISTO
 * -    Los números impares SOLO PUEDEN TENER DIVISORES IMPARES                                                                                                                                         LISTO
 * -    Los números primos son divisibles sólo entre 1 y el mísmo número, lo que ahorra cómputo descubrirlos antes que todo...(si es par, ya no será primo (única exepción el 2))                       Listo
 */
using System;
using System.Diagnostics;

namespace NúmerosPerfectos
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Thread calcularPrimos = new Thread(AcumuladorDePrimos);
                //calcularPrimos.Start();
                ulong indice;                                       //Intento de número perfecto.
                ulong divisores;                                    //acumulador de divisores.
                Console.WriteLine("calcuadora de números perfectos");
                Stopwatch tiempo = new Stopwatch();
                tiempo.Start();
                for (indice = 2; indice <= ulong.MaxValue; indice++)
                {
                    divisores = 1;
                    if (indice % 2 == 0)                            //Es par.
                    {
                        for (ulong i = indice / 2; i > 1; i--)      //i es la mitad del índice (para ahorrar vueltas) y se recorre del mayor divisor hasta 1.
                        {
                            if (indice % i == 0) divisores += i;    //si el intento de número perfecto es dibicible por el actual índice, se suma a la lista de divisores.
                            if (divisores > indice) break;
                        }
                    }
                    else                                            //es impar.
                    {
                        if (esPrimo(indice) == true)                //es primo
                        {
                            Console.WriteLine($"es primo  {tiempo.Elapsed.TotalMinutes}");
                            divisores = divisores;
                        }
                        else                                        //no es primo
                        {
                            for (ulong i = indice / 2; i > 1; i -= 2)//impares solo tienen divisores impares.
                            {
                                if (indice % i == 0) divisores += i;
                                if (divisores > indice) break;
                            }
                        }
                    }
                    if (divisores == indice)                        //si la suma de divisores (exepto sumar el mísmo indice) da el mismo indice, es perfecto.
                    {
                        Console.WriteLine($"Numero perfecto : {indice}  | Tiempo demorado en minutos: {tiempo.Elapsed.TotalMinutes}");
                    }
                }
            }
        }
        public static bool esPrimo(ulong numero)                    //discrimina si es primo o no
        {
            ulong divisor = 2;
            ulong resto = 0;
            while (divisor < numero)
            {
                resto = numero % divisor;
                if (resto == 0)
                {
                    return false;
                }
                divisor = divisor + 1;
            }
            return true;
        }
    }
}
