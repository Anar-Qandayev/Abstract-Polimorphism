using Abstract_Polimorfizm.Models;
using System;

namespace Abstract_Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============*Square*================");
            Square square = new Square();
            Console.WriteLine("Enter the side of the square:");
            square.side = Convert.ToInt32(Console.ReadLine());
            square.CalcArea();
            Console.WriteLine("==============*Rectangular*================");
            Rectangular rectangular1 = new Rectangular();
            Console.WriteLine("Enter the width of the rectangular:");
            rectangular1.width= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of the rectangular:");
            rectangular1.length= Convert.ToInt32(Console.ReadLine());
            rectangular1.CalcArea();
        }
    }
}
