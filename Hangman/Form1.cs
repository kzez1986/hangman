using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hangman
{
    public partial class foWisielec : Form
    {

        private List<string> słowa;
        private List<string> opisy;
        private Button[] alfabet;

        private char[] wzorzec;
        private int numer;
        private int ile_prób;
        private int ile_pomyłek;

        public foWisielec()
        {
            InitializeComponent();
            char litera = '\'';
            alfabet = new Button[54]; //angielski alfabet
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    alfabet[i * 18 + j] = new Button();
                    alfabet[i * 18 + j].Text = litera.ToString();
                    alfabet[i * 18 + j].Parent = this;
                    alfabet[i * 18 + j].Width = 30;
                    alfabet[i * 18 + j].Height = 30;
                    alfabet[i * 18 + j].Left = (j * 35) + 40;
                    alfabet[i * 18 + j].Top = this.Height - ((1 - i) * 35) - 10;
                    alfabet[i * 18 + j].Visible = true;
                    alfabet[i * 18 + j].Enabled = false;
                    alfabet[i * 18 + j].Click += Klik;
                    litera++;
                }
            }
            Height = 500;
            numer = -1;
            słowa = new List<string>();
            opisy = new List<string>();
            ile_pomyłek = 6;
            ile_prób = 0;
        }

        public void Klik(object sender, EventArgs e)
        {
            bool ok = false;
            Button kliknięty = (Button)sender;
            for (int i = 0; i < słowa[numer].Length; i++)
            {
                if (słowa[numer][i] == kliknięty.Text[0])
                {
                    wzorzec[i] = słowa[numer][i];
                    ok = true;
                }
            }
            if (!ok)
            {
                ile_prób++;
            }
            if (ile_prób == ile_pomyłek) //nie udało się odgadnąć
            {
                laNumerPróby.Text = "Liczba błędów: " + ile_prób.ToString();
                MessageBox.Show("Nie udało się odgadnąć słowa.", "Koniec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeaktywujAlfabet();
                ile_prób = 0;
                nuIlePomyłek.Enabled = true;
                laSłowo.Text = słowa[numer];
            }
            else if (Wszystkie())
            {
                MessageBox.Show("Brawo! Prawidłowa odpowiedź.", "Koniec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeaktywujAlfabet();
                ile_prób = 0;
                nuIlePomyłek.Enabled = true;
                laSłowo.Text = CharToString(wzorzec);
            }
            else
            {
                kliknięty.Enabled = false;
                laSłowo.Text = CharToString(wzorzec);
                nuIlePomyłek.Enabled = false;
                laNumerPróby.Text = "Liczba błędów: " + ile_prób.ToString();
            }
        }

        public bool Wszystkie()
        {
            for (int i = 0; i < wzorzec.Length; i++)
                if (wzorzec[i] == '.')
                    return false;
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void WczytajPlik(string nazwaPliku)
        {
            słowa.Clear();
            opisy.Clear();
            StreamReader sr = new StreamReader(nazwaPliku);
            string linia;
            while (!sr.EndOfStream)
            {
                linia = sr.ReadLine();
                int indeks = linia.LastIndexOf('|');
                string[] podział = new string[2];
                podział[0] = linia.Substring(0, indeks);
                podział[1] = linia.Substring(indeks + 1, linia.Length - indeks - 1);
                podział[0] = podział[0].ToUpper(); //wszystkie słowa pisane dużymi literami, opisy normalnie
                słowa.Add(podział[0]);
                opisy.Add(podział[1]);
            }
            sr.Close();
        }

        private void buLosuj_Click(object sender, EventArgs e)
        {
            Random los = new Random();
            numer = los.Next(słowa.Count);
            wzorzec = null;
            UtwórzWzorzec();
            AktywujAlfabet();
        }

        public void UtwórzWzorzec()
        {
            for (int i = 0; i < słowa[numer].Length; i++)
            {
                if (słowa[numer][i] != ' ')
                    wzorzec = StringToChar(CharToString(wzorzec) + ".");
                else
                    wzorzec = StringToChar(CharToString(wzorzec) + " ");
            }
            laSłowo.Text = CharToString(wzorzec);
            ile_prób = 0;
            nuIlePomyłek.Enabled = true;
            AktywujAlfabet();
            laNumerPróby.Text = "Liczba błędów: 0";
            laOpis.Text = opisy[numer];
        }

        private void buNastępne_Click(object sender, EventArgs e)
        {
            numer++;
            if (numer >= słowa.Count)
                numer = numer % słowa.Count;
            wzorzec = null;
            UtwórzWzorzec();
            AktywujAlfabet();
        }

        private void buWczytaj_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WczytajPlik(openFileDialog1.FileName);
                if (słowa.Count > 0)
                {
                    buLosuj.Enabled = true;
                    buNastępne.Enabled = true;
                    laNumerPróby.Text = "Liczba błędów: 0";
                }
            }
        }

        public char[] StringToChar(string str)
        {
            char[] wynik = new char[str.Length];
            if (str == null)
                return wynik;
            for (int i = 0; i < str.Length; i++)
            {
                wynik[i] = str[i];
            }
            return wynik;
        }

        public string CharToString(char[] tab)
        {
            string wynik = null;
            if (tab == null)
                return wynik;
            for (int i = 0; i < tab.Length; i++)
            {
                wynik = wynik + tab[i];
            }
            return wynik;
        }

        public void AktywujAlfabet()
        {
            for (int i = 0; i < alfabet.Length; i++)
                alfabet[i].Enabled = true;
        }

        public void DeaktywujAlfabet()
        {
            for (int i = 0; i < alfabet.Length; i++)
                alfabet[i].Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ile_pomyłek = (int)nuIlePomyłek.Value;
        }

        private void foWisielec_Resize(object sender, EventArgs e)
        {
            Size s = new Size();
            s.Width = Width - 20;
            laOpis.MaximumSize = s;
            laSłowo.MaximumSize = s;
        }
    }
}
