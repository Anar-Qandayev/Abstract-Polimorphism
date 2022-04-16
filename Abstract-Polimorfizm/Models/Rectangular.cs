using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Polimorfizm.Models
{
    class Rectangular: Figure
    {
        private int _width;
        private int _length;
        public int width //menfi ola bilmez
        {
           
            get { return _width; }
            set 
            {
                
                if (value<=0)
                {
                    Console.WriteLine("The sides of the rectangle must be greater than 0");
                }
                else _width = value;
                

            }
        } 
        public int length //menfi ola bilmez
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("The sides of the rectangle must be greater than 0");
                }
                else _length = value;
            }
        }
        public override int side { get; set; }
        public Rectangular()
        {

        }
        //public Rectangular(int width, int length)
        //{
        //    this.width = width;
        //    this.length = length;
        //}

        public override void CalcArea()
        {
            Console.WriteLine($"Area of the a rectangular: {width*length}");
        }
        
    }
}
