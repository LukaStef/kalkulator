//uglovi
using Kalkulator;

namespace patnja
{
    public partial class UglKal : Form
    {
        public UglKal()
        {
            InitializeComponent();
        }
        string o = "d";
        double d, r, g;
        Color svetloplava = Color.FromArgb(192, 255, 255);
        Color plava = Color.FromArgb(128, 255, 255);
        private void button1_Click(object sender, EventArgs e)
        {
            if (o == "d")
            {
                try
                {
                    d = double.Parse(textBoxD.Text);
                    while (d > 360)
                    {
                        d -= 360;
                    }
                    r = d * (Math.PI/180);
                    g = d * 1.1111111111;
                    r = Math.Round(r, 6);
                    g = Math.Round(g, 6);
                    textBoxR.Text = r.ToString();
                    textBoxG.Text = g.ToString();
                }
                catch
                {
                    MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (o == "r")
            {
                try
                {
                    r = double.Parse(textBoxR.Text);
                    while (r>6.283185)
                    {
                        r -= 6.283185;
                    }
                    d = r  * 180 / Math.PI;
                    g = r * 0.0157079633;
                    d = Math.Round(d, 6);
                    g = Math.Round(g, 6);
                    textBoxD.Text = d.ToString();
                    textBoxG.Text = g.ToString();
                }
                catch
                {
                    MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (o == "g")
            {
                try
                {
                    g = double.Parse(textBoxG.Text);
                    while(g>400)
                    { 
                        g -= 400;
                    }
                    d = g / 1.1111111111;
                    r = g * 0.0157079633;
                    r = Math.Round(r, 6);
                    d = Math.Round(d, 6);
                    textBoxR.Text = r.ToString();
                    textBoxD.Text = d.ToString();
                }
                catch
                {
                    MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBoxD.Text = "";
            textBoxR.Text = "";
            textBoxG.Text = "";
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            textBoxD.ReadOnly = false;
            textBoxR.ReadOnly = true;
            textBoxG.ReadOnly = true;
            textBoxD.Text = "";
            textBoxR.Text = "";
            textBoxG.Text = "";
            textBoxD.BackColor = plava;
            textBoxR.BackColor = svetloplava;
            textBoxG.BackColor = svetloplava;
            o = "d";
        }

        private void radioButtonF_CheckedChanged(object sender, EventArgs e)
        {
            textBoxD.ReadOnly = true;
            textBoxR.ReadOnly = false;
            textBoxG.ReadOnly = true;
            textBoxD.Text = "";
            textBoxR.Text = "";
            textBoxG.Text = "";
            textBoxD.BackColor = svetloplava;
            textBoxR.BackColor = plava;
            textBoxG.BackColor = svetloplava;
            o = "r";
        }

        private void radioButtonK_CheckedChanged(object sender, EventArgs e)
        {
            textBoxD.ReadOnly = true;
            textBoxR.ReadOnly = true;
            textBoxG.ReadOnly = false;
            textBoxD.Text = "";
            textBoxR.Text = "";
            textBoxG.Text = "";
            textBoxD.BackColor = svetloplava;
            textBoxR.BackColor = svetloplava;
            textBoxG.BackColor = plava;
            o = "g";
        }

        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uput.Tekst = "Konverzija uglova";
            Uputstvo u = new();
            u.ShowDialog();
            //MessageBox.Show("Unos je moguć preko tastature. Izaberite jedinicu, unesite željenu vrednost pa kliknite na dugme 'Pretvori'", "Uputstvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
