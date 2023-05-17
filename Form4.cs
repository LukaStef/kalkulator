//temperatura
using Kalkulator;

namespace patnja
{
    public partial class TempKal : Form
    {
        public TempKal()
        {
            InitializeComponent();
        }
        string o="c";
        double c, f, k;
        Color svetloplava = Color.FromArgb(192, 255, 255);
        Color plava = Color.FromArgb(128, 255, 255);
        private void button1_Click(object sender, EventArgs e)
        {
            if (o == "c")
            {
                try
                {
                    c = double.Parse(textBoxC.Text);
                    if (c >= -273.15)
                    {
                        f = (c * 1.8) + 32;
                        k = c + 273.15;
                        textBoxF.Text = f.ToString();
                        textBoxK.Text = k.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Unos ne sme biti manji od apsolutne nule", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (o == "f")
            {
                try
                {
                    f = double.Parse(textBoxF.Text);
                    if (f >= -459.67)
                    {
                        c = (f - 32) / 1.8;
                        k = ((f - 32) / 1.8) + 273.15;
                        textBoxC.Text = c.ToString();
                        textBoxK.Text = k.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Unos ne sme biti manji od apsolutne nule", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (o == "k")
            {
                try
                {
                    k = double.Parse(textBoxK.Text);
                    if (k >= 0)
                    {
                        c = k - 273.15;
                        f = (c * 1.8) + 32;
                        textBoxF.Text = f.ToString();
                        textBoxC.Text = c.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Unos ne sme biti manji od apsolutne nule", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uput.Tekst = "Konverzija temperature";
            Uputstvo u = new();
            u.ShowDialog();
            //MessageBox.Show("Unos je moguć preko tastature. Izaberite jedinicu, unesite željenu vrednost pa kliknite na dugme 'Pretvori'", "Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAC_Click(object sender, EventArgs e) // AC
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
            textBoxK.Text = "";
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e) //cel
        {
            textBoxC.ReadOnly = false;
            textBoxF.ReadOnly = true;
            textBoxK.ReadOnly = true;
            textBoxC.Text = "";
            textBoxF.Text = "";
            textBoxK.Text = "";
            textBoxC.BackColor = plava;
            textBoxF.BackColor = svetloplava;
            textBoxK.BackColor = svetloplava;
            o = "c";
        }

        private void radioButtonF_CheckedChanged(object sender, EventArgs e) //far
        {
            textBoxC.ReadOnly = true;
            textBoxF.ReadOnly = false;
            textBoxK.ReadOnly = true;
            textBoxC.Text = "";
            textBoxF.Text = "";
            textBoxK.Text = "";
            textBoxC.BackColor = svetloplava;
            textBoxF.BackColor = plava;
            textBoxK.BackColor = svetloplava;
            o = "f";
        }

        private void radioButtonK_CheckedChanged(object sender, EventArgs e) //kel
        {
            textBoxC.ReadOnly = true;
            textBoxF.ReadOnly = true;
            textBoxK.ReadOnly = false;
            textBoxC.Text = "";
            textBoxF.Text = "";
            textBoxK.Text = "";
            textBoxC.BackColor = svetloplava;
            textBoxF.BackColor = svetloplava;
            textBoxK.BackColor = plava;
            o = "k";
        }
    }
}
