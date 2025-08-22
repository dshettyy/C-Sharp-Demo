using System;

class Age
{
    private int age ;

    public void Takeage()
    {
        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());
    }
        public void Showage()
    {
            Console.WriteLine("Age is " + age);
    }
}

class myclass
{
    static void Main(string[] args)
    {
        Age a=new Age();

        a.Takeage();
        a.Showage();
        
    }
}