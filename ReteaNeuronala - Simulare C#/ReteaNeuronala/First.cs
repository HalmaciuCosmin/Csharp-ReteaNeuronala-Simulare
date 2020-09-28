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
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();

            Functie1_iesire.Items.Add(new Functie("Suma",1));
            Functie1_iesire.Items.Add(new Functie("Produs",2));
            Functie1_iesire.Items.Add(new Functie("Minim",3));
            Functie1_iesire.Items.Add(new Functie("Maxim",4));
            Functie1_iesire.Text = "Suma";
            Functie2_iesire.Items.Add(new Functie("Sigmoidala",1));
            Functie2_iesire.Items.Add(new Functie("TangentaHiperbolica",2));
            Functie2_iesire.Items.Add(new Functie("Treapta",3));
            Functie2_iesire.Items.Add(new Functie("Semn",4));
            Functie2_iesire.Items.Add(new Functie("Rampa",5));
            Functie2_iesire.Text = "Sigmoidala";


            Ini();
        }


        List<double> Valori_G = new List<double>();
        List<double> Valori_P = new List<double>();
        List<string> Func1 = new List<string>();
        List<string> Func2 = new List<string>();
        List<bool> Binar = new List<bool>();
  

        int aux_straturi = 1;

        private void Numeric_Ascunse_ValueChanged(object sender, EventArgs e)
        {
            int straturi = (int)numeric_Strat.Value;
            int count = panel1.Controls.Count;
            bool var;

            if (aux_straturi > straturi)
            {
                var = false;
            }
            else
            {
                var = true;
                aux_straturi = straturi;
            }

            if (var == true)
            {
                int n = count / 7;


                for (int i = n; i < straturi; i++)
                {
                    Label label = new Label();
                    Label g = new Label();
                    NumericUpDown g_value = new NumericUpDown();
                    Label p = new Label();
                    ComboBox f1 = new ComboBox();
                    ComboBox f2 = new ComboBox();
                    NumericUpDown p_value = new NumericUpDown();
                    ComboBox Functie1 = new ComboBox();
                    ComboBox Functie2 = new ComboBox();
                    NumericUpDown valoare = new NumericUpDown();
                    CheckBox c = new CheckBox();

                    label.Font = new Font("Arial", 13);
                    label.Text = "Strat " + (i+1);

                    g.Font = new Font("Arial", 13);
                    g.Text = "g:";
                    g.Width = 15;

                    g_value.Minimum = -100;
                    g_value.Maximum = 100;
                    g_value.DecimalPlaces = 2;
                    g_value.Increment = (decimal)0.01;
                    g_value.Height = 25;
                    g_value.Width = 45;
                    g_value.Value = 1;


                    p.Font = new Font("Arial", 13);
                    p.Text = "p:";
                    p.Width = 15;

                    p_value.Minimum = -100;
                    p_value.Maximum = 100;
                    p_value.DecimalPlaces = 2;
                    p_value.Increment = (decimal)0.01;
                    p_value.Height = 25;
                    p_value.Width = 45;
                    p_value.Value = 0;

                    Functie1.Width = 80;
                    Functie1.Height = 45;
                    Functie1.Items.Add(new Functie("Suma",1));
                    Functie1.Items.Add(new Functie("Produs",2));
                    Functie1.Items.Add(new Functie("Minim",3));
                    Functie1.Items.Add(new Functie("Maxim",4));
                    Functie1.Text = "Suma";

                    Functie2.Width = 80;
                    Functie2.Height = 45;
                    Functie2.Items.Add(new Functie("Sigmoidala",1));
                    Functie2.Items.Add(new Functie("TangentaHiperbolica",2));
                    Functie2.Items.Add(new Functie("Treapta",3));
                    Functie2.Items.Add(new Functie("Semn",4));
                    Functie2.Items.Add(new Functie("Rampa",5));
                    Functie2.Text = "Sigmoidala";

                    valoare.Minimum = 1;
                    valoare.Maximum = 100;
                    valoare.Increment = 1;
                    valoare.Value = 1;
                    valoare.Width = 80;
                    valoare.Height = 45;

                    c.Text = "Binar";

                    count = panel1.Controls.Count;
                   
                    label.Location = new Point(5, count * 7);
                    g.Location = new Point(100, count * 7);
                    g_value.Location = new Point(140, count * 7 + 2);
                    p.Location = new Point(210, count * 7);
                    p_value.Location = new Point(240, count * 7 + 2);
                    Functie1.Location = new Point(290, count * 7 );
                    Functie2.Location = new Point(380, count * 7 );
                    c.Location = new Point(480, count * 7);
                    valoare.Location = new Point(550, count * 7 + 2);


                    panel1.Controls.Add(label);
                    panel1.Controls.Add(g);
                    panel1.Controls.Add(g_value);
                    panel1.Controls.Add(p);
                    panel1.Controls.Add(p_value);
                    panel1.Controls.Add(Functie1);
                    panel1.Controls.Add(Functie2);
                    panel1.Controls.Add(valoare);
                    panel1.Controls.Add(c);

                

                }
            }
            else
            {
                for(int i = aux_straturi; i > straturi; i--)
                {
                    int auxCount = panel1.Controls.Count;
                    panel1.Controls.Remove(panel1.Controls[auxCount - 1]);
                    panel1.Controls.Remove(panel1.Controls[auxCount - 2]);
                    panel1.Controls.Remove(panel1.Controls[auxCount - 3]);
                    panel1.Controls.Remove(panel1.Controls[auxCount - 4]);
                    panel1.Controls.Remove(panel1.Controls[auxCount - 5]);
                    panel1.Controls.Remove(panel1.Controls[auxCount - 6]);
                    panel1.Controls.Remove(panel1.Controls[auxCount - 7]);
                    panel1.Controls.Remove(panel1.Controls[auxCount - 8]);
                    panel1.Controls.Remove(panel1.Controls[auxCount - 9]);

                }

                aux_straturi = straturi;
            }

        }

        private void Ini()
        {

            Label label = new Label();
            Label g = new Label();
            NumericUpDown g_value = new NumericUpDown();
            Label p = new Label();
            ComboBox f1 = new ComboBox();
            ComboBox f2 = new ComboBox();
            NumericUpDown p_value = new NumericUpDown();
            CheckBox c = new CheckBox();

            NumericUpDown valoare = new NumericUpDown();

            label.Font = new Font("Arial", 13);
            label.Text = "Strat 1";

            g.Font = new Font("Arial", 13);
            g.Text = "g:";
            g.Width = 15;

            g_value.Minimum = -100;
            g_value.Maximum = 100;
            g_value.DecimalPlaces = 2;
            g_value.Increment = (decimal)0.01;
            g_value.Height = 25;
            g_value.Width = 45;
            g_value.Value = 1;

            c.Text = "Binar";

            p.Font = new Font("Arial", 13);
            p.Text = "p:";
            p.Width = 15;

            p_value.Minimum = -100;
            p_value.Maximum = 100;
            p_value.DecimalPlaces = 2;
            p_value.Increment = (decimal)0.01;
            p_value.Height = 25;
            p_value.Width = 45;
            p_value.Value = 0;

           f1.Width = 80;
           f1.Height = 45;
           f1.Items.Add(new Functie("Suma",1));
           f1.Items.Add(new Functie("Produs",2));
           f1.Items.Add(new Functie("Minim",3));
           f1.Items.Add(new Functie("Maxim",4));
           f1.Text = "Suma";
           
           f2.Width = 80;
           f2.Height = 45;
           f2.Items.Add(new Functie("Sigmoidala",1));
           f2.Items.Add(new Functie("TangentaHiperbolica",2));
           f2.Items.Add(new Functie("Treapta",3));
           f2.Items.Add(new Functie("Semn",4));
           f2.Items.Add(new Functie("Rampa",5));
           f2.Text = "Sigmoidala"; 

            valoare.Minimum = 1;
            valoare.Maximum = 100;
            valoare.Increment = 1;
            valoare.Value = 1;
            valoare.Width = 80;
            valoare.Height = 45;


            int count = 0;

            label.Location = new Point(5, 0 * 10);
            g.Location = new Point(100, count * 10);
            g_value.Location = new Point(140, count * 10 + 2);
            p.Location = new Point(210, count * 10);
            p_value.Location = new Point(240, count * 10 + 2);
            f1.Location = new Point(290, count * 10 );
            f2.Location = new Point(380, count * 10 );
            c.Location = new Point(480, count);
            valoare.Location = new Point(550, count * 10 + 2);



            panel1.Controls.Add(label);
            panel1.Controls.Add(g);
            panel1.Controls.Add(g_value);
            panel1.Controls.Add(p);
            panel1.Controls.Add(p_value);
            panel1.Controls.Add(f1);
            panel1.Controls.Add(f2);
            panel1.Controls.Add(valoare);
            panel1.Controls.Add(c);

       

        }




        private static Retea form;
        private void Creare_Click(object sender, EventArgs e)
        {
            
            int NrNeuroniIntrare = (int)numeric_intrare.Value;
            int NrNeuroniIesire = (int)numeric_iesire.Value;
            int NrStraturi = (int)numeric_Strat.Value;
            List<int> Valori_Straturi = new List<int>();

            var numericUpDowns = panel1.Controls.OfType<NumericUpDown>();
            int i = 0;

          

            foreach (NumericUpDown nr in numericUpDowns)
            {
                if(i == 2)
                {
                    Valori_Straturi.Add((int)nr.Value);
                    i = -1;
                }
                
                if( i == 1 )
                {
                    Valori_P.Add((double)nr.Value);
                }

                if(i == 0)
                {
                    Valori_G.Add((double)nr.Value);
                }
             
                i++;                
            }


            var comboBox = panel1.Controls.OfType<ComboBox>();
            i = 0;
            foreach(ComboBox cb in comboBox)
            {
                if(i == 0)
                {
                    Func1.Add(cb.Text);
                    i++;
                }
                else
                {
                    Func2.Add(cb.Text);
                    i--;
                }
            }


            var checkBox = panel1.Controls.OfType<CheckBox>();
            foreach(CheckBox c in checkBox)
            {
                if(c.Checked == true)
                {
                    Binar.Add(true);
                }
                else
                {
                    Binar.Add(false);
                }
            }


            Valori_G.Add((double)g_iesire.Value);
            Valori_P.Add((double)p_iesire.Value);
            Func1.Add(Functie1_iesire.Text);
            Func2.Add(Functie2_iesire.Text);
            Binar.Add(checkBox1.Checked);

            this.Hide();
            form = new Retea(NrNeuroniIntrare, NrNeuroniIesire, NrStraturi, Valori_Straturi,Valori_G,Valori_P,Func1,Func2,Binar);
            form.ShowDialog();
            this.Close();
        }

        public static void CALCULARE()
        {
            form.CALCULARE();
        }

    }
}
