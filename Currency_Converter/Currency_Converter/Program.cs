using System;

namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount in INR: ");
            double inrAmount = Convert.ToDouble(Console.ReadLine());

           
            double usdRate = 0.012;   
            double eurRate = 0.011;   
            double gbpRate = 0.0095; 

            double usd = inrAmount * usdRate;
            double eur = inrAmount * eurRate;
            double gbp = inrAmount * gbpRate;

            Console.WriteLine($"\n{inrAmount} INR = {usd:F2} USD");
            Console.WriteLine($"{inrAmount} INR = {eur:F2} EUR");
            Console.WriteLine($"{inrAmount} INR = {gbp:F2} GBP");
        }
    }
}
