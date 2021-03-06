using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bunkruptcy_Program_WinForm_App
{
    public partial class Result : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Result()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Grey800,
                MaterialSkin.Primary.DeepOrange300,
                MaterialSkin.Primary.DeepOrange400,
                MaterialSkin.Accent.DeepOrange700,
                MaterialSkin.TextShade.WHITE
                );

            Calculation();
        }
        private double getMValue(double val, Therm t)
        {
            double mval = -1.0;
            if (val < t.a1)
            {
                mval = 0;
            }
            if (val >= t.a1 && val <= t.a2)
            {
                mval = (val - t.a1) / (t.a2 - t.a1);
            }
            if (val >= t.a2 && val <= t.a3)
            {
                mval = 1.0;
            }
            if (val >= t.a3 && val <= t.a4)
            {
                mval = (val - t.a4) / (t.a3 - t.a4);
            }
            if (val >= t.a4)
            {
                mval = 0.0;
            }
            return mval;
        }

        private double getSumOfList(List<IndicatorM> list)
        {
            double sum = 0;
            foreach(var item in list)
            {
            }
            return sum;
        }

        public void Calculation() {

            // Step I

            List<Therm> knowledgeBase = new List<Therm>();
            DataTable dt = Main.dt.Copy();
            DataTable dtII = new DataTable();
            dtII.Columns.Add("Значення показника", typeof(string));
            dtII.Columns.Add("Квартал І", typeof(string));
            dtII.Columns.Add("Квартал ІІ", typeof(string));
            dtII.Columns.Add("Квартал ІІІ", typeof(string));
            dtII.Columns.Add("Квартал ІV", typeof(string));

            dtII.Rows.Add("X1", "-", "-", "-", "-");
            dtII.Rows.Add("X2", "-", "-", "-", "-");
            dtII.Rows.Add("X3", "-", "-", "-", "-");
            dtII.Rows.Add("X4", "-", "-", "-", "-");
            dtII.Rows.Add("X5", "-", "-", "-", "-");
            dtII.Rows.Add("X6", "-", "-", "-", "-");

            stepIIDataGV.DataSource = dtII;
            stepIIDataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            int rowsCount = dt.Rows.Count;
            int columnsCount = dt.Columns.Count;
            knowledgeBase.Add(new Therm(1, 1, 0, 0, 0.1, 0.2));
            knowledgeBase.Add(new Therm(1, 2, 0.1, 0.2, 0.25, 0.3));
            knowledgeBase.Add(new Therm(1, 3, 0.25, 0.3, 0.45, 0.5));
            knowledgeBase.Add(new Therm(1, 4, 0.45, 0.5, 0.6, 0.7));
            knowledgeBase.Add(new Therm(1, 5, 0.6, 0.7, 1, 1));

            knowledgeBase.Add(new Therm(2, 1, -1, -1, 0.005, 0));
            knowledgeBase.Add(new Therm(2, 2, -0.005, 0, 0.09, 0.11));
            knowledgeBase.Add(new Therm(2, 3, 0.09, 0.11, 0.3, 0.35));
            knowledgeBase.Add(new Therm(2, 4, 0.3, 0.35, 0.45, 0.5));
            knowledgeBase.Add(new Therm(2, 5, 0.45, 0.5, 1, 1));

            knowledgeBase.Add(new Therm(3, 1, 0, 0, 0.5, 0.6));
            knowledgeBase.Add(new Therm(3, 2, 0.5, 0.6, 0.7, 0.8));
            knowledgeBase.Add(new Therm(3, 3, 0.7, 0.8, 0.9, 1));
            knowledgeBase.Add(new Therm(3, 4, 0.9, 1, 1.3, 1.5));
            knowledgeBase.Add(new Therm(3, 5, 1.3, 1.5, 100, 100));

            knowledgeBase.Add(new Therm(4, 1, 0, 0, 0.01, 0.03));
            knowledgeBase.Add(new Therm(4, 2, 0.01, 0.03, 0.08, 0.1));
            knowledgeBase.Add(new Therm(4, 3, 0.08, 0.1, 0.3, 0.35));
            knowledgeBase.Add(new Therm(4, 4, 0.3, 0.35, 0.5, 0.6));
            knowledgeBase.Add(new Therm(4, 5, 0.5, 0.6, 100, 100));

            knowledgeBase.Add(new Therm(5, 1, 0, 0, 0.12, 0.14));
            knowledgeBase.Add(new Therm(5, 2, 0.12, 0.14, 0.18, 0.2));
            knowledgeBase.Add(new Therm(5, 3, 0.18, 0.2, 0.3, 0.4));
            knowledgeBase.Add(new Therm(5, 4, 0.3, 0.4, 0.5, 0.8));
            knowledgeBase.Add(new Therm(5, 5, 0.5, 0.8, 100, 100));

            knowledgeBase.Add(new Therm(6, 1, Double.NegativeInfinity, Double.NegativeInfinity, 0, 0));
            knowledgeBase.Add(new Therm(6, 2, 0, 0, 0.006, 0.01));
            knowledgeBase.Add(new Therm(6, 3, 0.006, 0.01, 0.06, 0.1));
            knowledgeBase.Add(new Therm(6, 4, 0.06, 0.1, 0.225, 0.4));
            knowledgeBase.Add(new Therm(6, 5, 0.225, 0.4, 100, 100));            

            List<IndicatorM> im = new List<IndicatorM>();
            for (int j = 0; j < rowsCount; j++)
            {            
                for (int i = 1; i < columnsCount; i++)
                {
                    Therm t1 = null;
                    Therm t2 = null;

                    double? m1val = null;
                    double? m2val = null;
                    var X = j + 1;
                    var item = Convert.ToDouble(dt.Rows[j][i]);
                    foreach(var kn in knowledgeBase)
                    {                       
                       
                        if(kn.X == X && item > kn.a1 && item < kn.a4)
                        {
                            if (t1 == null)
                            {
                                t1 = new Therm(kn.X, kn.B, kn.a1, kn.a2, kn.a3, kn.a4);
                                m1val = getMValue(item, t1);
                            }
                            else
                            {
                                t2 = new Therm(kn.X, kn.B, kn.a1, kn.a2, kn.a3, kn.a4);
                                m2val = getMValue(item, t2);
                            }
                        }
                        
                    }
                    im.Add(new IndicatorM(X, i, t1, t2, m1val, m2val));
                    string? m1 = $"M{t1.X}{t1.B} = {Math.Round((double)m1val, 2)}; ";
                    string? m2 = "";
                    if (t2 != null)
                    {
                        m2 = $"M{t2.X}{t2.B} = {Math.Round((double)m2val, 2)}";
                    }

                    stepIIDataGV[i, j].Value = m1 + m2;

                }

            }

            //Step II

            DataTable dtIII = Main.dt.Copy();
            stepIIIDataGV.DataSource = dtIII;

            List<CoefficientG> g = new List<CoefficientG>();
            g.Add(new CoefficientG(1, 0.125));
            g.Add(new CoefficientG(2, 0.3));
            g.Add(new CoefficientG(3, 0.5));
            g.Add(new CoefficientG(4, 0.7));
            g.Add(new CoefficientG(5, 0.875));

            List<double> gResult = new List<double>();
            for (int i = 1; i < columnsCount; i++)
            {
                double GijSum = 0;
                for (int j = 0; j < rowsCount; j++)
                {
                    var item = stepIIIDataGV[i, j].Value;
                    //List<IndicatorM> localM = new List<IndicatorM>();
                    double? Gij = 0;
                    foreach (var v in im)
                    {
                        if (v.M1.B == j + 1 && v.B == i)
                            Gij += v.m1Value;
                        if (v.M2 != null)
                        {
                            if (v.M2.B == i && v.B == j+1)
                                Gij += v.m1Value;
                        }
                    }
                    if (Gij != 0)
                    {
                        Gij /= 6;
                        foreach (var itm in g)
                        {
                            if (itm.GNum == (j + 1)) Gij *= itm.GVal;
                        }
                    }
                    GijSum += (double)Gij;
                    
                    stepIIIDataGV[i, j].Value = Math.Round((double)Gij, 4);
                }
                gResult.Add(GijSum);
            }
            //Dictionary<int, List<MResult>> results = new Dictionary<int, List<MResult>>();
            List<List<MResult>> results = new List<List<MResult>>();
            int istep = 1;
            foreach (var gres in gResult)
            {                
                MResult m = new MResult();
                List<MResult> res = m.getResults(gres);
                results.Add(res);
                istep++;
            }
            string output = "";
            resultLabel.Text = "Результати обчислення :";
            int step = 1;
            foreach (var r in results)
            {
                output += $"\n Стан підприємства за {step} квартал: G{r[0].MNum}(M{r[0].MNum} = {r[0].GValue}) - {r[0].Definition.Definition}";
                if(r.Count > 1)
                {
                    output += $" або G{r[1].MNum}(M{r[1].MNum} = {r[1].GValue}) - {r[0].Definition.Definition}";
                }
                step++;
            }
            resultMultiLineTextBox.Text = output;
        }



        /*
        Therm B11 = new Therm(0, 0, 0.1, 0.2);
        Therm B12 = new Therm(0.1, 0.2, 0.25, 0.3);
        Therm B13 = new Therm(0.25, 0.3, 0.45, 0.5);
        Therm B14 = new Therm(0.45, 0.5, 0.6, 0.7);
        Therm B15 = new Therm(0.6, 0.7, 1, 1);

        Therm B21 = new Therm(-1, -1, 0.005, 0);
        Therm B22 = new Therm(-0.005, 0, 0.09, 0.11);
        Therm B23 = new Therm(0.09, 0.11, 0.3, 0.35);
        Therm B24 = new Therm(0.3, 0.35, 0.45, 0.5);
        Therm B25 = new Therm(0.45, 0.5, 1, 1);

        Therm B31 = new Therm(0, 0, 0.5, 0.6);
        Therm B32 = new Therm(0.5, 0.6, 0.7, 0.8);
        Therm B33 = new Therm(0.7, 0.8, 0.9, 1);
        Therm B34 = new Therm(0.9, 1, 1.3, 1.5);
        Therm B35 = new Therm(1.3, 1.5, 100, 100);

        Therm B41 = new Therm(0, 0, 0.01, 0.03);
        Therm B42 = new Therm(0.01, 0.03, 0.08, 0.1);
        Therm B43 = new Therm(0.08, 0.1, 0.3, 0.35);
        Therm B44 = new Therm(0.3, 0.35, 0.5, 0.6);
        Therm B45 = new Therm(0.5, 0.6, 100, 100);

        Therm B51 = new Therm(0, 0, 0.12, 0.14);
        Therm B52 = new Therm(0.12, 0.14, 0.18, 0.2);
        Therm B53 = new Therm(0.18, 0.2, 0.3, 0.4);
        Therm B54 = new Therm(0.3, 0.4, 0.5, 0.8);
        Therm B55 = new Therm(0.5, 0.8, 100, 100);

        Therm B61 = new Therm(Double.NegativeInfinity, Double.NegativeInfinity, 0, 0);
        Therm B62 = new Therm(0, 0, 0.006, 0.01);
        Therm B63 = new Therm(0.006, 0.01, 0.06, 0.1);
        Therm B64 = new Therm(0.06, 0.1, 0.225, 0.4);
        Therm B65 = new Therm(0.225, 0.4, 100, 100); 
        */
    }
}
