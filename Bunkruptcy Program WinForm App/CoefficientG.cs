using System;
using System.Collections.Generic;
using System.Text;

namespace Bunkruptcy_Program_WinForm_App
{
    public class CoefficientG
    {
        public int GNum { get; set; }
        public double GVal { get; set; }

        public CoefficientG(int gnum, double gval)
        {
            this.GNum = gnum;
            this.GVal = gval;
        }
    }
}
