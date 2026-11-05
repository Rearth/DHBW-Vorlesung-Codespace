using System;

// Aufgabe 1: Eigener Name ausgeben
// Plan: Die Methode enthält den Namen; ein Aufruf gibt ihn einmal aus.
// Erwartete Ausgabe: Max Mustermann
// Der Name ist ein Beispiel und kann durch den eigenen vollständigen Namen ersetzt werden.
void PrintMyName()
{
    Console.WriteLine("Max Mustermann");
}

PrintMyName();

// Aufgabe 2: Mehrere Bausteine aufrufen
// Plan: Erst den Header aufrufen, dann den Inhalt ausgeben, zuletzt den Footer aufrufen.
// Erwartete Ausgabe:
// Willkommen!
// Programminhalt
// Bis bald!
void PrintHeader()
{
    Console.WriteLine("Willkommen!");
}

void PrintFooter()
{
    Console.WriteLine("Bis bald!");
}

PrintHeader();
Console.WriteLine("Programminhalt");
PrintFooter();

// Aufgabe 3: Eine Anleitung mehrfach verwenden
// Plan: Dieselbe Methode vor und nach der Ausgabe von "Pause" aufrufen.
// Erwartete Ausgabe:
// Informationstechnologie I
// Eigene Methoden
// Pause
// Informationstechnologie I
// Eigene Methoden
void PrintCourseInfo()
{
    Console.WriteLine("Informationstechnologie I");
    Console.WriteLine("Eigene Methoden");
}

PrintCourseInfo();
Console.WriteLine("Pause");
PrintCourseInfo();

// Zu Aufgaben 1 bis 3: Eine Methodendefinition führt den Körper noch nicht aus.
// Erst beim Aufruf wird er ausgeführt. Danach geht es hinter dem jeweiligen
// Aufruf weiter. Jeder neue Aufruf führt den Methodenkörper erneut aus.

// Aufgabe 4: Begrüßung zurückgeben
string GetGreeting(string name)
{
    return "Hallo, " + name + "!";
}

string greeting = GetGreeting("Max Mustermann");
Console.WriteLine(greeting); // Hallo, Max Mustermann!

string testGreeting = GetGreeting("Mia");
Console.WriteLine(testGreeting); // Hallo, Mia!

// Aufgabe 5: Gerade oder ungerade?
bool IsEven(int number)
{
    return number % 2 == 0;
}

// Zunächst die Prüfung direkt mit einer Ausgabe im Hauptprogramm verbinden.
bool even = IsEven(8);
if (even)
{
    Console.WriteLine("Gerade");
}
else
{
    Console.WriteLine("Ungerade");
}

// Anschließend die Textbestimmung in eine eigene Methode auslagern.
string GetParityText(bool even)
{
    if (even)
    {
        return "Gerade";
    }

    return "Ungerade";
}

foreach (int parityNumber in new int[] { 8, 0, 7 })
{
    string parityText = GetParityText(IsEven(parityNumber));
    Console.WriteLine(parityText); // Gerade, Gerade, Ungerade (je eine Zeile)
}

// Aufgabe 6: Werte und Aufrufe nachvollziehen
int number = 3;
int first = DoubleValue(number); // Nach Aufruf 1: number = 3, first = 6.
DoubleValue(number);             // Nach Aufruf 2: number = 3, first = 6.
number = DoubleValue(number);    // Nach Aufruf 3: number = 6, first = 6.

int DoubleValue(int value)
{
    value = value * 2;
    return value;
}

Console.WriteLine($"number = {number}"); // number = 6
Console.WriteLine($"first = {first}");   // first = 6

// Der zweite Aufruf (Zeile 3 des Aufgabenbeispiels) berechnet 6, verwirft aber
// die Rückgabe. Der normale int-Parameter erhält eine Kopie des übergebenen Werts.
// Änderungen an value ändern number nicht. Erst die Zuweisung beim dritten
// Aufruf ersetzt number durch den Rückgabewert.
// value ist nur innerhalb von DoubleValue gültig; jeder Aufruf erhält einen
// eigenen Parameter. first bleibt nach seiner ersten Zuweisung unverändert.

// Aufgabe 7: Texte mit ref tauschen
// Eingaben: Zwei Textvariablen. Verarbeitung: Austausch über eine Hilfsvariable.
// Ausgabe: Die Variablen vor und nach dem Tausch anzeigen.
void Swap(ref string left, ref string right)
{
    string temporary = left;
    left = right;
    right = temporary;
}

string leftText = "links";
string rightText = "rechts";
Console.WriteLine($"Vorher: {leftText}, {rightText}");
Swap(ref leftText, ref rightText);
Console.WriteLine($"Nachher: {leftText}, {rightText}");
// ref lässt die Parameter direkt auf die Variablen des Hauptprogramms zugreifen.
// Die Zuweisungen in Swap ändern daher leftText und rightText.

// Aufgabe 8: Kreisumfang und Kreisfläche
// Eingabe: Radius. Verarbeitung: Beide Formeln berechnen.
// Ausgabe: Zwei über out zugewiesene Ergebnisse im Hauptprogramm ausgeben.
void GetCircleDetails(double radius, out double circumference, out double area)
{
    circumference = 2 * Math.PI * radius;
    area = Math.PI * radius * radius;
}

foreach (double radius in new double[] { 1, 0 })
{
    GetCircleDetails(radius, out double circumference, out double area);
    Console.WriteLine($"Radius {radius}: Umfang = {circumference:F3}, Fläche = {area:F3}");
}
// Radius 1: Umfang etwa 6,283, Fläche etwa 3,142.
// Radius 0: Beide Ergebnisse 0,000. Das Dezimalzeichen hängt von der Kultur ab.
// out verlangt, dass die Methode beide Ergebnisse vor ihrer Rückkehr zuweist.

// Aufgabe 9: Text prüfen und eine Zahl ausgeben
// Eingaben: Gültige und ungültige Zahlentexte. Verarbeitung: TryParse prüfen.
// Ausgabe: Bei Erfolg die Zahl über PrintValue, sonst die Fehlermeldung.
void PrintValue(in int value)
{
    Console.WriteLine(value);
}

foreach (string input in new string[] { "42", "0", "Hallo" })
{
    bool success = int.TryParse(input, out int parsedNumber);
    if (success)
    {
        PrintValue(in parsedNumber);
    }
    else
    {
        Console.WriteLine("Keine gültige ganze Zahl.");
    }
}
// Erwartete Ausgabe: 42, 0, Keine gültige ganze Zahl. (je eine Zeile)
// TryParse liefert den Erfolg als bool und weist die Zahl über out zu.
// Bei einem Fehlschlag ist parsedNumber 0; deshalb wird success geprüft.
// in übergibt eine schreibgeschützte Referenz: value = 6; wäre nicht erlaubt.
// Ein normaler int-Parameter wäre eine veränderbare Kopie; eine Zuweisung würde
// nur diese Kopie ändern. Mit ref würde sie die Variable im Hauptprogramm ändern.

// Aufgabe 10: Rekursive Summe berechnen und prüfen
// Eingaben: n >= 1, hier 1, 3 und 4. Verarbeitung: Rekursiv summieren und prüfen.
// Ausgabe: Die gespeicherte Summe und ihren mit IsEven bestimmten Paritätstext.
int SumUpTo(int n)
{
    if (n == 1)
    {
        return 1;
    }

    return n + SumUpTo(n - 1);
}

foreach (int n in new int[] { 1, 3, 4 })
{
    int sum = SumUpTo(n);
    string sumParityText = GetParityText(IsEven(sum));
    Console.WriteLine($"SumUpTo({n}) = {sum}, {sumParityText}");
}
// Erwartete Ausgabe:
// SumUpTo(1) = 1, Ungerade
// SumUpTo(3) = 6, Gerade
// SumUpTo(4) = 10, Gerade
//
// Aufrufe für SumUpTo(3):
// SumUpTo(3) wartet auf 3 + SumUpTo(2).
//   SumUpTo(2) wartet auf 2 + SumUpTo(1).
//     SumUpTo(1) gibt 1 zurück. <-- Basisfall
//   SumUpTo(2) gibt 2 + 1 = 3 zurück.
// SumUpTo(3) gibt 3 + 3 = 6 ins Hauptprogramm zurück.
// Dort wird 6 in sum gespeichert, IsEven liefert true und GetParityText "Gerade".
