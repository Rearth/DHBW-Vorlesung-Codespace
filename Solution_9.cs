using System.Collections.Generic;

// ==========================================
// Aufgabe 1: Die To-Do Liste (List)
// ==========================================
Console.WriteLine("--- Aufgabe 1: To-Do Liste ---");

List<string> aufgaben = new List<string>();

// Hinzufügen
aufgaben.Add("Lernen");
aufgaben.Add("Einkaufen");
aufgaben.Add("Schlafen");

// Entfernen
aufgaben.Remove("Schlafen");

// Einfügen am Anfang
aufgaben.Insert(0, "Programmieren");

// Ausgabe
foreach (string aufgabe in aufgaben)
{
    Console.WriteLine("- " + aufgabe);
}
Console.WriteLine(); // Leerzeile


// ==========================================
// Aufgabe 2: Der Notenschnitt (List & Mathe)
// ==========================================
Console.WriteLine("--- Aufgabe 2: Notenschnitt ---");

List<double> noten = new List<double>();
noten.Add(1.3);
noten.Add(2.7);
noten.Add(1.0);
noten.Add(4.0);

double summe = 0;

foreach (double note in noten)
{
    summe += note;
}

double durchschnitt = summe / noten.Count;
Console.WriteLine($"Durchschnittsnote: {durchschnitt}");

Console.WriteLine();


// ==========================================
// Aufgabe 3: Das Login-System (Dictionary)
// ==========================================
Console.WriteLine("--- Aufgabe 3: Login-System ---");

Dictionary<string, string> userDaten = new Dictionary<string, string>();

userDaten.Add("admin", "1234");
userDaten.Add("gast", "0000");

string eingabeUser = "admin";

if (userDaten.ContainsKey(eingabeUser))
{
    Console.WriteLine($"Passwort für {eingabeUser}: {userDaten[eingabeUser]}");
}
else
{
    Console.WriteLine("User unbekannt");
}
Console.WriteLine();


// ==========================================
// Aufgabe 4: Die Preisliste (Dictionary Update)
// ==========================================
Console.WriteLine("--- Aufgabe 4: Preisliste ---");

Dictionary<string, double> preise = new Dictionary<string, double>();

preise.Add("Apfel", 0.99);
preise.Add("Brot", 2.50);
preise.Add("Kaffee", 4.00);

// Zugriff auf Wert
double brotPreis = preise["Brot"];
Console.WriteLine($"Der Preis von Brot ist: {brotPreis} Euro");

// Wert überschreiben (Preisänderung)
preise["Kaffee"] = 4.50;

// Kontrolle
Console.WriteLine("Aktuelle Preise:");
foreach (var produkt in preise)
{
    Console.WriteLine($"{produkt.Key}: {produkt.Value} Euro");
}
Console.WriteLine();


// ==========================================
// Aufgabe 5: Der E-Mail Filter (HashSet)
// ==========================================
Console.WriteLine("--- Aufgabe 5: E-Mail Filter ---");

HashSet<string> emails = new HashSet<string>();

emails.Add("a@test.de");
emails.Add("b@test.de");
emails.Add("a@test.de"); // Duplikat, wird ignoriert

Console.WriteLine($"Anzahl der E-Mails: {emails.Count}");
// Erklärung: HashSet erlaubt keine Duplikate.
Console.WriteLine();


// ==========================================
// Aufgabe 6: Gemeinsame Interessen (Intersect)
// ==========================================
Console.WriteLine("--- Aufgabe 6: Gemeinsamkeiten ---");

HashSet<string> gruppe1 = new HashSet<string> { "Sport", "Musik", "Reisen" };
HashSet<string> gruppe2 = new HashSet<string> { "Musik", "Lesen", "Sport" };

// Schnittmenge bilden (modifiziert gruppe1 so, dass nur noch Gemeinsamkeiten bleiben)
gruppe1.IntersectWith(gruppe2);

Console.WriteLine("Gemeinsame Interessen:");
foreach (string interesse in gruppe1)
{
    Console.WriteLine(interesse);
}
Console.WriteLine();


// ==========================================
// Aufgabe 7: Der Drucker (Queue - FIFO)
// ==========================================
Console.WriteLine("--- Aufgabe 7: Drucker Warteschlange ---");

Queue<string> druckWarteschlange = new Queue<string>();

druckWarteschlange.Enqueue("Dokument1.pdf");
druckWarteschlange.Enqueue("Dokument2.pdf");

// Peek: Nur gucken, nicht entfernen
string naechstesDokument = druckWarteschlange.Peek();
Console.WriteLine($"Als nächstes dran: {naechstesDokument}");

// Dequeue: Entfernen und verarbeiten
string druckeDokument = druckWarteschlange.Dequeue();
Console.WriteLine($"Drucke: {druckeDokument}");
Console.WriteLine();


// ==========================================
// Aufgabe 8: Wort umdrehen (Stack - LIFO)
// ==========================================
Console.WriteLine("--- Aufgabe 8: Wort umdrehen ---");

Stack<char> buchstabenStack = new Stack<char>();
string wort = "HALLO";

// 1. Auf den Stack legen (Push)
foreach (char zeichen in wort)
{
    buchstabenStack.Push(zeichen);
}

Console.Write("Rückwärts: ");

// 2. Vom Stack holen (Pop)
while (buchstabenStack.Count > 0)
{
    char c = buchstabenStack.Pop();
    Console.Write(c);
}

Console.WriteLine(); // Zeilenumbruch am Ende
Console.WriteLine("\n--- Fertig ---");