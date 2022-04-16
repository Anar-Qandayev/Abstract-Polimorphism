using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Polimorfizm.Models
{
    class Square : Figure
    {
        private int _side;
        public override int side 
        {
            get { return _side; }
            set
            {

                if (value <= 0)
                {
                    Console.WriteLine("The sides of the square must be greater than 0");
                }
                else _side = value;


            }
        }

        public override void CalcArea()
        {
            Console.WriteLine($"Area of the a square: {side*side}");
        }
    }
}
