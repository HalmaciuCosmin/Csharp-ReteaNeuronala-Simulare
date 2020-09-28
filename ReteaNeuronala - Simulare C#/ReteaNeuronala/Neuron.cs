using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReteaNeuronala
{
    public partial class Neuron : Form
    {

        int legaturi;
        double p;
        double g;
        string f1;
        string f2;
        double OUTPUT;
        double gid;
        bool Real;

        List<NumericUpDown> xValue = new List<NumericUpDown>();

        public Neuron(int leg, double p, double g, string f1, string f2,bool Rb)
        {
            InitializeComponent();
            legaturi = leg;
            this.p = p;
            this.g = g;
            this.f1 = f1;
            this.f2 = f2;
            Real = Rb;

            p_label.Text = p.ToString();
            g_label.Text = g.ToString();
            Func1.Text = f1;
            Func2.Text = f2;
            if(Real == true)
            {
                RB.Text = "Binar";
            }
            else
            {
                RB.Text = "Real";
            }
            Ini();
        }


        private void Ini()
        {
            for (int i = 0; i < legaturi; i++)
            {
                Label x = new Label();
                Label w = new Label();
                NumericUpDown xV = new NumericUpDown();
                NumericUpDown wV = new NumericUpDown();
                xV.Minimum = -100;
                wV.Minimum = -100;
                xV.Maximum = 1000;
                wV.Maximum = 1000;
                xV.Increment = 0;
                xV.ReadOnly = true;

                wV.Increment = (decimal)0.01;
                xV.Width = 50;
                wV.Width = 50;
                wV.DecimalPlaces = 2;
                xV.DecimalPlaces = 2;
                x.Text = "X:";
                w.Text = "W:";

                int count = panel1.Controls.Count;


                x.Location = new Point(10, count * 11);
                w.Location = new Point(140, count * 11);
                xV.Location = new Point(30, count * 11);
                wV.Location = new Point(170, count * 11);


                panel1.Controls.Add(wV);
                panel1.Controls.Add(w);
                panel1.Controls.Add(xV);
                panel1.Controls.Add(x);

                xValue.Add(xV);

            }
        }





       
        public void Calculare()
        {
            List<double> List = new List<double>();
            List = getValori();


            if (Func1.Text == "Suma")
            {
                gid = Suma(List);
            }
            else if (Func1.Text == "Produs")
            {
                gid = Produs(List);
            }
            else if (Func1.Text == "Minim")
            {
                gid = Minim(List);
            }
            else if (Func1.Text == "Maxim")
            {
                gid = Maxim(List);
            }

            NGID.Value = (decimal)gid;

            // ---------



            if (Func2.Text == "Sigmoidala")
            {
                if (RB.Text == "Real") { OUTPUT = Functia_Sigmoidala(gid); }

                if(RB.Text == "Binar")
                {
                    if (gid >= 0.5)
                    {
                        OUTPUT = 1;
                    }
                    else
                    {
                        OUTPUT = 0;
                    }
                }
            }
            else if (Func2.Text == "TangentaHiperbolica")
            {

                if (RB.Text == "Real") { OUTPUT = Functia_TangentaHiperbolica(gid); }
                
               
                    if (RB.Text == "Binar")
                    {
                        if (gid >= 0)
                        {
                            OUTPUT = 1;
                        }
                        else
                        {
                            OUTPUT = -1;
                        }
                    }
                
            }

            else if (Func2.Text == "Treapta")
            {

                OUTPUT = Functia_Treapta(gid);
                
            }

            else if (Func2.Text == "Semn")
            {
                OUTPUT = Functia_Semn(gid);

            }
            else if (Func2.Text == "Rampa")
            {
                if (RB.Text == "Real") { OUTPUT = Functia_Rampa(gid); }

                if (RB.Text == "Binar")
                {
                    if (gid >= 0)
                    {
                        OUTPUT = 1;
                    }
                    else
                    {
                        OUTPUT = -1;
                    }
                }


            }

                Output.Value = (decimal)OUTPUT;
           
    }
    

        // ------------------------------------------

        public void SetX(List<double> X)
        {
           for(int i = 0; i < X.Count; i++)
            {
                xValue[i].Value = (decimal)X[i];
            }

            Calculare();
        }


        public double GetOut()
        {
            return OUTPUT;
        }

        // ------------------------------------------

        private double Suma(List<double> lista)
        {
            double S = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                S += lista[i];
            }
            return S;
        }

        private double Produs(List<double> lista)
        {
            double P = 1;
            for (int i = 0; i < lista.Count; i++)
            {
                P *= lista[i];
            }
            return P;
        }

        private double Minim(List<double> lista)
        {
            double min = lista[0];
            for (int i = 0; i < lista.Count; i++)
            {
                if (min > lista[i])
                {
                    min = lista[i];
                }
            }
            return min;
        }

        private double Maxim(List<double> lista)
        {
            double max = lista[0];
            for (int i = 0; i < lista.Count; i++)
            {
                if (max < lista[i])
                {
                    max = lista[i];
                }
            }
            return max;
        }

        private double Functia_Sigmoidala(double gid)  // 0-1
        {
            double prag = (double)p;
            double G = (double)g;

            double aux = -G * (gid - prag);
            return (double)(1 / (1 + Math.Pow(Math.E, aux)));
        }

        private double Functia_TangentaHiperbolica(double gid) // -1  +1
        {
            double prag = (double)p;
            double G = (double)g;

            double auxP = G * (gid - prag);
            double auxN = -G * (gid - prag);

            return (Math.Pow(Math.E, auxP) - Math.Pow(Math.E, auxN)) /
                   (Math.Pow(Math.E, auxP) + Math.Pow(Math.E, auxP));
        }

        private double Functia_Treapta(double gid)  // 1 - 0;
        {
            double prag = (double)p;

            if (gid >= prag)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        private double Functia_Semn(double gid)  // 1  -1
        {
            double prag = (double)p;

            if (gid >= prag)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }


        private double Functia_Rampa(double gid)
        {
            double a = (double)g;

            if (gid >= a)
            {
                return 1;
            }
            else if (gid < a * -1)
            {
                return -1;
            }
            else if (gid > -1 * a && gid < a)
            {
                return gid / a;
            }
            return 0;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Calculare();
            First.CALCULARE();
            Close();

        }

        double x, w;
        public List<double> getValori()
        {
            List<double> lista = new List<double>();
            var numericUpDowns = panel1.Controls.OfType<NumericUpDown>();
            bool var = false;
            foreach (NumericUpDown nr in numericUpDowns)
            {
                if (var == false)
                {
                    x = (double)nr.Value;
                    var = true;
                }
                else
                {
                    w = (double)nr.Value;
                    var = false;
                    lista.Add(w * x);
                }

            }

            return lista;
        }
    }
}
