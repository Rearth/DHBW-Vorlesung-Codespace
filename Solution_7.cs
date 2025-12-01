using System;

namespace CSharpUebungen
{
    // Für Aufgabe 6: Definition des Enums (Muss innerhalb der Klasse oder des Namespace stehen)
    enum Ampelphase
    {
        Rot,
        Gelb,
        Gruen
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // Aufgabe 1: Einkaufsliste
            // ==========================================
            Console.WriteLine("--- Aufgabe 1: Einkaufsliste ---");

            // 1. Array erstellen (feste Größe 4)
            string[] einkaufsliste = new string[4];

            // 2. Werte zuweisen
            einkaufsliste[0] = "Milch";
            einkaufsliste[1] = "Brot";
            einkaufsliste[2] = "Butter";
            einkaufsliste[3] = "Eier";

            // 3. Element an der dritten Stelle (Index 2) ausgeben
            Console.WriteLine($"Das 3. Element ist: {einkaufsliste[2]}");

            Console.WriteLine(); // Leerzeile für bessere Lesbarkeit

            // ==========================================
            // Aufgabe 2: Lottozahlen
            // ==========================================
            Console.WriteLine("--- Aufgabe 2: Lottozahlen ---");

            // 1. & 2. Array erstellen und direkt initialisieren
            int[] lottozahlen = { 4, 8, 15, 16, 23, 42 };

            // 3. Zweite Zahl (Index 1) auf 9 ändern
            lottozahlen[1] = 9;

            // 4. Erste und letzte Zahl ausgeben
            // Tipp: lottozahlen.Length - 1 gibt immer den letzten Index
            Console.WriteLine($"Erste Zahl: {lottozahlen[0]}");
            Console.WriteLine($"Letzte Zahl: {lottozahlen[lottozahlen.Length - 1]}");

            Console.WriteLine();

            // ==========================================
            // Aufgabe 3: Alle Personen begrüßen
            // ==========================================
            Console.WriteLine("--- Aufgabe 3: Alle Personen begrüßen ---");

            // 1. Array mit Freunden
            string[] freunde = { "Anna", "Bob", "Charlie" };

            // 2. & 3. Foreach-Schleife zur Ausgabe
            foreach (string freund in freunde)
            {
                Console.WriteLine($"Hallo, {freund}!");
            }

            Console.WriteLine();

            // ==========================================
            // Aufgabe 4: Notendurchschnitt berechnen
            // ==========================================
            Console.WriteLine("--- Aufgabe 4: Notendurchschnitt ---");

            // 1. Array mit Noten
            int[] testNoten = { 1, 3, 2, 1, 4 };

            // 2. Variable für die Summe
            double summe = 0;

            // 3. For-Schleife zum Addieren
            for (int i = 0; i < testNoten.Length; i++)
            {
                summe += testNoten[i];
            }

            // 4. Gesamtsumme ausgeben
            Console.WriteLine($"Summe der Noten: {summe}");

            // 5. Bonus: Durchschnitt berechnen
            double durchschnitt = summe / testNoten.Length;
            Console.WriteLine($"Durchschnitt: {durchschnitt}");

            Console.WriteLine();

            // ==========================================
            // Aufgabe 5: Tic-Tac-Toe-Feld (einfach)
            // ==========================================
            Console.WriteLine("--- Aufgabe 5: Tic-Tac-Toe (statisch) ---");

            // 1. 2D-Array erstellen (3 Zeilen, 3 Spalten)
            char[,] spielfeld = new char[3, 3];

            // 2. 'X' in die Mitte (Zeile 1, Spalte 1)
            spielfeld[1, 1] = 'X';

            // 3. 'O' oben links (Zeile 0, Spalte 0)
            spielfeld[0, 0] = 'O';

            // 4. Ausgabe mit verschachtelten Schleifen
            // Hinweis: Leere 'char' Felder werden als unsichtbares Zeichen ausgegeben (\0)
            for (int i = 0; i < 3; i++) // Zeilen
            {
                for (int j = 0; j < 3; j++) // Spalten
                {
                    Console.Write($"[{spielfeld[i, j]}] ");
                }
                Console.WriteLine(); // Neue Zeile nach jeder Reihe
            }

            Console.WriteLine();

            // ==========================================
            // Aufgabe 6: Ampelsteuerung
            // ==========================================
            Console.WriteLine("--- Aufgabe 6: Ampelsteuerung ---");

            // 2. Variable erstellen und Wert zuweisen
            Ampelphase aktuellePhase = Ampelphase.Gruen;

            // 3. Prüfung mit if
            if (aktuellePhase == Ampelphase.Gruen)
            {
                // 4. Ausgabe
                Console.WriteLine("Du darfst gehen!");
            }

            Console.WriteLine();

            // ==========================================
            // Aufgabe 7: Interaktives Tic-Tac-Toe
            // ==========================================
            Console.WriteLine("--- Aufgabe 7: Interaktives Tic-Tac-Toe ---");
            Console.WriteLine("Zum Beenden Strg+C drücken (Endlosschleife)");

            // 1. Spielfeld erstellen
            char[,] spielfeldInteraktiv = new char[3, 3];

            // WICHTIG: Wir füllen das Feld erst mit Leerzeichen, damit es schön aussieht
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    spielfeldInteraktiv[i, j] = ' ';
                }
            }

            // 2. Aktueller Spieler
            char aktuellerSpieler = 'X';

            // 3. Endlosschleife
            while (true)
            {
                Console.WriteLine();    // leerzeile
                Console.WriteLine($"Aktuelles Feld:");
                
                // 4a. Feld ausgeben
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"[{spielfeldInteraktiv[i, j]}]");
                    }
                    Console.WriteLine();
                }

                // 4b. Spieler fragen
                Console.Write($"Spieler {aktuellerSpieler}, gib Zeile und Spalte ein (z.B. 1 1): ");

                // 4c. Eingabe lesen
                string eingabe = Console.ReadLine();

                try
                {
                    // 4d. Eingabe zerlegen (Split am Leerzeichen)
                    string[] teile = eingabe.Split(' ');
                    
                    // Umwandeln in Zahlen und -1 rechnen (Benutzer gibt 1-3 ein, Array braucht 0-2)
                    int zeile = int.Parse(teile[0]) - 1;
                    int spalte = int.Parse(teile[1]) - 1;

                    // 4e. Zeichen setzen
                    // (Optional: Man könnte hier prüfen, ob das Feld schon belegt ist)
                    if (zeile >= 0 && zeile < 3 && spalte >= 0 && spalte < 3)
                    {
                         spielfeldInteraktiv[zeile, spalte] = aktuellerSpieler;

                        // 4f. Spieler wechseln
                        if (aktuellerSpieler == 'X')
                        {
                            aktuellerSpieler = 'O';
                        }
                        else
                        {
                            aktuellerSpieler = 'X';
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Koordinaten! Bitte Zahlen von 1 bis 3 verwenden.");
                    }
                }
                catch
                {
                    Console.WriteLine("Fehler bei der Eingabe. Bitte Format 'Zahl Leertaste Zahl' nutzen (z.B. '2 3').");
                }
            }
        }
    }
}