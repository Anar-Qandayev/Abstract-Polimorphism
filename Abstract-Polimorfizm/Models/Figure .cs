using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Polimorfizm.Models
{
    abstract class Figure
    {
        public abstract int side  { get; set; } //menfi ola bilmez
        public abstract void CalcArea();
       // public abstract void Add();

    }
}
