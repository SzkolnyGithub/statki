using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace statkiBadowski4c
{
    public partial class Form1 : Form
    {
        private class statek
        {
            public int tiles { get; set; }
            public int amount { get; set; }
            public statek(int t, int a)
            {
                tiles = t;
                amount = a;
            }
        }
        statek duzy = new statek(4, 1);
        statek sredni = new statek(3, 2);
        statek maly = new statek(2, 3);
        statek bMaly = new statek(1, 4);
        private static System.Timers.Timer timer;
        PictureBox[] squaresG = new PictureBox[100];
        PictureBox[] squaresK = new PictureBox[100];
        bool phase1Action = false;
        plansza Gracz = new plansza();
        plansza Komputer = new plansza();
        private void SetTimer()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += TimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private class plansza
        {
            private int iloscStatkow;
            private int iloscPol;
            private string rodzajPola;
            public plansza()
            {
                iloscStatkow = 10;
                iloscPol = 100;
            }
            public int getPola()
            {
                return iloscPol;
            }
            public int getStatki()
            {
                return iloscStatkow;
            }
            public void setStatki(int ilosc)
            {
                iloscStatkow = ilosc;
            }
            public string getRpola()
            {
                return rodzajPola;
            }
            public void setRpola(string rodzaj)
            {
                rodzajPola = rodzaj;
            }
        }
        private void generatePlayer()
        {
            int x = 0, y = 0, count = 0;
            for(int i = 0; i < Gracz.getPola(); i++)
            {
                squaresG[i] = new PictureBox();
                squaresG[i].Width = 50;
                squaresG[i].Height = 50;
                squaresG[i].Click += new EventHandler(klik);
                squaresG[i].BorderStyle = BorderStyle.FixedSingle;
                squaresG[i].SizeMode = PictureBoxSizeMode.StretchImage;
                squaresG[i].Location = new Point(x, y);
                squaresG[i].Enabled = true;
                squaresG[i].Tag = "pusteGracz";
                squaresG[i].BackColor = Color.LightBlue;
                gracz.Controls.Add(squaresG[i]);
                x += 50;
                count++;
                if(count == 10)
                {
                    x = 0;
                    y += 50;
                    count = 0;
                }
            }
        }
        private void generateComputer()
        {
            int x = 0, y = 0, count = 0;
            for (int i = 0; i < Komputer.getPola(); i++)
            {
                squaresK[i] = new PictureBox();
                squaresK[i].Width = 50;
                squaresK[i].Height = 50;
                squaresK[i].Click += new EventHandler(ruchKomputer);
                squaresK[i].BorderStyle = BorderStyle.FixedSingle;
                squaresK[i].SizeMode = PictureBoxSizeMode.StretchImage;
                squaresK[i].Location = new Point(x, y);
                squaresK[i].Enabled = true;
                squaresK[i].Tag = "pusteKomputer";
                squaresK[i].BackColor = Color.LightBlue;
                komputer.Controls.Add(squaresK[i]);
                x += 50;
                count++;
                if (count == 10)
                {
                    x = 0;
                    y += 50;
                    count = 0;
                }
            }
        }
        int count = 4;
        private void phase1()
        {
            phase1Action = true;
            /*int ilosc4 = 1;
            int ilosc3 = 2;
            int ilosc2 = 3;
            int ilosc1 = 4;*/
            if (phase1Action)
            {
                
            }

        }
        private void TimedEvent(object sender, ElapsedEventArgs e)
        {
            
        }
        public Form1()
        {
            InitializeComponent();
            generatePlayer();
            generateComputer();
            phase1();
            SetTimer();
        }
        int[] coords = new int[2];
        int iter = 0;
        private void klik(object sender, EventArgs e)
        {
            PictureBox pole = (PictureBox)sender;
            if(phase1Action)
            {
                for (int i = 0; i < Gracz.getPola(); i++)
                {
                    if (pole.Location == squaresG[i].Location)
                    {
                        //Info.Text += i + " "; 
                        squaresG[i].BackColor = Color.Gray;
                        coords[iter] = i;
                        iter++;
                        if (cztery.Checked)
                        {
                            Info.Text = "Wybierz początek i koniec statku.";
                            if (coords.Length == 2)
                            {
                                if (coords[1] - coords[0] == 30 || coords[0] - coords[1] == 30)
                                {
                                    squaresG[coords[0] + 10].BackColor = Color.Gray;
                                    squaresG[coords[0] + 20].BackColor = Color.Gray;
                                    count--;
                                    cztery.Enabled = false;
                                    cztery.Checked = false;
                                    iter = 0;
                                    Array.Clear(coords, 0, 2);
                                } else if(coords[1] - coords[0] == 3 || coords[0] - coords[1] == 3)
                                {
                                    squaresG[coords[0] + 1].BackColor = Color.Gray;
                                    squaresG[coords[0] + 2].BackColor = Color.Gray;
                                    count--;
                                    cztery.Enabled = false;
                                    cztery.Checked = false;
                                    iter = 0;
                                    Array.Clear(coords, 0, 2);
                                } else
                                {
                                    Info.Text = "Wprowadzono punkty nie w jednej linii, spróbuj ponownie.";
                                    iter = 0;
                                    squaresG[coords[0]].BackColor = Color.LightBlue;
                                    squaresG[coords[1]].BackColor = Color.LightBlue;
                                    Array.Clear(coords, 0, 2);
                                }
                            }
                        }
                    }
                }
            }
            
        }
        private void ruchKomputer(object sender, EventArgs e)
        {

        }
    }
}
