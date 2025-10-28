class Sample
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

    static void Main(string[] args)
    {
        Console.WriteLine("Test der überladenen DisplayValue Methoden:");
        Console.WriteLine("------------------------------------------");
        
        DisplayValue(42);
        DisplayValue("Hallo Welt");
        DisplayValue(true);
    }
}
