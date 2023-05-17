//kompleksni brojevi
using Kalkulator;

namespace patnja
{
    public partial class KompKal : Form
    {
        public KompKal()
        {
            InitializeComponent();
        }
        double a = 0;
        double b = 0;
        double r = 0;
        private void button1_Click(object sender, EventArgs e) // izracunaj
        {
            try
            {
                a = double.Parse(textBoxR.Text);
                b = double.Parse(textBoxI.Text);
                r = 0;
                //ispis
                if (b >= 0)
                {
                    textBoxISPIS.Text = a.ToString() + " + " + b.ToString() + "i";
                }
                else if (b < 0)
                {
                    double bp = b * -1;
                    textBoxISPIS.Text = a.ToString() + " - " + bp.ToString() + "i";
                }
                //racunanje
                if (radioButtonMODUO.Checked == true)
                {
                    r = Math.Sqrt((a * a) + (b * b));
                }
                if (radioButtonARG.Checked == true)
                {
                    double ba = b / a;
                    double radijan;
                    radijan = Math.Atan(ba);
                    r = radijan;
                    if (radioButtonDEG.Checked == true)
                    {
                        r = radijan * 180 / Math.PI;//Pretvaram u stepene
                    }
                    textBoxREZ.Text = r.ToString();

                }
                textBoxREZ.Text = r.ToString();
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uput.Tekst = "Kompleksni brojevi";
            Uputstvo u = new();
            u.ShowDialog();
            //MessageBox.Show("Unos je moguć preko tastature. Unesite željene brojeve, izaberite operaciju pa kliknite na dugme 'Izračunaj'", "Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxR.Text = "";
            textBoxI.Text = "";
            textBoxISPIS.Text = "";
            textBoxREZ.Text = "";
            a = 0;
            b = 0;
            r = 0;
        }
    }
}
