
// Import namespaces
using Namespaces.Cars.Asian;
using Namespaces.Cars.American;
using Namespaces.Cars.European;

// Alias namespaces - shorten the namespace and be distinct
using AmericanJeep = Namespaces.Cars.American.Jeep;
using AsianJeep = Namespaces.Cars.Asian.Jeep;

class Program
{
    static void Main(string[] args)
    {
        
        // calling static field from a class
        Console.WriteLine($"{Toyota.companyName} : {Toyota.companyMessage}");
        
        
        var asianJeep = new AsianJeep();
        var americanJeep = new AmericanJeep();
    }
}