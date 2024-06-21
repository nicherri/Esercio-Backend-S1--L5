// File: Contribuente.cs
using System;

// Definizione della classe Contribuente
public class Contribuente
{
    // Proprietà della classe Contribuente
    public string Nome { get; set; } // Nome del contribuente
    public string Cognome { get; set; } // Cognome del contribuente
    public string DataNascita { get; set; } // Data di nascita del contribuente
    public string CodiceFiscale { get; set; } // Codice fiscale del contribuente
    public Genere Sesso { get; set; } // Genere del contribuente, utilizza l'enumerazione Genere
    public string ComuneResidenza { get; set; } // Comune di residenza del contribuente
    public double RedditoAnnuale { get; set; } // Reddito annuale del contribuente

    // Costruttore della classe Contribuente per inizializzare tutte le proprietà
    public Contribuente(string nome, string cognome, string dataNascita, string codiceFiscale, Genere sesso, string comuneResidenza, double redditoAnnuale)
    {
        Nome = nome;
        Cognome = cognome;
        DataNascita = dataNascita;
        CodiceFiscale = codiceFiscale;
        Sesso = sesso;
        ComuneResidenza = comuneResidenza;
        RedditoAnnuale = redditoAnnuale;
    }

    // Metodo per calcolare l'imposta in base al reddito annuale
    public double CalcolaImposta()
    {
        double reddito = RedditoAnnuale; // Assegna il reddito annuale alla variabile locale
        double imposta = 0.0; // Inizializza l'imposta a 0

        // Calcolo dell'imposta secondo gli scaglioni di reddito e le relative aliquote
        if (reddito <= 15000)
        {
            imposta = reddito * 0.23; // Aliquota del 23% per redditi fino a 15.000
        }
        else if (reddito <= 28000)
        {
            imposta = 3450 + (reddito - 15000) * 0.27; // Aliquota del 27% per redditi da 15.001 a 28.000
        }
        else if (reddito <= 55000)
        {
            imposta = 6960 + (reddito - 28000) * 0.38; // Aliquota del 38% per redditi da 28.001 a 55.000
        }
        else if (reddito <= 75000)
        {
            imposta = 17220 + (reddito - 55000) * 0.41; // Aliquota del 41% per redditi da 55.001 a 75.000
        }
        else
        {
            imposta = 25420 + (reddito - 75000) * 0.43; // Aliquota del 43% per redditi oltre 75.001
        }

        return imposta; // Restituisce l'imposta calcolata
    }

    // Override del metodo ToString per restituire una stringa rappresentativa del contribuente
    public override string ToString()
    {
        // Restituisce una stringa formattata con tutti i dettagli del contribuente e l'imposta calcolata
        return $"Contribuente: {Nome} {Cognome}, nato il {DataNascita} ({Sesso}), residente in {ComuneResidenza}, codice fiscale: {CodiceFiscale}, Reddito dichiarato: {RedditoAnnuale:F2}, IMPOSTA DA VERSARE: € {CalcolaImposta():F2}";
    }
}
