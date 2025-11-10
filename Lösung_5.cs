//================================================================
// Aufgabe 1: Längen-Validierung
//================================================================
Console.WriteLine("--- Aufgabe 1: Längen-Validierung ---");
Console.Write("Bitte geben Sie eine 5-stellige Postleitzahl ein: ");
string plzEingabe = Console.ReadLine();

if (plzEingabe.Length == 5)
{
    Console.WriteLine("Gültige Länge.");
}
else
{
    Console.WriteLine("Ungültige Länge. Die Eingabe muss genau 5 Zeichen lang sein.");
}



//================================================================
// Aufgabe 2: Vokale zählen
//================================================================
Console.WriteLine("--- Aufgabe 2: Vokale zählen ---");
Console.Write("Bitte geben Sie einen Text ein: ");
string textFuerVokale = Console.ReadLine();
int vokalZaehler = 0;

// Konvertiere den Text in Kleinbuchstaben, um nicht separat auf 'A', 'E', 'I'... prüfen zu müssen.
foreach (char zeichen in textFuerVokale.ToLower()) 
{
    if (zeichen == 'a') 
    {
        vokalZaehler++;
    }
    if (zeichen == 'e') 
    {
        vokalZaehler++;
    }
    if (zeichen == 'i') 
    {
        vokalZaehler++;
    }
    if (zeichen == 'o') 
    {
        vokalZaehler++;
    }
    if (zeichen == 'u') 
    {
        vokalZaehler++;
    }
}
Console.WriteLine($"Der Text enthält {vokalZaehler} Vokale.");



//================================================================
// Aufgabe 3: Palindrom-Prüfung
//================================================================
Console.WriteLine("--- Aufgabe 3: Palindrom-Prüfung ---");
Console.Write("Bitte geben Sie ein Wort ein: ");
string wort = Console.ReadLine();
wort = wort.ToLower(); // Groß-/Kleinschreibung ignorieren
bool istPalindrom = true;

// Die Schleife läuft nur bis zur Mitte des Wortes.
for (int i = 0; i < wort.Length / 2; i++)
{
    // Vergleiche das Zeichen von vorne (i) mit dem Zeichen von hinten (wort.Length - 1 - i).
    if (wort[i] != wort[wort.Length - 1 - i])
    {
        istPalindrom = false;
        break; // Sobald ein ungleiches Paar gefunden wird, kann die Prüfung beendet werden.
    }
}

if (istPalindrom)
{
    Console.WriteLine($"'{wort}' ist ein Palindrom.");
}
else
{
    Console.WriteLine($"'{wort}' ist kein Palindrom.");
}



//================================================================
// Aufgabe 4: Text umkehren
//================================================================
Console.WriteLine("--- Aufgabe 4: Text umkehren ---");
Console.Write("Bitte geben Sie einen Text ein: ");
string textZumUmkehren = Console.ReadLine();
string umgekehrt = "";

foreach (char zeichen in textZumUmkehren)
{
    // Füge das aktuelle Zeichen *vor* den bisherigen Ergebnisstring.
    umgekehrt = zeichen + umgekehrt;
}

Console.WriteLine($"Umgekehrter Text: {umgekehrt}");



//================================================================
// Aufgabe 5: Eingabe normalisieren
//================================================================
Console.WriteLine("--- Aufgabe 5: Eingabe normalisieren ---");
Console.Write("Bitte antworten Sie mit 'Ja' oder 'Nein': ");
string antwortEingabe = Console.ReadLine();

// Normalisieren: Trim() entfernt führende/nachfolgende Leerzeichen, ToLower() wandelt in Kleinbuchstaben.
string normalisiert = antwortEingabe.Trim().ToLower();

if (normalisiert == "ja")
{
    Console.WriteLine("Sie haben zugestimmt.");
}
else if (normalisiert == "nein")
{
    Console.WriteLine("Sie haben abgelehnt.");
}
else
{
    Console.WriteLine("Ungültige Eingabe.");
}



//================================================================
// Aufgabe 6: Domain extrahieren
//================================================================
Console.WriteLine("--- Aufgabe 6: Domain extrahieren ---");
Console.Write("Bitte geben Sie eine E-Mail-Adresse ein: ");
string email = Console.ReadLine();
int atPosition = email.IndexOf('@');

// Prüfe, ob ein '@' gefunden wurde und es nicht das letzte Zeichen ist.
if (atPosition >= 0 && atPosition < email.Length - 1)
{
    // Extrahiere den Teilstring, der einen Index *nach* dem '@' beginnt.
    string domain = email.Substring(atPosition + 1);
    Console.WriteLine($"Der Domain-Name ist: {domain}");
}
else
{
    Console.WriteLine("Ungültige E-Mail-Adresse.");
}



//================================================================
// Aufgabe 7: Text zensieren
//================================================================
Console.WriteLine("--- Aufgabe 7: Text zensieren ---");
string entry = "Das ist ein Test, der ein Test ist.";
Console.WriteLine($"Originalsatz: {entry}");
Console.Write("Welches Wort soll zensiert werden? ");
string zuZensieren = Console.ReadLine();

// Replace ersetzt alle Vorkommen des gesuchten Wortes.
string zensiert = entry.Replace(zuZensieren, "****");
Console.WriteLine($"Zensierter Satz: {zensiert}");



//================================================================
// Aufgabe 8: Wortzähler
//================================================================
Console.WriteLine("--- Aufgabe 8: Wortzähler ---");
Console.Write("Bitte geben Sie einen Satz ein: ");
string satz = Console.ReadLine().Trim(); // Wichtig: Leerräume am Anfang/Ende entfernen

if (satz.Length <= 0)
{
    Console.WriteLine("Anzahl der Wörter: 0");
}
else
{
    int wortZaehler = 1; // Beginne mit 1, da Trim() sicherstellt, dass der Satz mit einem Wort beginnt.
    
    // Iteriere durch den Satz, um die Wort-Trenner (Leerzeichen) zu finden.
    for (int i = 0; i < satz.Length - 1; i++)
    {
        // Erhöhe den Zähler nur, wenn das aktuelle Zeichen ein Leerzeichen ist
        // UND das darauffolgende Zeichen KEIN Leerzeichen ist.
        // Dies verhindert, dass mehrere Leerzeichen den Zähler mehrfach erhöhen.
        if (satz[i] == ' ' && satz[i + 1] != ' ')
        {
            wortZaehler++;
        }
    }
    Console.WriteLine($"Anzahl der Wörter: {wortZaehler}");
}



//================================================================
// Aufgabe 9: Passwortanalyse
//================================================================
Console.WriteLine("--- Aufgabe 9: Passwortanalyse ---");
Console.Write("Bitte geben Sie ein Passwort ein: ");
string passwort = Console.ReadLine();

bool hatMindestlaenge = passwort.Length >= 8;
bool hatZiffer = false;
bool hatGrossbuchstaben = false;

foreach (char zeichen in passwort)
{
    if (char.IsDigit(zeichen))
    {
        hatZiffer = true;
    }
    if (char.IsUpper(zeichen))
    {
        hatGrossbuchstaben = true;
    }
}

Console.WriteLine("\nPasswort-Analyse:");
Console.WriteLine("- Mindestens 8 Zeichen: " + hatMindestlaenge);
Console.WriteLine("- Enthält mindestens eine Ziffer: " + hatZiffer);
Console.WriteLine("- Enthält mindestens einen Großbuchstaben: " + hatGrossbuchstaben);

if (hatMindestlaenge && hatZiffer && hatGrossbuchstaben)
{
    Console.WriteLine("-> Das Passwort ist gültig.");
}
else
{
    Console.WriteLine("-> Das Passwort ist ungültig.");
}
