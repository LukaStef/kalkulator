//analitika tacke
using Kalkulator;

namespace patnja
{
    public partial class AnTac : Form
    {
        public AnTac()
        {
            InitializeComponent();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            try
            {
                double xA = double.Parse(textBoxxA.Text);
                double yA = double.Parse(textBoxyA.Text);

                double xB = double.Parse(textBoxxB.Text);
                double yB = double.Parse(textBoxyB.Text);

                double xC = double.Parse(textBoxxC.Text);
                double yC = double.Parse(textBoxyC.Text);

                double LAB = double.Parse(textBoxLAB.Text);
                double LAC = double.Parse(textBoxLAC.Text);
                double LBC = double.Parse(textBoxLBC.Text);

                double xM1 = (xA + LAB * xB) / (1 + LAB);
                double yM1 = (yA + LAB * yB) / (1 + LAB);
                textBoxxM1.Text = xM1.ToString();
                textBoxyM1.Text = yM1.ToString();

                double xM2 = (xA + LAC * xC) / (1 + LAC);
                double yM2 = (yA + LAC * yC) / (1 + LAC);
                textBoxxM2.Text = xM2.ToString();
                textBoxyM2.Text = yM2.ToString();

                double xM3 = (xB + LBC * xC) / (1 + LBC);
                double yM3 = (yB + LAC * yC) / (1 + LAC);
                textBoxxM3.Text = xM3.ToString();
                textBoxyM3.Text = yM3.ToString();

                double AB = Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2);
                textBoxAB.Text = "√" + AB.ToString();
                double AC = Math.Pow((xC - xA), 2) + Math.Pow((yC - yA), 2);
                textBoxAC.Text = "√" + AC.ToString();
                double BC = Math.Pow((xC - xB), 2) + Math.Pow((yC - yB), 2);
                textBoxBC.Text = "√" + BC.ToString();

                double AM3 = Math.Pow((xM3 - xA), 2) + Math.Pow((yM3 - yA), 2);
                textBoxAM3.Text = "√" + AM3.ToString();
                double BM2 = Math.Pow((xM2 - xB), 2) + Math.Pow((yM2 - yB), 2);
                textBoxBM2.Text = "√" + BM2.ToString();
                double CM1 = Math.Pow((xM1 - xC), 2) + Math.Pow((yM1 - yC), 2);
                textBoxCM1.Text = "√" + CM1.ToString();

                double P = 0.5 * Math.Abs(xA*(yB-yC) + xB*(yC-yA) + xC*(yA-yB));
                textBoxP.Text = P.ToString();

                double xT = (xA + xB + xC) / 3;
                textBoxxT.Text = xT.ToString();
                double yT = (yA + yB + yC) / 3;
                textBoxyT.Text = yT.ToString();
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu","Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBoxxA.Text = "";
            textBoxyA.Text = "";
            textBoxxB.Text = "";
            textBoxyB.Text = "";
            textBoxxC.Text = "";
            textBoxyC.Text = "";
            textBoxLAB.Text = "";
            textBoxLAC.Text = "";
            textBoxLBC.Text = "";
            textBoxxM1.Text = "";
            textBoxyM1.Text = "";
            textBoxxM2.Text = "";
            textBoxyM2.Text = "";
            textBoxxM3.Text = "";
            textBoxyM3.Text = "";
            textBoxAB.Text = "";
            textBoxAC.Text = "";
            textBoxBC.Text = "";
            textBoxAM3.Text = "";
            textBoxBM2.Text = "";
            textBoxCM1.Text = "";
            textBoxP.Text = "";
            textBoxxT.Text = "";
            textBoxyT.Text = "";
        }

        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uput.Tekst = "Analitika tačke";
            Uputstvo u = new();
            u.ShowDialog();
            //MessageBox.Show("Unos je moguć preko tastature. Unesite x i y koordinate svih tačaka i razmeru podela svih duži (unesite 1 ako želite težišne duži) pa kliknite na dugme 'Izračunaj' da bi vam se sva rešenja ispisala.","Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
