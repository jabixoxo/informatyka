using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormLicznik : Form
    {
        
        public FormLicznik()
        {
            InitializeComponent();
        }
        int liczba;
        private void buttonHasztag_Click(object sender, EventArgs e)
        {
            int odpowiedz = Int32.Parse(textBoxWynik.Text);
            if (liczba == odpowiedz)
            {
                textBoxWynik.Text = "udalo sie";
            }
            if (liczba > odpowiedz)
            {
                textBoxWynik.Text = "za duzo";
            }
            if (liczba < odpowiedz)
            {
                textBoxWynik.Text = "za malo";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxWynik.Text ==  "za malo" || textBoxWynik.Text == "za duzo")
            {
                textBoxWynik.Text = "";
            }
            textBoxWynik.Text = textBoxWynik.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxWynik.Text == "za malo" || textBoxWynik.Text == "za duzo")
            {
                textBoxWynik.Text = "";
            }
            textBoxWynik.Text = textBoxWynik.Text +2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxWynik.Text == "za malo" || textBoxWynik.Text == "za duzo")
            {
                textBoxWynik.Text = "";
            }
            textBoxWynik.Text = textBoxWynik.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxWynik.Text == "za malo" || textBoxWynik.Text == "za duzo")
            {
                textBoxWynik.Text = "";
            }
            textBoxWynik.Text = textBoxWynik.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxWynik.Text == "za malo" || textBoxWynik.Text == "za duzo")
            {
                textBoxWynik.Text = "";
            }
            textBoxWynik.Text = textBoxWynik.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxWynik.Text == "za malo" || textBoxWynik.Text == "za duzo")
            {
                textBoxWynik.Text = "";
            }
            textBoxWynik.Text = textBoxWynik.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxWynik.Text == "za malo" || textBoxWynik.Text == "za duzo")
            {
                textBoxWynik.Text = "";
            }
            textBoxWynik.Text = textBoxWynik.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxWynik.Text == "za malo" || textBoxWynik.Text == "za duzo")
            {
                textBoxWynik.Text = "";
            }
            textBoxWynik.Text = textBoxWynik.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxWynik.Text == "za malo" || textBoxWynik.Text == "za duzo")
            {
                textBoxWynik.Text = "";
            }
            textBoxWynik.Text = textBoxWynik.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxWynik.Text == "za malo" || textBoxWynik.Text == "za duzo")
            {
                textBoxWynik.Text = "";
            }
            textBoxWynik.Text = textBoxWynik.Text + 0;
        }

        private void buttonGwiazdka_Click(object sender, EventArgs e)
        {
            int N = 1000;
            Random x = new Random();
            liczba = x.Next(0, N);
        }

        private void textBoxWynik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
