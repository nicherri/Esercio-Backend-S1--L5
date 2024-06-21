namespace Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    namespace Contest
    {
        internal class Program
        {
            /// <summary>
            /// Stampa tutti i numeri primi da <strong>2</strong> fino al numero specificato nel parametro <strong>upperBound</strong>.
            /// </summary>
            /// <param name="upperBound">Limite superiore dell'intervallo da considerare per l'estrazione dei numeri primi.</param>
            private static void Primes(int upperBound)
            {
                // Lista per memorizzare i numeri primi
                List<int> primes = new List<int>();

                // Array di booleani per tenere traccia dei numeri primi
                bool[] isPrime = new bool[upperBound + 1];
                for (int i = 2; i <= upperBound; i++)
                {
                    isPrime[i] = true;
                }

                // Implementazione del Crivello di Eratostene
                for (int p = 2; p * p <= upperBound; p++)
                {
                    if (isPrime[p])
                    {
                        for (int i = p * p; i <= upperBound; i += p)
                        {
                            isPrime[i] = false;
                        }
                    }
                }

                // Aggiungi i numeri primi alla lista
                for (int i = 2; i <= upperBound; i++)
                {
                    if (isPrime[i])
                    {
                        primes.Add(i);
                    }
                }

                // Stampa tutti i numeri primi trovati
                Console.WriteLine($"Numeri primi fino a {upperBound}:");
                foreach (int prime in primes)
                {
                    Console.Write($"{prime} ");
                }
                Console.WriteLine();
            }

            static void Main(string[] args)
            {
                // Un cronometro
                Stopwatch sw = new Stopwatch();
                // Attiva il cronometro
                sw.Start();
                // Esegue il metodo da misurare
                Primes(10000);
                // Ferma il cronometro
                sw.Stop();
                // Stampa il tempo trascorso
                Console.WriteLine($"Execution time: {sw.ElapsedMilliseconds} ms");
            }
        }
    }
}
