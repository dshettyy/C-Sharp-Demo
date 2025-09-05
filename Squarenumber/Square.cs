using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squarenumber
{
    internal class Square
    {
        int num;
        int square;
        public Square()
        {
            num = 2;

        }
        public Square(int num_)
        { 
            this.num = num_;
        }
        public void cal() {
            square = num * num;
}
        public void display() {

            Console.WriteLine("the Square of "+ num+" is " + square);
            }
    }
}
