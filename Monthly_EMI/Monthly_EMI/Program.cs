using System;

namespace Monthly_EMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the total years of tenure: ");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the annual interest rate (in %): ");
            double annualRate = Convert.ToDouble(Console.ReadLine());

            double monthlyRate = annualRate / (12 * 100);

        
            int totalMonths = years * 12;

          
            double emi;

            if (monthlyRate == 0)
            {
                emi = principal / totalMonths;
            }
            else
            {
                double pow = Math.Pow(1 + monthlyRate, totalMonths);
                emi = principal * monthlyRate * pow / (pow - 1);
            }

            Console.WriteLine("\nMonthly EMI is: ₹" + Math.Round(emi, 2));
        }
    }
}
