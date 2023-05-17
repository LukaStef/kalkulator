//duzina
using Kalkulator;

namespace patnja
{
    public partial class DuzKal : Form
    {
        public DuzKal()
        {
            InitializeComponent();
        }
        string o = "m";
        double m, i;
        Color svetloplava = Color.FromArgb(192, 255, 255);
        Color plava = Color.FromArgb(128, 255, 255);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (o == "m")
                {
                    m = double.Parse(textBoxM.Text);
                    i = 0;
                    //met
                    if (radioButtonkm.Checked == true)
                    {
                        m *= 1000;
                    }
                    if (radioButtondm.Checked == true)
                    {
                        m *= 0.1;
                    }
                    if (radioButtoncm.Checked == true)
                    {
                        m *= 0.01;
                    }
                    if (radioButtonmm.Checked == true)
                    {
                        m *= 0.001;
                    }
                    //imp
                    i = m * 39.370;
                    if (radioButtonft.Checked == true)
                    {
                        i /= 12;
                    }
                    if (radioButtonyd.Checked == true)
                    {
                        i /= 36;
                    }
                    if (radioButtonmi.Checked == true)
                    {
                        i /= 63360;
                    }
                    if (radioButtonnmi.Checked == true)
                    {
                        i /= 72913.39;
                    }
                    textBoxI.Text = i.ToString();
                }
                if (o == "i")
                {
                    i = double.Parse(textBoxI.Text);
                    if (radioButtonft.Checked == true)
                    {
                        i *= 12;
                    }
                    if (radioButtonyd.Checked == true)
                    {
                        i *= 36;
                    }
                    if (radioButtonmi.Checked == true)
                    {
                        i *= 63360;
                    }
                    if (radioButtonnmi.Checked == true)
                    {
                        i *= 72913.39;
                    }
                    m = i / 39.370;
                    if (radioButtonkm.Checked == true)
                    {
                        m /= 1000;
                    }
                    if (radioButtondm.Checked == true)
                    {
                        m /= 0.1;
                    }
                    if (radioButtoncm.Checked == true)
                    {
                        m /= 0.01;
                    }
                    if (radioButtonmm.Checked == true)
                    {
                        m /= 0.001;
                    }
                    textBoxM.Text = m.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uput.Tekst = "Konverzija dužine";
            Uputstvo u = new();
            u.ShowDialog();
            //MessageBox.Show("Unos je moguć preko tastature. Unesite željene brojeve, izaberite metričku jedinicu koja će se pretvarati u izabranu imperijalnu jedinicu, pa kliknite dugme 'Pretvori'", "Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonac_Click(object sender, EventArgs e) // AC
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
    }
}
