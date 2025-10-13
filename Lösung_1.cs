// Aufgabe 1: Vor- und Nachname kombinieren
Console.WriteLine("--- Aufgabe 1: Vor- und Nachname kombinieren ---");
Console.Write("Bitte geben Sie Ihren Vornamen ein: ");
string vorname = Console.ReadLine();
Console.Write("Bitte geben Sie Ihren Nachnamen ein: ");
string nachname = Console.ReadLine();
string vollerName = $"{vorname} {nachname}";
Console.WriteLine($"Ihr voller Name lautet: {vollerName}");
Console.WriteLine();

// Aufgabe 2: Alter in Tagen berechnen
Console.WriteLine("--- Aufgabe 2: Alter in Tagen berechnen ---");
Console.Write("Bitte geben Sie Ihr Alter in Jahren ein: ");
string alterInJahrenString = Console.ReadLine();
int alterInJahren = Convert.ToInt32(alterInJahrenString);
int alterInTagen = alterInJahren * 365;
Console.WriteLine($"Du bist ungefähr {alterInTagen} Tage alt.");
Console.WriteLine();

// Aufgabe 3: Der Währungsrechner (Einfach)
Console.WriteLine("--- Aufgabe 3: Der Währungsrechner (Einfach) ---");
const double EuroToDollar = 1.08;
Console.Write("Bitte geben Sie einen Euro-Betrag ein: ");
string euroBetragString = Console.ReadLine();
double euroBetrag = Convert.ToDouble(euroBetragString);
double dollarBetrag = euroBetrag * EuroToDollar;
Console.WriteLine($"{euroBetrag} Euro entsprechen {dollarBetrag} US-Dollar.");
Console.WriteLine();

// Aufgabe 4: Gerade oder Ungerade?
Console.WriteLine("--- Aufgabe 4: Gerade oder Ungerade? ---");
Console.Write("Bitte geben Sie eine ganze Zahl ein: ");
string zahlString = Console.ReadLine();
int zahl = Convert.ToInt32(zahlString);
if (zahl % 2 == 0)
{
    Console.WriteLine($"Die Zahl {zahl} ist gerade.");
}
else
{
    Console.WriteLine($"Die Zahl {zahl} ist ungerade.");
}
Console.WriteLine();

// Aufgabe 5: Ticketpreis-Ermittlung
Console.WriteLine("--- Aufgabe 5: Ticketpreis-Ermittlung ---");
Console.Write("Bitte geben Sie Ihr Alter ein: ");
string alterFuerTicketString = Console.ReadLine();
int alterFuerTicket = Convert.ToInt32(alterFuerTicketString);
if (alterFuerTicket < 6)
{
    Console.WriteLine("Der Eintritt ist frei.");
}
else if (alterFuerTicket >= 6 && alterFuerTicket <= 17)
{
    Console.WriteLine("Der Ticketpreis beträgt 5€.");
}
else if (alterFuerTicket >= 18 && alterFuerTicket <= 64)
{
    Console.WriteLine("Der Ticketpreis beträgt 10€.");
}
else // alter >= 65
{
    Console.WriteLine("Der Ticketpreis beträgt 7€.");
}
Console.WriteLine();

// Aufgabe 6: Einfacher Taschenrechner
Console.WriteLine("--- Aufgabe 6: Einfacher Taschenrechner ---");
Console.Write("Geben Sie die erste Zahl ein: ");
string ersteZahlString = Console.ReadLine();
Console.Write("Geben Sie den Operator ein (+, -, *, /): ");
string operatorZeichen = Console.ReadLine();
Console.Write("Geben Sie die zweite Zahl ein: ");
string zweiteZahlString = Console.ReadLine();

double ersteZahl = Convert.ToDouble(ersteZahlString);
double zweiteZahl = Convert.ToDouble(zweiteZahlString);
double ergebnis = 0;
bool gueltigerOperator = true;
switch (operatorZeichen)
{
    case "+":
        ergebnis = ersteZahl + zweiteZahl;
        break;
    case "-":
        ergebnis = ersteZahl - zweiteZahl;
        break;
    case "*":
        ergebnis = ersteZahl * zweiteZahl;
        break;
    case "/":
        ergebnis = ersteZahl / zweiteZahl;
        break;
    default:
        gueltigerOperator = false;
        Console.WriteLine("Fehler: Ungültiger Operator.");
        break;
}
if (gueltigerOperator)
{
    Console.WriteLine($"Das Ergebnis ist: {ergebnis}");
}
Console.WriteLine();

// Aufgabe 7: Noten in Text umwandeln
Console.WriteLine("--- Aufgabe 7: Noten in Text umwandeln ---");
Console.Write("Bitte geben Sie eine Schulnote (1-6) ein: ");
string noteString = Console.ReadLine();
int note = Convert.ToInt32(noteString);
string bewertung;
switch (note)
{
    case 1:
        bewertung = "Sehr gut";
        break;
    case 2:
        bewertung = "Gut";
        break;
    case 3:
        bewertung = "Befriedigend";
        break;
    case 4:
        bewertung = "Ausreichend";
        break;
    case 5:
        bewertung = "Mangelhaft";
        break;
    case 6:
        bewertung = "Ungenügend";
        break;
    default:
        bewertung = "Ungültige Note";
        break;
}
Console.WriteLine(bewertung);
Console.WriteLine();

// Aufgabe 8: Schaltjahr-Rechner
Console.WriteLine("--- Aufgabe 8: Schaltjahr-Rechner ---");
Console.Write("Bitte geben Sie eine Jahreszahl ein: ");
string jahrString = Console.ReadLine();
int jahr = Convert.ToInt32(jahrString);
if ((jahr % 4 == 0 && jahr % 100 != 0) || (jahr % 400 == 0))
{
    Console.WriteLine($"{jahr} ist ein Schaltjahr.");
}
else
{
    Console.WriteLine($"{jahr} ist kein Schaltjahr.");
}
Console.WriteLine();

// Aufgabe 9: Taschenrechner mit Fehlerabfrage
Console.WriteLine("--- Aufgabe 9: Taschenrechner mit Fehlerabfrage ---");
Console.Write("Geben Sie die erste Zahl ein: ");
string ersteZahlRechnerString = Console.ReadLine();
Console.Write("Geben Sie den Operator ein (+, -, *, /): ");
string operatorRechnerZeichen = Console.ReadLine();
Console.Write("Geben Sie die zweite Zahl ein: ");
string zweiteZahlRechnerString = Console.ReadLine();

double ersteZahlRechner = Convert.ToDouble(ersteZahlRechnerString);
double zweiteZahlRechner = Convert.ToDouble(zweiteZahlRechnerString);
double ergebnisRechner = 0;
bool gueltigeOperation = true;
switch (operatorRechnerZeichen)
{
    case "+":
        ergebnisRechner = ersteZahlRechner + zweiteZahlRechner;
        break;
    case "-":
        ergebnisRechner = ersteZahlRechner - zweiteZahlRechner;
        break;
    case "*":
        ergebnisRechner = ersteZahlRechner * zweiteZahlRechner;
        break;
    case "/":
        if (zweiteZahlRechner == 0)
        {
            Console.WriteLine("Fehler: Division durch Null ist nicht erlaubt!");
            gueltigeOperation = false;
        }
        else
        {
            ergebnisRechner = ersteZahlRechner / zweiteZahlRechner;
        }
        break;
    default:
        Console.WriteLine("Fehler: Ungültiger Operator.");
        gueltigeOperation = false;
        break;
}
if (gueltigeOperation)
{
    Console.WriteLine($"Das Ergebnis ist: {ergebnisRechner}");
}
Console.WriteLine();

// Aufgabe 10: Einfache Login-Simulation
Console.WriteLine("--- Aufgabe 10: Einfache Login-Simulation ---");
const string correctUser = "admin";
const string correctPass = "12345";

Console.Write("Benutzername: ");
string enteredUser = Console.ReadLine();

if (enteredUser == correctUser)
{
    Console.Write("Passwort: ");
    string enteredPass = Console.ReadLine();
    if (enteredPass == correctPass)
    {
        Console.WriteLine("Login erfolgreich! Willkommen.");
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
Console.WriteLine();
