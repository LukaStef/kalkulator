//kvadratne jednacine
using Kalkulator;

namespace patnja
{
    public partial class KvadKal : Form
    {
        public KvadKal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);
                double x1 = ((b * (-1)) + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                double x2 = ((b * (-1)) - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                textBoxX1.Text = x1.ToString();
                textBoxX2.Text = x2.ToString();
                if (4 * a * c > 0)
                {
                    labelGORNJI.Text = (b * -1).ToString() + " ± √(" + (b * b).ToString() + "-" + (4*a*c).ToString() + ")";
                }
                else
                {
                    labelGORNJI.Text = (b * -1).ToString() + " ± √(" + (b * b).ToString() + "+" + ((4 * a * c)*-1).ToString() + ")";
                }
                labelDONJI.Text = (2 * a).ToString();
                if (textBoxX1.Text == "NaN" || textBoxX2.Text == "NaN" || textBoxX1.Text == "∞" || textBoxX2.Text == "∞")
                {
                    textBoxX1.Text = "";
                    textBoxX2.Text = "";
                    MessageBox.Show("Jednačina nema definisana rešenja","Nemoguća jednačina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu","Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
            textBoxX1.Text = "";
            textBoxX2.Text = "";
            labelGORNJI.Text = "-b ± √(b²-4ac)";
            labelDONJI.Text = "2a";
        }

        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uput.Tekst = "Kvadratne jednačine";
            Uputstvo u = new();
            u.ShowDialog();
            //MessageBox.Show("Unos je moguć preko tastature. Unesite željene množioce za nepoznate, pa kliknite na dugme 'Izračunaj' da dobijete rezultate kvadratne jednačine","Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
