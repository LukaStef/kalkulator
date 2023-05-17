//logicke operacije
using Kalkulator;

namespace patnja
{
    public partial class LogKal : Form
    {
        public LogKal()
        {
            InitializeComponent();
        }
        int a, b, c,ia,ib;
        private void buttonAND_Click(object sender, EventArgs e)
        {
            a = int.Parse(numericUpDownA.Text);
            b = int.Parse(numericUpDownB.Text);
            if (a == 1)
            {
                ia = 0;
            }
            else
            {
                ia = 1;
            }
            textBoxo.Text = "AND";
            if (a * b == 0)
            {
                c = 0;
            }
            else
            {
                c = 1;
            }
            textBoxc.Text = c.ToString();
        }

        private void buttonNAND_Click(object sender, EventArgs e)
        {
            a = int.Parse(numericUpDownA.Text);
            b = int.Parse(numericUpDownB.Text);
            if (a == 1)
            {
                ia = 0;
            }
            else
            {
                ia = 1;
            }
            if (b == 1)
            {
                ib = 0;
            }
            else
            {
                ib = 1;
            }
            textBoxo.Text = "NAND";
            if (a * b == 0)
            {
                c = 1;
            }
            else
            {
                c = 0;
            }
            textBoxc.Text = c.ToString();
        }

        private void buttonXAND_Click(object sender, EventArgs e)
        {
            a = int.Parse(numericUpDownA.Text);
            b = int.Parse(numericUpDownB.Text);
            if (a == 1)
            {
                ia = 0;
            }
            else
            {
                ia = 1;
            }
            if (b == 1)
            {
                ib = 0;
            }
            else
            {
                ib = 1;
            }
            textBoxo.Text = "XAND";
            if ((ia + b) * (a + ib) == 0)
            {
                c = 0;
            }
            else
            {
                c = 1;
            }
            textBoxc.Text = c.ToString();
        }
        private void buttonOR_Click(object sender, EventArgs e)
        {
            a = int.Parse(numericUpDownA.Text);
            b = int.Parse(numericUpDownB.Text);
            if (a == 1)
            {
                ia = 0;
            }
            else
            {
                ia = 1;
            }
            if (b == 1)
            {
                ib = 0;
            }
            else
            {
                ib = 1;
            }
            textBoxo.Text = "OR";
            if (a + b == 0)
            {
                c = 0;
            }
            else
            {
                c = 1;
            }
            textBoxc.Text = c.ToString();
        }

        private void buttonNOR_Click(object sender, EventArgs e)
        {
            a = int.Parse(numericUpDownA.Text);
            b = int.Parse(numericUpDownB.Text);
            if (a == 1)
            {
                ia = 0;
            }
            else
            {
                ia = 1;
            }
            if (b == 1)
            {
                ib = 0;
            }
            else
            {
                ib = 1;
            }
            textBoxo.Text = "NOR";
            if (a + b == 0)
            {
                c = 1;
            }
            else
            {
                c = 0;
            }
            textBoxc.Text = c.ToString();
        }

        private void buttonXOR_Click(object sender, EventArgs e)
        {
            a = int.Parse(numericUpDownA.Text);
            b = int.Parse(numericUpDownB.Text);
            if (a == 1)
            {
                ia = 0;
            }
            else
            {
                ia = 1;
            }
            if (b == 1)
            {
                ib = 0;
            }
            else
            {
                ib = 1;
            }
            textBoxo.Text = "XOR";
            if ((ia * b) + (a * ib) == 0)
            {
                c = 0;
            }
            else
            {
                c = 1;
            }
            textBoxc.Text = c.ToString();
        }
        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uput.Tekst = "Logičke operacije";
            Uputstvo u = new();
            u.ShowDialog();
            //MessageBox.Show("Izaberite vrednosti na levoj strani pa kliknite na željenu operaciju.", "Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
