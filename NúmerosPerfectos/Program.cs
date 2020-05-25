//Los números perfectos son aquellos que la suma de sus divisores (exepto el mísmo número) da como resultado el mismo número
//En teoría, nadie a encontrado un patrón para los números mas altos (del 6 en adelante), incluso los algoritmos en internet
//hacen que e procesador del anfitrión se relentice y se demore horas en encontrar los números mayores a 5...

//La siguiente aplicación de consola será demaciado sencilla en tanto a interfáz, ya que será un algoritmo lo mejor optimizado por mi (AlejandroGI)
//para lograr la mejor performance de cómputo en el programa

/*
 * SUGERENCIAS DE OPTIMIZACIÓN:
 * -    Los divisores solo llegan hasta la mitad del número, ya que no cabe la mitad de un volumen en otro trozo un poco mayor a dicha mitad. (los divisores solo son hasta la mitád del número)
 * -    Si la operación de suma de sus divisores se pasó del número, el número no es perfecto. Por lo que se puede comenzar la suma desde los últimos divisores
 * -    Si el cuociente de la división es un número entero, se obtienen dos divisores, el divisor y el cuociente (resultado como número entero de la división)
 * -    Los números impares SOLO PUEDEN TENER DIVISORES IMPARES
 */
using System;
using System.Diagnostics;

namespace NúmerosPerfectos
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong indice;
            ulong primerDivisor;
            Console.WriteLine("CALCULADORA DE NPUMEROS PERFECTOS. Precione Enter para comenzar a calcular");
            Console.ReadLine();
            Stopwatch tiempo = new Stopwatch();
            tiempo.Start();
            for (indice = 2; indice <= ulong.MaxValue; indice++)
                {
                
                primerDivisor = 1;
                for (ulong i = indice/2 ; i > 1 ; i--)
                {   
                    if (indice % i == 0) primerDivisor += i;
                    if (primerDivisor> indice) break;
                }
                if (primerDivisor == indice)
                {
                    Console.WriteLine($"Numero perfecto : {indice}  | Tiempo demorado en minutos: {tiempo.Elapsed.TotalMinutes}");
                }
            }
        }
    }
}