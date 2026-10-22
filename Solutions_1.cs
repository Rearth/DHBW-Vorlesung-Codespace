using System;

// Aufgabe 1: Programm starten und verändern
Console.WriteLine("Hallo zur ersten Informatik-Vorlesung!");
Console.WriteLine("Wir bearbeiten jetzt alle Übungen nacheinander.");

// Aufgabe 2: Passende Datentypen wählen
{
    int teilnehmerzahl = 24;
    string raum = "A204";
    char gruppenkennzeichen = 'B';
    float temperatur = 21.5F;
    bool veranstaltungAktiv = true;

    Console.WriteLine(teilnehmerzahl);
    Console.WriteLine(raum);
    Console.WriteLine(gruppenkennzeichen);
    Console.WriteLine(temperatur);
    Console.WriteLine(veranstaltungAktiv);

    teilnehmerzahl = 25;
    Console.WriteLine(teilnehmerzahl);
}

// Aufgabe 3: Gesamtpreis aktualisieren
{
    int anzahl = 3;
    double einzelpreis = 2.50;
    double gesamtpreis = anzahl * einzelpreis;
    Console.WriteLine(gesamtpreis);

    anzahl = anzahl + 2;
    Console.WriteLine(gesamtpreis);

    gesamtpreis = anzahl * einzelpreis;
    Console.WriteLine(gesamtpreis);
}

// Aufgabe 4: Werte kopieren und ändern
{
    int punkte = 12;
    int kopie = punkte;
    punkte = punkte + 5;
    Console.WriteLine(punkte);
    Console.WriteLine(kopie);

    kopie = punkte;
    Console.WriteLine(punkte);
    Console.WriteLine(kopie);
}

// Aufgabe 5: Artikel auf Kartons verteilen
{
    int artikel = 23;
    int proKarton = 5;
    int volleKartons = artikel / proKarton;
    int uebrigeArtikel = artikel % proKarton;
    Console.WriteLine(volleKartons);
    Console.WriteLine(uebrigeArtikel);

    artikel = 25;
    volleKartons = artikel / proKarton;
    uebrigeArtikel = artikel % proKarton;
    Console.WriteLine(volleKartons);
    Console.WriteLine(uebrigeArtikel);
}

// Aufgabe 6: Alter in Tagen berechnen
{
    Console.Write("Aufgabe 6 – Alter in Jahren: ");
    int alter = Convert.ToInt32(Console.ReadLine());
    int alterInTagen = alter * 365;
    Console.WriteLine($"Ungefähres Alter in Tagen: {alterInTagen}");

    if (alter < 18)
    {
        Console.WriteLine("Minderjährig");
    }
    else
    {
        Console.WriteLine("Volljährig");
    }
}

// Aufgabe 7: Gerade oder ungerade?
{
    Console.Write("Aufgabe 7 – Ganze Zahl: ");
    int zahl = Convert.ToInt32(Console.ReadLine());

    if (zahl % 2 == 0)
    {
        Console.WriteLine("Gerade");
    }
    else
    {
        Console.WriteLine("Ungerade");
    }
}

// Aufgabe 8: Zutritt prüfen
{
    int alter = 18;
    bool hatTicket = true;
    bool stehtAufGaesteliste = false;

    if (alter >= 18 && (hatTicket || stehtAufGaesteliste))
    {
        Console.WriteLine("Zutritt erlaubt");
    }
    else
    {
        Console.WriteLine("Kein Zutritt");
    }

    if (!hatTicket)
    {
        Console.WriteLine("Ticket fehlt.");
    }
    else
    {
        Console.WriteLine("Ticket vorhanden.");
    }
}

// Aufgabe 9: Währungsrechner
{
    double wechselkurs = 1.08;
    Console.Write("Aufgabe 9 – Euro-Betrag: ");
    double euro = Convert.ToDouble(Console.ReadLine());
    double dollar = euro * wechselkurs;
    Console.WriteLine($"{euro:0.00} Euro entsprechen {dollar:0.00} US-Dollar.");
}

// Aufgabe 10: Ticketpreis ermitteln
{
    Console.Write("Aufgabe 10 – Alter für den Ticketpreis: ");
    int alter = Convert.ToInt32(Console.ReadLine());

    if (alter < 6)
    {
        Console.WriteLine("Eintritt frei");
    }
    else if (alter < 18)
    {
        Console.WriteLine("Ticketpreis: 5 Euro");
    }
    else if (alter < 65)
    {
        Console.WriteLine("Ticketpreis: 10 Euro");
    }
    else
    {
        Console.WriteLine("Ticketpreis: 7 Euro");
    }
}

// Aufgabe 11: Schaltjahr-Rechner
{
    Console.Write("Aufgabe 11 – Positive Jahreszahl: ");
    int jahr = Convert.ToInt32(Console.ReadLine());

    if ((jahr % 4 == 0 && jahr % 100 != 0) || jahr % 400 == 0)
    {
        Console.WriteLine($"{jahr} ist ein Schaltjahr.");
    }
    else
    {
        Console.WriteLine($"{jahr} ist kein Schaltjahr.");
    }
}

// Aufgabe 12: Login-Simulation
{
    string korrekterName = "admin";
    string korrektesPasswort = "uebung";

    Console.Write("Aufgabe 12 – Benutzername: ");
    string name = Console.ReadLine()!;
    Console.Write("Passwort: ");
    string passwort = Console.ReadLine()!;

    if (name == korrekterName)
    {
        if (passwort == korrektesPasswort)
        {
            Console.WriteLine("Login erfolgreich!");
        }
        else
        {
            Console.WriteLine("Falsches Passwort.");
        }
    }
    else
    {
        Console.WriteLine("Benutzername nicht gefunden.");
    }
}
