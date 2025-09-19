namespace Expection_Handeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tException Handeling");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Enter number to be divided :");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter number to divide :");
            int b = Convert.ToInt32(Console.ReadLine());
            int result;
            try
            {
                result = a / b;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException
            )
            {
                Console.WriteLine("Number cannot be divided by zero");
            }

            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
               
                Console.WriteLine("Division Process completed");
            }

        }
    }
}
