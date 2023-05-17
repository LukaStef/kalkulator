//masa
using Kalkulator;

namespace patnja
{
    public partial class MasKal : Form
    {
        public MasKal()
        {
            InitializeComponent();
        }
        string o = "m";
        double m, i;
        Color svetloplava = Color.FromArgb(192, 255, 255);
        Color plava = Color.FromArgb(128, 255, 255);

        private void buttonac_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "";
            textBoxI.Text = "";
        }

        private void radioButtonMET_CheckedChanged(object sender, EventArgs e)
        {
            textBoxM.ReadOnly = false;
            textBoxI.ReadOnly = true;
            textBoxM.Text = "";
            textBoxI.Text = "";
            textBoxM.BackColor = plava;
            textBoxI.BackColor = svetloplava;
            o = "m";
        }

        private void radioButtonIMP_CheckedChanged(object sender, EventArgs e)
        {
            textBoxM.ReadOnly = true;
            textBoxI.ReadOnly = false;
            textBoxM.Text = "";
            textBoxI.Text = "";
            textBoxM.BackColor = svetloplava;
            textBoxI.BackColor = plava;
            o = "i";
        }

        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uput.Tekst = "Konverzija mase";
            Uputstvo u = new();
            u.ShowDialog();
            //MessageBox.Show("Unos je moguć preko tastature. Unesite željene brojeve, izaberite metričku jedinicu koja će se pretvarati u izabranu imperijalnu jedinicu, pa kliknite dugme 'Pretvori'", "Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (o == "m")
                {
                    m = double.Parse(textBoxM.Text);
                    i = 0;
                    //met
                    if (radioButtontMET.Checked == true)
                    {
                        m *= 1000;
                    }
                    if (radioButtong.Checked == true)
                    {
                        m *= 0.001;
                    }
                    if (radioButtoncg.Checked == true)
                    {
                        m *= 0.0001;
                    }
                    if (radioButtonmg.Checked == true)
                    {
                        m *= 0.00001;
                    }
                    //imp
                    i = m * 2.204623;
                    if (radioButtondr.Checked == true)
                    {
                        i *= 256;
                    }
                    if (radioButtonoz.Checked == true)
                    {
                        i *= 16;
                    }
                    if (radioButtonqr.Checked == true)
                    {
                        i /= 28;
                    }
                    if (radioButtontIMP.Checked == true)
                    {
                        i /= 2240;
                    }
                    textBoxI.Text = i.ToString();
                }
                if (o == "i")
                {
                    i = double.Parse(textBoxI.Text);
                    if (radioButtondr.Checked == true)
                    {
                        i /= 256;
                    }
                    if (radioButtonoz.Checked == true)
                    {
                        i /= 16;
                    }
                    if (radioButtonqr.Checked == true)
                    {
                        i *= 28;
                    }
                    if (radioButtontIMP.Checked == true)
                    {
                        i *= 2240;
                    }
                    m = i / 2.204623;
                    if (radioButtontMET.Checked == true)
                    {
                        m /= 1000;
                    }
                    if (radioButtong.Checked == true)
                    {
                        m /= 0.001;
                    }
                    if (radioButtoncg.Checked == true)
                    {
                        m /= 0.0001;
                    }
                    if (radioButtonmg.Checked == true)
                    {
                        m /= 0.00001;
                    }
                    textBoxM.Text = m.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
