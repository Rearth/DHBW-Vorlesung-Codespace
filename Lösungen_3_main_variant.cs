/*
 * Übungen zu Methoden in C#
 * ========================
 * 
 * Verwendung:
 * 1. Die Datei enthält 7 separate Lösungen, jede in einer eigenen Klasse
 * 2. Um eine spezifische Lösung zu testen:
 *    - Kopiere den gewünschten Klassenabschnitt in eine neue Datei
 *    - Benenne die Datei entsprechend (z.B. "Aufgabe1.cs" für die erste Aufgabe)
 *    - Nenne die klasse "Program" und stelle sicher dass es die einzige klasse dieser Art ist.
 * 
 * Klassenübersicht:
 * - Aufgabe1: Methode zum Ausgeben des Namens
 * - Aufgabe2: Begrüßungstext-Generator
 * - Aufgabe3: Gerade/Ungerade-Prüfung
 * - Aufgabe4: Werte-Tausch mit ref
 * - Aufgabe5: Kreisberechnungen mit out
 * - Aufgabe6: Überladene Methoden
 * - Aufgabe7: Rekursive Summenberechnung
 */

public class Aufgabe1 {
    static void PrintMyName()
    {
        Console.WriteLine("Max Mustermann");
    }

    public static void Main(string[] args)
    {
        PrintMyName();
    }
}

// === Start of Aufgabe2.cs ===
public class Aufgabe2
{
    static string GetGreeting(string name)
    {
        return $"Hallo, {name}!";
    }

    public static void Main(string[] args)
    {
        string greeting = GetGreeting("Max");
        Console.WriteLine(greeting);
    }
}

// === Start of Aufgabe3.cs ===
public class Aufgabe3
{
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine($"Ist 4 gerade? {IsEven(4)}");
        Console.WriteLine($"Ist 7 gerade? {IsEven(7)}");
    }
}

// === Start of Aufgabe4.cs ===
public class Aufgabe4
{
    static void Swap(ref string a, ref string b)
    {
        string temp = a;
        a = b;
        b = temp;
    }

    public static void Main(string[] args)
    {
        string str1 = "Hallo";
        string str2 = "Welt";
        Console.WriteLine($"Vor Swap: str1 = {str1}, str2 = {str2}");
        Swap(ref str1, ref str2);
        Console.WriteLine($"Nach Swap: str1 = {str1}, str2 = {str2}");
    }
}

// === Start of Aufgabe5.cs ===
public class Aufgabe5
{
    static void GetCircleDetails(double radius, out double circumference, out double area)
    {
        circumference = 2 * Math.PI * radius;
        area = Math.PI * radius * radius;
    }

    public static void Main(string[] args)
    {
        double radius = 5.0;
        GetCircleDetails(radius, out double circumference, out double area);
        Console.WriteLine($"Kreis mit Radius {radius}:");
        Console.WriteLine($"Umfang: {circumference:F2}");
        Console.WriteLine($"Fläche: {area:F2}");
    }
}

// === Start of Aufgabe6.cs ===
public class Aufgabe6
{
    static void DisplayValue(int value)
    {
        Console.WriteLine($"Ganze Zahl: {value}");
    }

    static void DisplayValue(string value)
    {
        Console.WriteLine($"Text: {value}");
    }

    static void DisplayValue(bool value)
    {
        Console.WriteLine($"Wahrheitswert: {value}");
    }

    public static void Main(string[] args)
    {
        DisplayValue(42);
        DisplayValue("Hallo Welt");
        DisplayValue(true);
    }
}

// === Start of Aufgabe7.cs ===
public class Aufgabe7
{
    static int SumUpTo(int n)
    {
        if (n == 1) return 1;
        return n + SumUpTo(n - 1);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine($"Summe von 1 bis 4: {SumUpTo(4)}");
    }
}
