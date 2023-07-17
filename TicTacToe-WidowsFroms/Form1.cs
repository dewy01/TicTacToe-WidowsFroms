using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_WidowsFroms
{
    public partial class Form1 : Form
    {
        bool czyj_ruch = true; //true to X, false to O

        public Form1()
        {
            InitializeComponent();
            lblCzyjRuch.Text = "X";
        }

        private void WstawZnak(object przycisk)
        {
            Button wcisnietyPrzycisk = (Button)przycisk;
            //tłumaczymy, że sender to obiekt,który został wciśnięty, musimy go zrzutować
            //na typ Button(przycisk), aby można było ustawić mu znak i ew. wyłączyć


            if (czyj_ruch)
            {
                wcisnietyPrzycisk.Text = "X";
            }
            else
            {
                wcisnietyPrzycisk.Text = "O";
            }


            wcisnietyPrzycisk.Enabled = false;


            bool wynik = SprawdzCzyKtosWygral();




            if (wynik == true)
            {
                string tekstWygranej;
                if (czyj_ruch == true)
                {
                    tekstWygranej = "Wygrał Gracz X! Rozpocząć jeszcze raz?";
                }
                else


                {


                    tekstWygranej = "Wygrał Gracz O! Rozpocząć jeszcze raz?";
                }


                //Sprawdzamy, czy gracze chcą kontynuować czy nie
                DialogResult odpowiedz = MessageBox.Show(tekstWygranej, "Wygrana", MessageBoxButtons.YesNo);


                if (odpowiedz == DialogResult.Yes)
                {
                    WlaczWszystkiePrzyciskiIResetuj();
                    return;
                }
                else
                {
                    Close();
                }
            }




            czyj_ruch = !czyj_ruch; //przełączamy gracza
            if (czyj_ruch == true)
            {
                lblCzyjRuch.Text = "X";
            }
            else
            {
                lblCzyjRuch.Text = "O";
            }


        }


        private void WlaczWszystkiePrzyciskiIResetuj()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            czyj_ruch = true;
            lblCzyjRuch.Text = "X";
        }




        private bool SprawdzCzyKtosWygral()
        {

            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "")

            {
                return true;
            }

            else if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "")
            {
                return true;
            }

            else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "")
            {
                return true;
            }

            else if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "")
            {
                return true;
            }

            else if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "")
            {
                return true;
            }

            else if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "")
            {
                return true;
            }
            else if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "")
            {
                return true;
            }

            else if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
    }
}
