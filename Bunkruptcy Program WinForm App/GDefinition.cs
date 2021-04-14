using System;
using System.Collections.Generic;
using System.Text;

namespace Bunkruptcy_Program_WinForm_App
{
    class GDefinition
    {
        public int Num { get; set; }
        public string Definition { get; set; }
        
        public GDefinition(int Num, string Definition)
        {
            this.Num = Num;
            this.Definition = Definition;
        }
    }

   
}
