using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kruz : Form
    {
        public Kruz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            double Ck = double.Parse(textBoxCk.Text);
            double D = double.Parse(textBoxD.Text);
            double F = double.Parse(textBoxF.Text);
            double A = double.Parse(textBoxA.Text);
            double B = double.Parse(textBoxB.Text);
            double Cp = double.Parse(textBoxCp.Text);
            double p = -(Ck / 2);
            double q = -(D / 2);
            textBoxCx.Text = (-(Ck / 2)).ToString();
            textBoxCy.Text = (-(D / 2)).ToString();
            textBoxR.Text = Math.Round((Math.Sqrt(p*p + q*q - F)),2).ToString();
            double R = double.Parse(textBoxR.Text);
            textBoxDG.Text = (Math.Abs(A*p + B*q + Cp)).ToString();
            textBoxDD.Text = (Math.Sqrt(A*A + B*B)).ToString();
            labelK.Text = "(x-(" + p + "))²+(y-(" + q + "))²=" + R*R;
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox[] niz = new TextBox[] { textBoxCk, textBoxD, textBoxF, textBoxA, textBoxB, textBoxCp, textBoxCx, textBoxCy, textBoxDG, textBoxDG };
            foreach (TextBox a in niz)
            {
                a.Text = "";
            }
            labelK.Text = "(x-p)²+(y-q)²=r²";
        }

        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uput.Tekst = "Analitika kružnice";
            Uputstvo u = new();
            u.ShowDialog();
            //MessageBox.Show("Unos je moguć preko tastature. Unesite sve potrebne vrednosti za pravu pa kliknite na dugme 'Izračunaj' da dobijete sve potrebne rezultate.", "Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
