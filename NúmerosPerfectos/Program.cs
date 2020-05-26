//Los números perfectos son aquellos que la suma de sus divisores (exepto el mísmo número) da como resultado el mismo número
//En teoría, nadie a encontrado un patrón para los números mas altos (del 6 en adelante), incluso los algoritmos en internet
//hacen que e procesador del anfitrión se relentice y se demore horas en encontrar los números mayores a 5...

//La siguiente aplicación de consola será demaciado sencilla en tanto a interfáz, ya que será un algoritmo lo mejor optimizado por mi (AlejandroGI)
//para lograr la mejor performance de cómputo en el programa

/*
 * SUGERENCIAS DE OPTIMIZACIÓN:
 * -    Los divisores solo llegan hasta la mitad del número, ya que no cabe la mitad de un volumen en otro trozo un poco mayor a dicha mitad. (los divisores solo son hasta la mitád del número)        LISTO
 * -    Si la operación de suma de sus divisores se pasó del número, el número no es perfecto. Por lo que se puede comenzar la suma desde los últimos divisores                                         LISTO
 * -    Si el cuociente de la división es un número entero, se obtienen dos divisores, el divisor y el cuociente (resultado como número entero de la división)                                          PENDIENTE
 * -    Los números impares SOLO PUEDEN TENER DIVISORES IMPARES                                                                                                                                         PENDIENTE
 */
using System;
using System.Diagnostics;

namespace NúmerosPerfectos
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong indice;                                       //Número que se intenta saber si es perfecto
            ulong divisores;                                    //acumulador de divisores
            Console.WriteLine("CALCULADORA DE NPUMEROS PERFECTOS. Precione Enter para comenzar a calcular");
            Console.ReadLine();
            Stopwatch tiempo = new Stopwatch();
            tiempo.Start();
            for (indice = 2; indice <= ulong.MaxValue; indice++)//buble casi infino empieza del 2 hasta el máximo de ULong
                {
                divisores = 1;                                  //se asigna 1 al primer divisor
                for (ulong i = indice/2 ; i > 1 ; i--)          //i es la mitad del índice (para ahorrar vueltas) y se recorre del mayor hasta llegar a 2
                {
                    if (indice % i == 0) divisores += i;        //pregunta si el intento de número perfecto es dibicible por el actual índice (partiendo por intento más alto) de ser así se suma a la lista de divisores
                    if (divisores > indice) break;              //si la actual suma de divisores supera al índice (número actual rompiendo la regla de los perfectos) se rompe la vuelta.
                }
                if (divisores == indice)                        //si la suma de divisores da el número, es perfecto
                {
                    Console.WriteLine($"Numero perfecto : {indice}  | Tiempo demorado en minutos: {tiempo.Elapsed.TotalMinutes}");
                }
            }
        }
        public static ulong NumerosPares(ulong indice, ulong divisores)
        {
            return divisores;
        }

        public static ulong NumerosPrimos(ulong indice, ulong divisores)
        {
            return divisores;
        }
    }
}