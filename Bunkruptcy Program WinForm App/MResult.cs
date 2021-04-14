using System;
using System.Collections.Generic;
using System.Text;

namespace Bunkruptcy_Program_WinForm_App
{
    class MResult
    {
        public GDefinition Definition { get; set; }
        public int MNum { get; set; }
        public double GValue { get; set; }

        public MResult(GDefinition gdef, int mNum, double gVal)
        {
            this.Definition = gdef;
            this.MNum = mNum;
            this.GValue = gVal;
        }
        public MResult() { }

        public string getDefinitionByG(int g)
        {
            string def = "";
            if (g == 1) return def = "гриничний ризик банкрутства";
            if (g == 2) return def = "ступінь ризику банкрутства високий";
            if (g == 3) return def = "ступінь ризику банкрутства середній";
            if (g == 4) return def = "низький ступінь ризику банкрутства";
            if (g == 5) return def = "ризик банкрутства незначний";
            return def;
        }

        public List<MResult> getResults (double g)
        {
            GDefinition gdef;
            List <MResult> mresList = new List<MResult>();
            if(g >= 0 && g <= 0.25)
            {
                MResult mres;
                int G = 5;
                string def = getDefinitionByG(G);
                gdef = new GDefinition(G, def);
                double retVal = 0;
                if (g <= 0.15) retVal = 1;
                else retVal = 10 * (0.25 - g);
                mres = new MResult(gdef, G, retVal);
                mresList.Add(mres);
            }
            if(g >= 0.15 && g <= 0.45)
            {
                MResult mres;
                int G = 4;
                string def = getDefinitionByG(G);
                gdef = new GDefinition(G, def);
                double retVal = 0;
                if (g <= 0.25) retVal = 1 - 10 * (0.25 - g);
                if (g <= 0.35) retVal = 1;
                if (g <= 0.45) retVal = 10 * (0.45 - g);
                mres = new MResult(gdef, G, retVal);
                mresList.Add(mres);
            }
            if(g >= 0.35 && g <= 0.65)
            {
                MResult mres;
                int G = 3;
                string def = getDefinitionByG(G);
                gdef = new GDefinition(G, def);
                double retVal = 0;
                if (g <= 0.45) retVal = 1 - 10 * (0.45 - g);
                if (g <= 0.55) retVal = 1;
                if (g <= 0.65) retVal = 10 * (0.65 - g);
                mres = new MResult(gdef, G, retVal);
                mresList.Add(mres);
            }
            if(g >= 0.55 && g <= 0.85)
            {
                MResult mres;
                int G = 3;
                string def = getDefinitionByG(G);
                gdef = new GDefinition(G, def);
                double retVal = 0;
                if (g <= 0.65) retVal = 1 - 10 * (0.65 - g);
                if (g <= 0.75) retVal = 1;
                if (g <= 0.85) retVal = 10 * (0.85 - g);
                mres = new MResult(gdef, G, retVal);
                mresList.Add(mres);
            }
            if (g >= 0.75 && g <= 1)
            {
                MResult mres;
                int G = 5;
                string def = getDefinitionByG(G);
                gdef = new GDefinition(G, def);
                double retVal = 0;
                if (g <= 0.85) retVal = 1 - 10 * (0.85 - g);
                else retVal = 1;
                mres = new MResult(gdef, G, retVal);
                mresList.Add(mres);
            }
            return mresList;

        }
    }
}
