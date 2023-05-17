//analitika prave
using Kalkulator;

namespace patnja
{
    public partial class AnPrav : Form
    {
        public AnPrav()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(textBoxx1.Text);
                double y1 = double.Parse(textBoxy1.Text);
                double x2 = double.Parse(textBoxx2.Text);
                double y2 = double.Parse(textBoxy2.Text);
                double k1 = double.Parse(textBoxk1.Text);
                double k2 = double.Parse(textBoxk2.Text);
                double A = double.Parse(textBoxA.Text);
                double B = double.Parse(textBoxB.Text);
                double C = double.Parse(textBoxC.Text);
                labelJed1.Text = "y-(" + y1 + ")=" + k1 + "(x-(" + x1 + "))";
                labelJed2.Text = "y-(" + y2 + ")=" + k2 + "(x-(" + x2 + "))";
                labelLEVI.Text = "y-(" + y2 + ")=";

                labelGORNJI.Text = (y2 - y1).ToString();
                labelDONJI.Text = (x2 - x1).ToString();
                labelDESNI.Text = "(x-(" + x2 + "))";

                double j1,j2;
                j1 = k1*x1 - y1;
                j2 = k2*x2 - y2;
                labelE1.Text = "Prava 1: y=" + k1 + "x-(" + j1 + ")";
                labelE2.Text = "Prava 2: y=" + k2 + "x-(" + j2 + ")";

                labelI1.Text = A + "x" + "+(" + B + ")y" + "+(" + C + ")=0";

                labelM.Text = "m: " + -1 * (C / A);
                labelN.Text = "n: " + -1 * (C / B);
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu","Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uput.Tekst = "Analitika prave";
            Uputstvo u = new();
            u.ShowDialog();
            //MessageBox.Show("Unos je moguć preko tastature. Unesite sve potrebne vrednosti za pravu pa kliknite na dugme 'Izračunaj' da dobijete sve jednačine.","Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxx1.Text = "";
            textBoxx2.Text = "";
            textBoxy1.Text = "";
            textBoxy2.Text = "";
            textBoxk1.Text = "";
            textBoxk2.Text = "";
            labelJed1.Text = "y-y1=k(x-x1)";
            labelJed2.Text = "y-y2=k(x-x2)";
            labelLEVI.Text = "y-y2 = ";
            labelGORNJI.Text = "y2-y1";
            labelDONJI.Text = "x2-x1";
            labelDESNI.Text = "(x-x2)";
            labelE1.Text = "Prava 1: y=k1x+n";
            labelE2.Text = "Prava 2: y=k2x+n";
            labelI1.Text = "Ax+By+C=0";
            labelM.Text = "m:";
            labelN.Text = "n:";
        }
    }
}
