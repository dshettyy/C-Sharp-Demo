using System;

namespace Multiple_Devices
{
    interface ICamera
    {
        void Capture();
    }

    interface IPrinter
    {
        void Print();
    }

    class Computer : ICamera, IPrinter
    {
        public void Capture()
        {
            Console.WriteLine("Camera captures photo");
        }

        public void Print()
        {
            Console.WriteLine("Printer prints");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer();

            myComputer.Capture(); 
            myComputer.Print();   
        }
    }
}
