// Aufgabe 1: Name ausgeben
void PrintMyName()
{
    Console.WriteLine("Max Mustermann");
}
// Test Aufgabe 1
Console.WriteLine("--- Aufgabe 1 ---");
PrintMyName();

// Aufgabe 2: Persönliche Begrüßung
string GetGreeting(string name)
{
    return $"Hallo, {name}!";
}
// Test Aufgabe 2
Console.WriteLine("\n--- Aufgabe 2 ---");
string greeting = GetGreeting("Max");
Console.WriteLine(greeting);

// Aufgabe 3: Gerade oder Ungerade
bool IsEven(int number)
{
    return number % 2 == 0;
}
// Test Aufgabe 3
Console.WriteLine("\n--- Aufgabe 3 ---");
Console.WriteLine($"Ist 4 gerade? {IsEven(4)}");
Console.WriteLine($"Ist 7 gerade? {IsEven(7)}");

// Aufgabe 4: Werte tauschen mit ref
void Swap(ref string a, ref string b)
{
    string temp = a;
    a = b;
    b = temp;
}
// Test Aufgabe 4
Console.WriteLine("\n--- Aufgabe 4 ---");
string str1 = "Hallo";
string str2 = "Welt";
Console.WriteLine($"Vor Swap: str1 = {str1}, str2 = {str2}");
Swap(ref str1, ref str2);
Console.WriteLine($"Nach Swap: str1 = {str1}, str2 = {str2}");

// Aufgabe 5: Mehrere Werte zurückgeben mit out
void GetCircleDetails(double radius, out double circumference, out double area)
{
    circumference = 2 * Math.PI * radius;
    area = Math.PI * radius * radius;
}
// Test Aufgabe 5
Console.WriteLine("\n--- Aufgabe 5 ---");
double radius = 5.0;
GetCircleDetails(radius, out double circumference, out double area);
Console.WriteLine($"Kreis mit Radius {radius}:");
Console.WriteLine($"Umfang: {circumference:F2}");
Console.WriteLine($"Fläche: {area:F2}");

// Aufgabe 6
// Hinweis: Methodenüberladung in C# funktioniert nur mit der "klassichen" main methode, nicht mit top level statemens wie hier genutzt. Deshalb befindet sich diese Lösung in einer separaten Datei "Lösung_3_6".cs

// Aufgabe 7: Rekursive Summe
int SumUpTo(int n)
{
    if (n == 1) return 1;  // Basisfall
    return n + SumUpTo(n - 1);  // Rekursiver Schritt
}
// Test Aufgabe 7
Console.WriteLine("\n--- Aufgabe 7 ---");
Console.WriteLine($"Summe von 1 bis 4: {SumUpTo(4)}");
