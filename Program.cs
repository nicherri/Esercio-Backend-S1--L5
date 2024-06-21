// File: Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static List<Contribuente> contribuenti = new List<Contribuente>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Inserimento di una nuova dichiarazione di un contribuente");
            Console.WriteLine("2. La lista completa di tutti i contribuenti che sono stati analizzati");
            Console.WriteLine("3. Esci dal programma");
            Console.WriteLine("         ");
            Console.WriteLine("==================================================");
            Console.Write("Scegli un'opzione: ");

            string scelta = Console.ReadLine();
            switch (scelta)
            {
                case "1":
                    InserisciContribuente();
                    break;
                case "2":
                    VisualizzaContribuenti();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }
        }
    }

    static void InserisciContribuente()
    {
        Console.WriteLine("Inserisci i dati del contribuente:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Cognome: ");
        string cognome = Console.ReadLine();
        Console.Write("Data di Nascita (gg/mm/aaaa): ");
        string dataNascita = Console.ReadLine();
        Console.Write("Codice Fiscale: ");
        string codiceFiscale = Console.ReadLine();
        Console.Write("Sesso (M/F): ");
        string sesso = Console.ReadLine();
        Console.Write("Comune di Residenza: ");
        string comuneResidenza = Console.ReadLine();
        Console.Write("Reddito Annuale: ");
        double redditoAnnuale = double.Parse(Console.ReadLine());

        Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);
        contribuenti.Add(contribuente);

        Console.WriteLine("==================================================");
        Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:\n");
        Console.WriteLine(contribuente);
        Console.WriteLine("==================================================");
    }

    static void VisualizzaContribuenti()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("Lista completa dei contribuenti analizzati:");
        foreach (var contribuente in contribuenti)
        {
            Console.WriteLine(contribuente);
            Console.WriteLine("--------------------------------------------------");
        }
        Console.WriteLine("==================================================");
    }
}
