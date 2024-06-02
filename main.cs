using System;

class Program
{
    
    const double CentimetersPerInch = 2.54;

    static void Main(string[] args)
    {
        
        double inches = 15994; 

        
        double centimeters = inches * CentimetersPerInch;

        
        Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
    }
}