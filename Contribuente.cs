// File: Contribuente.cs
using System;

public class Contribuente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string DataNascita { get; set; }
    public string CodiceFiscale { get; set; }
    public string Sesso { get; set; }
    public string ComuneResidenza { get; set; }
    public double RedditoAnnuale { get; set; }

    public Contribuente(string nome, string cognome, string dataNascita, string codiceFiscale, string sesso, string comuneResidenza, double redditoAnnuale)
    {
        Nome = nome;
        Cognome = cognome;
        DataNascita = dataNascita;
        CodiceFiscale = codiceFiscale;
        Sesso = sesso;
        ComuneResidenza = comuneResidenza;
        RedditoAnnuale = redditoAnnuale;
    }

    public double CalcolaImposta()
    {
        double reddito = RedditoAnnuale;
        double imposta = 0.0;

        switch (reddito)
        {
            case <= 15000:
                imposta = reddito * 0.23;
                break;
            case <= 28000:
                imposta = 3450 + (reddito - 15000) * 0.27;
                break;
            case <= 55000:
                imposta = 6960 + (reddito - 28000) * 0.38;
                break;
            case <= 75000:
                imposta = 17220 + (reddito - 55000) * 0.41;
                break;
            default:
                imposta = 25420 + (reddito - 75000) * 0.43;
                break;
        }

        return imposta;
    }

    public override string ToString()
    {
        return $"Contribuente: {Nome} {Cognome}, nato il {DataNascita} ({Sesso}), residente in {ComuneResidenza}, codice fiscale: {CodiceFiscale}\nReddito dichiarato: {RedditoAnnuale:F2}\nIMPOSTA DA VERSARE: € {CalcolaImposta():F2}";
    }
}
