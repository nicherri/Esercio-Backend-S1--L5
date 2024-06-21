// File: Program.cs

using System;
using System.Collections.Generic;

class Program
{
    // Lista per memorizzare tutti i contribuenti inseriti
    static List<Contribuente> contribuenti = new List<Contribuente>();

    // Metodo principale che gestisce il menu e le operazioni dell'applicazione
    static void Main(string[] args)
    {
        while (true)
        {
            // Visualizza il menu
            Console.WriteLine("==================================================");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Inserimento di una nuova dichiarazione di un contribuente");
            Console.WriteLine("2. La lista completa di tutti i contribuenti che sono stati analizzati");
            Console.WriteLine("3. Esci dal programma");
            Console.WriteLine("         ");
            Console.WriteLine("==================================================");
            Console.Write("Scegli un'opzione: ");

            // Legge l'opzione scelta dall'utente
            string scelta = Console.ReadLine();
            switch (scelta)
            {
                case "1":
                    InserisciContribuente(); // Chiama il metodo per inserire un nuovo contribuente
                    break;
                case "2":
                    VisualizzaContribuenti(); // Chiama il metodo per visualizzare tutti i contribuenti
                    break;
                case "3":
                    return; // Esce dal programma
                default:
                    Console.WriteLine("Scelta non valida. Riprova."); // Messaggio di errore per scelta non valida
                    break;
            }
        }
    }

    // Metodo per inserire un nuovo contribuente
    static void InserisciContribuente()
    {
        // Richiede all'utente di inserire i dati del contribuente
        Console.WriteLine("Inserisci i dati del contribuente:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Cognome: ");
        string cognome = Console.ReadLine();
        Console.Write("Data di Nascita (gg/mm/aaaa): ");
        string dataNascita = Console.ReadLine();
        Console.Write("Codice Fiscale: ");
        string codiceFiscale = Console.ReadLine();

        // Richiesta del genere con validazione dell'input
        Genere sesso;
        while (true)
        {
            Console.Write("Sesso (M/F): ");
            string sessoInput = Console.ReadLine().ToUpper();
            if (sessoInput == "M")
            {
                sesso = Genere.Maschio;
                break; // Esce dal ciclo se l'input è valido
            }
            else if (sessoInput == "F")
            {
                sesso = Genere.Femmina;
                break; // Esce dal ciclo se l'input è valido
            }
            else
            {
                Console.WriteLine("Input non valido. Inserisci 'M' per Maschio o 'F' per Femmina."); // Messaggio di errore per input non valido
            }
        }

        Console.Write("Comune di Residenza: ");
        string comuneResidenza = Console.ReadLine();
        Console.Write("Reddito Annuale: ");
        double redditoAnnuale = double.Parse(Console.ReadLine());

        // Crea un nuovo oggetto Contribuente con i dati inseriti
        Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);
        contribuenti.Add(contribuente); // Aggiunge il contribuente alla lista

        // Visualizza il calcolo dell'imposta per il contribuente appena inserito
        Console.WriteLine("==================================================");
        Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:\n");
        Console.WriteLine(contribuente);
        Console.WriteLine("==================================================");
    }

    // Metodo per visualizzare tutti i contribuenti inseriti
    static void VisualizzaContribuenti()
    {
        // Visualizza la lista completa dei contribuenti analizzati
        Console.WriteLine("==================================================");
        Console.WriteLine("Lista completa dei contribuenti analizzati:");
        foreach (var contribuente in contribuenti)
        {
            Console.WriteLine(contribuente); // Visualizza i dettagli di ogni contribuente
            Console.WriteLine("--------------------------------------------------");
        }
        Console.WriteLine("==================================================");
    }
}
