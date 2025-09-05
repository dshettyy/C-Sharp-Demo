using System;
namespace Interface_demo
{

    interface IPayment
    {
        public void MakePayment(double Amount);
    }
    class CreditCard : IPayment
    {
        public void MakePayment(double Amount)
        {
            Console.WriteLine($"The Payment of Rs.{Amount} is succesful through Credit Card");
        }
    }
    class Paypal : IPayment
    {
        public void MakePayment(double Amount)
        { 
            Console.WriteLine($"The Payment of Rs.{Amount} is succesful through Paypal");
        }
    }
    class UPI : IPayment
    {
        public void MakePayment(double Amount)
        {
            Console.WriteLine($"The Payment of Rs.{Amount} is succesful through UPI");
        }
    }

    class Program
    {
        static void Main(String[] Args)
        {
            Console.WriteLine("Choose Payment Methos \n\t1.Credit Card\n\t2.Paypal\n\t3.UPI\nEnter The option:");
            int option = Convert.ToInt16(Console.ReadLine());
            if (option == 1)
            {
                CreditCard c = new CreditCard();
                c.MakePayment(5000);
            }
            else if (option == 2)
            {
                Paypal p = new Paypal();
                p.MakePayment(5000);
            }
            else if (option == 3)
            {
                UPI u = new UPI();
                u.MakePayment(5000);
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}
