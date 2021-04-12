using System;
using System.Collections.Generic;
using System.Text;

namespace Bunkruptcy_Program_WinForm_App
{
    class IndicatorM
    {
        public Therm M1 { get; set; }
        public Therm M2 { get; set; }

        public IndicatorM(Therm M1, Therm M2)
        {
            this.M1 = M1;
            this.M2 = M2;
        }
    }
}
