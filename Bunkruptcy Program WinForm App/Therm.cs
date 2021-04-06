using System;
using System.Collections.Generic;
using System.Text;

namespace Bunkruptcy_Program_WinForm_App
{
    class Therm
    {
        public int X { get; set; }
        public int B { get; set; }
        public double a1 { get; set; }
        public double a2 { get; set; }
        public double a3 { get; set; }
        public double a4 { get; set; }

        public Therm (int X, int B, double a1, double a2, double a3,double a4)
        {
            this.X = X;
            this.B = B;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.a4 = a4;
        }
    }
}
