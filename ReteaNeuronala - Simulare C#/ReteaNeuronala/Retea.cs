using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ReteaNeuronala
{
    public partial class Retea : Form
    {
        public Retea(int intrare, int iesire, int straturi, List<int> Valori,
                     List<double> Valori_G, List<double> Valori_P, List<string> Func1,
                     List<string> Func2,List<bool> Binar)
        {
            InitializeComponent();




            AdaugareNeuroni_Intrare(intrare);
            AdaugareNeuroni_Ascunse(straturi, Valori);
            AdaugareNeuroni_Iesire(iesire);
            Ini(Valori, Valori_P, Valori_G, Func1, Func2,Binar);
        }



        List<List<Neuron>> Lista_de_Neuroni = new List<List<Neuron>>();
        List<Neuron> Lista_Neuroni_iesire = new List<Neuron>();

        List<NumericUpDown> semnale_intrare = new List<NumericUpDown>();
        List<NumericUpDown> semnale_iesire = new List<NumericUpDown>();


        List<CircularButton> intrare = new List<CircularButton>();
        List<CircularButton> iesire = new List<CircularButton>();
        List<List<CircularButton>> Lista_de_Liste = new List<List<CircularButton>>();




        void AdaugareNeuroni_Intrare(int neuroni)
        {
            int y = 17;
            for (int i = 0; i < neuroni; i++)
            {

                CircularButton cb = new CircularButton();
                cb.Height = 51;
                cb.Width = 58;
                cb.FlatStyle = FlatStyle.Flat;
                cb.FlatAppearance.BorderColor = Color.Red;
                cb.FlatAppearance.BorderSize = 0;
                cb.BackColor = Color.Red;
                cb.Location = new Point(100, y);

                NumericUpDown nr = new NumericUpDown();
                nr.Minimum = -100;
                nr.Maximum = 100;
                nr.Increment = (decimal)0.01;
                nr.Value = 0;
                nr.Width = 80;
                nr.Height = 25;
                nr.DecimalPlaces = 2;
                nr.Location = new Point(5, y + 15);
                nr.ValueChanged += new EventHandler(Value_Change);

                panel1.Controls.Add(cb);
                panel1.Controls.Add(nr);
                intrare.Add(cb);
                semnale_intrare.Add(nr);

                y += 71;
            }
        }


        void AdaugareNeuroni_Ascunse(int straturi, List<int> valori)
        {

            for (int i = 0; i < straturi; i++)
            {
                int y = 17;

                List<CircularButton> List = new List<CircularButton>();


                for (int l = 0; l < valori[i]; l++)
                {
                    CircularButton cb = new CircularButton();

                    cb.Height = 51;
                    cb.Width = 58;
                    cb.FlatStyle = FlatStyle.Flat;
                    cb.FlatAppearance.BorderColor = Color.Red;
                    cb.FlatAppearance.BorderSize = 0;
                    cb.BackColor = Color.Red;
                    cb.Click += new EventHandler(OnClick_Ascuns);
                 //   cb.Text = "" + i + "," + l;


                    cb.Location = new Point(240 + (i * 140), y);
                    panel1.Controls.Add(cb);

                    List.Add(cb);

                    y += 71;
                }
                Lista_de_Liste.Add(List);
            }
        }


        void AdaugareNeuroni_Iesire(int neuroni)
        {
            int y = 17;
            for (int i = 0; i < neuroni; i++)
            {

                CircularButton cb = new CircularButton();
                cb.Height = 51;
                cb.Width = 58;
                cb.FlatStyle = FlatStyle.Flat;
                cb.FlatAppearance.BorderColor = Color.Red;
                cb.FlatAppearance.BorderSize = 0;
                cb.BackColor = Color.Red;

                cb.Location = new Point(670, y);
                cb.Click += new EventHandler(OnClick_Iesire);
              //  cb.Text = i.ToString();

                NumericUpDown nr = new NumericUpDown();
                nr.Increment = 0;
                nr.Value = 0;
                nr.Width = 80;
                nr.Height = 25;
                nr.ReadOnly = true;
                nr.DecimalPlaces = 5;
                nr.Location = new Point(740, y + 15);

                panel1.Controls.Add(cb);
                panel1.Controls.Add(nr);
                iesire.Add(cb);
                semnale_iesire.Add(nr);

                y += 71;
            }
        }


        private void Straturi_Click(object sender, EventArgs e)
        {
            this.Hide();
            First form = new First();
            form.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Graphics gr = e.Graphics;


            // STRAT INTRARE

            for (int u = 0; u < intrare.Count; u++)
            {
                List<CircularButton> Listx = Lista_de_Liste[0];

                CircularButton cb1 = intrare[u];
                Point p1 = cb1.Location;

                for (int o = 0; o < Listx.Count; o++)
                {
                    CircularButton cb2 = Listx[o];
                    Point p2 = cb2.Location;

                    gr.DrawLine(pen, p1.X + 55, p1.Y + 23, p2.X, p2.Y + 22);
                }


            }


            // STRAT ASCUNS 

            for (int i = 0; i < Lista_de_Liste.Count - 1; i++)
            {

                for (int j = 0; j < Lista_de_Liste[i].Count; j++)
                {
                    List<CircularButton> List1 = Lista_de_Liste[i];
                    CircularButton cb1 = List1[j];
                    Point p1 = cb1.Location;
                    for (int k = 0; k < Lista_de_Liste[i + 1].Count; k++)
                    {
                        List<CircularButton> List2 = Lista_de_Liste[i + 1];

                        CircularButton cb2 = List2[k];
                        Point p2 = cb2.Location;
                        gr.DrawLine(pen, p1.X + 55, p1.Y + 23, p2.X, p2.Y + 22);
                    }
                }

            }

            // STRAT IESIRE
            List<CircularButton> List = Lista_de_Liste[Lista_de_Liste.Count - 1];

            for (int l = 0; l < List.Count; l++)
            {
                CircularButton cb1 = List[l];
                Point p1 = cb1.Location;
                for (int k = 0; k < iesire.Count; k++)
                {
                    CircularButton cb2 = iesire[k];
                    Point p2 = cb2.Location;

                    gr.DrawLine(pen, p1.X + 55, p1.Y + 23, p2.X, p2.Y + 22);
                }
            }

        }



        private void Ini(List<int> v, List<double> P, List<double> G, List<string> f1, List<string> f2,List<bool> Binar)
        {
            int n = v.Count();

            for (int i = 0; i < n; i++)
            {
                List<Neuron> l = new List<Neuron>();
                for (int k = 0; k < v[i]; k++)
                {
                    if (i == 0)
                    {
                        Neuron form = new Neuron(intrare.Count(), P[0], G[0], f1[0], f2[0],Binar[0]);
                        l.Add(form);
                    }
                    else
                    {
                        Neuron form = new Neuron(v[i - 1], P[i], G[i], f1[i], f2[i],Binar[i]);
                        l.Add(form);
                    }

                }
                Lista_de_Neuroni.Add(l);
            }


            List<Neuron> Neo = new List<Neuron>();
            Neo = Lista_de_Neuroni[Lista_de_Neuroni.Count - 1];
            int nr = Neo.Count;

            for (int i = 0; i < iesire.Count; i++)
            {
                Neuron form = new Neuron(nr, P[P.Count - 1], G[G.Count - 1], f1[f1.Count - 1], f2[f2.Count - 1],Binar[Binar.Count - 1]);
                Lista_Neuroni_iesire.Add(form);
            }

        }


        private void OnClick_Ascuns(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string[] aux = b.Text.Split(',');

            int Id_strat = Int32.Parse(aux[0]);
            int Id_neuron = Int32.Parse(aux[1]);

            List<Neuron> List = Lista_de_Neuroni[Id_strat];

            Neuron Form = List[Id_neuron];
            Form.ShowDialog();
        }


        private void OnClick_Iesire(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int id = Int32.Parse(b.Text);

            Neuron Form = Lista_Neuroni_iesire[id];
            Form.ShowDialog();
        }


        private void Value_Change(object sender, EventArgs e)
        {
            CALCULARE();
        }


        public  void CALCULARE()
        {
            List<double> x = new List<double>();
            for (int i = 0; i < semnale_intrare.Count; i++)
            {
                x.Add((double)semnale_intrare[i].Value);
            }

            for (int i = 0; i < Lista_de_Neuroni.Count; i++)
            {
                List<Neuron> Neu = Lista_de_Neuroni[i];

                for (int l = 0; l < Neu.Count * 2; l++)
                {
                    if (l < Neu.Count)
                    {
                        Neu[l].SetX(x);
                    }

                    if (l == Neu.Count)
                    {
                        x.Clear();
                    }

                    if (l >= Neu.Count)
                    {
                        x.Add(Neu[l - Neu.Count].GetOut());
                    }

                }
            }

            for(int i = 0; i < iesire.Count; i ++)
            {
                Lista_Neuroni_iesire[i].SetX(x);
                semnale_iesire[i].Value = (decimal)Lista_Neuroni_iesire[i].GetOut();
            }


        }


        class CircularButton : Button
        {
            protected override void OnPaint(PaintEventArgs pevent)
            {

                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);

                this.Region = new System.Drawing.Region(path);
                base.OnPaint(pevent);
            }
        }


    }
}



