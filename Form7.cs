//3x3 sistem jednacina
using Kalkulator;

namespace patnja
{
    public partial class SisKal : Form
    {
        public SisKal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(textBoxx1.Text);
                double y1 = double.Parse(textBoxy1.Text);
                double z1 = double.Parse(textBoxz1.Text);

                double x2 = double.Parse(textBoxx2.Text);
                double y2 = double.Parse(textBoxy2.Text);
                double z2 = double.Parse(textBoxz2.Text);

                double x3 = double.Parse(textBoxx3.Text);
                double y3 = double.Parse(textBoxy3.Text);
                double z3 = double.Parse(textBoxz3.Text);

                double r1 = double.Parse(textBoxr1.Text);
                double r2 = double.Parse(textBoxr2.Text);
                double r3 = double.Parse(textBoxr3.Text);

                double D = (x1 * y2 * z3 + y1 * z2 * x3 + z1 * x2 * y3) - (x3 * y2 * z1 + y3 * z2 * x1 + z3 * x2 * y1);
                double Dx = (r1 * y2 * z3 + y1 * z2 * r3 + z1 * r2 * y3) - (r3 * y2 * z1 + y3 * z2 * r1 + z3 * r2 * y1);
                double Dy = (x1 * r2 * z3 + r1 * z2 * x3 + z1 * x2 * r3) - (x3 * r2 * z1 + r3 * z2 * x1 + z3 * x2 * r1);
                double Dz = (x1 * y2 * r3 + y1 * r2 * x3 + r1 * x2 * y3) - (x3 * y2 * r1 + y3 * r2 * x1 + r3 * x2 * y1);

                double x = Dx / D;
                double y = Dy / D;
                double z = Dz / D;

                textBoxx.Text = x.ToString();
                textBoxy.Text = y.ToString();
                textBoxz.Text = z.ToString();

                if (textBoxx.Text == "NaN" || textBoxy.Text == "NaN" || textBoxz.Text == "NaN" || textBoxx.Text == "∞" || textBoxy.Text == "∞" || textBoxz.Text == "∞")
                {
                    textBoxx.Text = "";
                    textBoxy.Text = "";
                    textBoxz.Text = "";
                    MessageBox.Show("Sistem nema definisana rešenja", "Nemoguć sistem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uput.Tekst = "3x3 sistem jednačina";
            Uputstvo u = new();
            u.ShowDialog();
            //MessageBox.Show("Unos je moguć preko tastature. Unesite željene vrednosti u polja za množioce nepoznatih i rešenja jednačina, pa kliknite dugme 'Izračunaj' da dobijete vrednosti nepoznatih.","Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonac_Click(object sender, EventArgs e)
        {
            textBoxx1.Text = "";
            textBoxx2.Text = "";
            textBoxx3.Text = "";
            textBoxy1.Text = "";
            textBoxy2.Text = "";
            textBoxy3.Text = "";
            textBoxz1.Text = "";
            textBoxz2.Text = "";
            textBoxz3.Text = "";
            textBoxr1.Text = "";
            textBoxr2.Text = "";
            textBoxr3.Text = "";
            textBoxx.Text = "";
            textBoxy.Text = "";
            textBoxz.Text = "";
        }
    }
}
