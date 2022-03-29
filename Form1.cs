using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra___Kółko_i_krzyżyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gracz1 = true; //Jeżeli gracz1 ma wartość true to mówimy o graczu z kółkiem, a jeżeli ma wartość false to mówimy o graczu z krzyżykiem
        int ruch = 0;   //Pomoże przy wykryciu zablokowania mozliwosci dalszego ruchu (koniec gry)

        private void btnRestartuj_Click(object sender, EventArgs e)
        {
            Restartuj();
            wynikO.Text = "0";  //Zerujemy kontrolki wyniku
            wynikX.Text = "0";
            lblKto.Text = "O";
            gracz1 = true;

        }

        private void Restartuj()
        {
            ruch = 0;
            Button[] wszystkiePrzyciski = new Button[9];

            wszystkiePrzyciski[0] = btn1;
            wszystkiePrzyciski[1] = btn2;
            wszystkiePrzyciski[2] = btn3;
            wszystkiePrzyciski[3] = btn4;
            wszystkiePrzyciski[4] = btn5;
            wszystkiePrzyciski[5] = btn6;
            wszystkiePrzyciski[6] = btn7;
            wszystkiePrzyciski[7] = btn8;
            wszystkiePrzyciski[8] = btn9;

            foreach (Button przycisk in wszystkiePrzyciski)
            {
                przycisk.Enabled = true;    //Ustawianie wartości wszystkich przycisków na enabled aby można było je kliknąć
                przycisk.Text = "";         //Usunięcie znaków ze środka przycisków
            }
        }
        private void Sprawdz()
        {
            //Sprawdzanie każdej możliwości wygranej (pionowo, poziomi i na ukos)
            if(btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
            {
                Wygrana();
            }
            else if(btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text)
            {
                Wygrana();
            }
            else if(btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text)
            {
                Wygrana();
            }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text)
            {
                Wygrana();
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text)
            {
                Wygrana();
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text)
            {
                Wygrana();
            }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text)
            {
                Wygrana();
            }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text)
            {
                Wygrana();
            }
            else if(ruch == 9)  //Ostatni ruch
            {
                MessageBox.Show("Remis", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restartuj();
            }
        }

        private void Wygrana()
        {
            MessageBox.Show("Wygrywa gracz: " + (gracz1 ? "O" : "X"), "Wygrana", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if(gracz1)  //Skrócony zapis gracz1==true
            {
                wynikO.Text = ((int.Parse(wynikO.Text)) + 1).ToString();    //Parsujemy najpierw na int aby dodać nasz punkt, a następnie znowu na string, ponieważ taki typ danych przechowuje nasza kontrolka
                Restartuj();
            }
            else//gracz1 == false(!gracz1)
            {
                wynikX.Text = ((int.Parse(wynikX.Text)) + 1).ToString();
                Restartuj();
            }
        }

        private void btn1_Click(object sender, EventArgs e) //Sender przechowuje kto wysłał zdarzenie
        {
            ruch++; //Aby 1 sprawdzenie wynosiło 1
            //Jeżeli jest to prawda to zwróć string "O" a w przeciwnym wypadku zwróć string "X"
            ((Button)sender).Text = gracz1 ? "O" : "X";//Skrócony operator warunkowy
            ((Button)sender).Enabled = false;   //Wyłączanie naszych przycisków po kliknięciu 

            if(ruch >= 5)   //Można wygrać grę po minimum 5 ruchach 
            {
                Sprawdz();
            }
            gracz1 = !gracz1;   //Ruch gracza powoduje negacje (zamiane gracza O na gracza X i odwrotnie)
            lblKto.Text = gracz1 ? "O" : "X";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ruch++; 
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }
    }
}