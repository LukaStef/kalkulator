using Kalkulator;
using System.ComponentModel;
using System.Diagnostics;

namespace patnja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //napravljeno: 21.11.2022.
        //poslednja izmena: 24.05.2023.
        #region promenljive
        double m = 0; //memorija
        double p = 0; //prvi broj
        double d = 0; //drugi broj
        double r; //resenje
        string o = ""; //operacija
        string i = "", znak = ""; //ispis za istoriju
        int r1, r2; //za random operaciju
        int zk; //za zaokruzivanje
        bool greska = false; //ne ispisuje istoriju ako je true
        readonly Random R = new(); //random
        #endregion
        #region osnovno
        private void buttonac_Click(object sender, EventArgs e) // AC
        {
            d = 0;
            p = 0;
            textBox1.Text = "";
            textBoxBIN.Text = "";
            textBoxOCT.Text = "";
            textBoxHEX.Text = "";
        }
        private void buttonc_Click(object sender, EventArgs e) // C
        {
            textBox1.Text = "";
        }
        private void buttonback_Click(object sender, EventArgs e) // backspace
        {
            if (textBox1.Text != "")
            {
                string s1 = textBox1.Text;
                string s2 = s1.Remove(s1.Length - 1, 1);
                textBox1.Text = s2;
            }
            else
            {
                MessageBox.Show("Unos je već prazan", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_Validating(object sender, CancelEventArgs e) // provera unosa
        {
            try
            {
                if (textBox1.Text != "")
                {
                    double broj = double.Parse(textBox1.Text);
                }
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region unos brojeva
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void buttontacka_Click(object sender, EventArgs e) // decimalni zarez
        {
            textBox1.Text += ',';
        }
        private void buttonpi_Click(object sender, EventArgs e) // pi
        {
            textBox1.Text = Math.PI.ToString();
        }
        private void buttone_Click(object sender, EventArgs e) // e
        {
            textBox1.Text = Math.E.ToString();
        }
        private void buttonplusminus_Click(object sender, EventArgs e) // +/-
        {
            if (textBox1.Text != "")
            {
                double x = double.Parse(textBox1.Text);
                x = x * -1;
                textBox1.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region memorija
        private void buttonm_Click(object sender, EventArgs e) // M
        {
            try
            {
                m = double.Parse(textBox1.Text);
                textBoxM.Text = m.ToString();
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonrm_Click(object sender, EventArgs e) // RM
        {
            if (m != 0)
            {
                textBox1.Text = m.ToString();
            }
            else
            {
                MessageBox.Show("Memorija je prazna", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonmplus_Click(object sender, EventArgs e) // M+
        {
            try
            {
                m += double.Parse(textBox1.Text);
                textBoxM.Text = m.ToString();
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonmminus_Click(object sender, EventArgs e) // M-
        {
            try
            {
                m -= double.Parse(textBox1.Text);
                textBoxM.Text = m.ToString();
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttoncm_Click(object sender, EventArgs e) // CM
        {
            m = 0;
            textBoxM.Text = "";
        }

        private void button10_Click(object sender, EventArgs e) // cisti istoriju
        {
            richTextBoxIST.Text = "";
        }
        #endregion
        #region operacije
        private void buttonjednako_Click(object sender, EventArgs e) // =
        {
            try
            {
                d = double.Parse(textBox1.Text);
                double s = p;
                if (o == "+")
                {
                    r = p + d;
                    znak = " + ";
                }
                if (o == "-")
                {
                    r = p - d;
                    znak = " - ";
                }
                if (o == "*")
                {
                    r = p * d;
                    znak = " * ";
                }
                if (o == "r")
                {
                    r2 = int.Parse(textBox1.Text);
                    if (r1 < r2)
                    {
                        r = R.Next(r1, r2 + 1);
                        richTextBoxIST.Text += "Izmedju ";
                        znak = " i ";
                    }
                    else
                    {
                        MessageBox.Show("Donja granica ne sme biti veća od gornje", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    p = r1;
                    d = r2;
                }
                if (o == "z")
                {
                    zk = int.Parse(textBox1.Text);
                    d = zk;
                    if (zk >= 0)
                    {
                        double z = Math.Round(p, zk);
                        r = z;
                        znak = " zaokruzeno na ";
                    }
                    else
                    {
                        MessageBox.Show("Broj ne sme biti negativan", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        greska = true;
                    }
                }
                if (o == "m")
                {
                    r = p % d;
                    znak = " % ";
                }
                textBox1.Text = r.ToString();
                if (o == "^")
                {
                    r = Math.Pow(p, d);
                    if (p == 0 && d == 0)
                    {
                        MessageBox.Show("Izraz nije ispravan", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        greska = true;
                        r = 0;
                    }
                    textBox1.Text = r.ToString();
                    znak = " ^ ";
                }
                if (o == "k")
                {
                    double k = 1 / d;
                    r = Math.Pow(p, k);
                    textBox1.Text = r.ToString();
                    znak = " √ ";
                }
                if (o == "/")
                {
                    if (d != 0)
                    {
                        r = p / d;
                        textBox1.Text = r.ToString();
                        znak = " / ";
                    }
                    else
                    {
                        MessageBox.Show("Izraz nije ispravan", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        greska = true;
                    }
                }
                if (o == "l")
                {
                    r = Math.Log(p, d);
                    textBox1.Text = r.ToString();
                    znak = " log baze ";
                }
                //istorija
                if (greska == false)
                {
                    i = p.ToString() + znak.ToString() + d.ToString() + " = " + r + "\n";
                    richTextBoxIST.Text += i;
                }
                greska = false;
                textBox1.Focus();
                r = 0;
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonplus_Click(object sender, EventArgs e) // +
        {
            try
            {
                p = double.Parse(textBox1.Text);
                textBox1.Text = "";
                p += r;
                o = "+";
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonminus_Click(object sender, EventArgs e) // -
        {
            try
            {
                p = double.Parse(textBox1.Text);
                textBox1.Text = "";
                o = "-";
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonputa_Click(object sender, EventArgs e) // *
        {
            try
            {
                p = double.Parse(textBox1.Text);
                textBox1.Text = "";
                o = "*";
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonpodeljeno_Click(object sender, EventArgs e) // /
        {
            try
            {
                p = double.Parse(textBox1.Text);
                textBox1.Text = "";
                o = "/";
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonstepen_Click(object sender, EventArgs e) // x^n
        {
            try
            {
                p = double.Parse(textBox1.Text);
                textBox1.Text = "";
                o = "^";
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonkoren_Click(object sender, EventArgs e) // √n
        {
            try
            {
                p = double.Parse(textBox1.Text);
                textBox1.Text = "";

                if (p >= 0)
                {
                    o = "k";
                }
                else
                {
                    MessageBox.Show("Izraz nije ispravan", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonfaktorijal_Click(object sender, EventArgs e) // n!
        {
            try
            {
                p = double.Parse(textBox1.Text);
                double f = 1;
                for (int i = 1; i <= p; i++)
                {
                    f *= i;
                }
                textBox1.Text = f.ToString();
                i = p.ToString() + "! = " + f + "\n";
                richTextBoxIST.Text += i;
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonsin_Click(object sender, EventArgs e) // sin
        {
            try
            {
                p = double.Parse(textBox1.Text);
                if (radioButtonDEG.Checked == true)
                {
                    r = Math.Sin(p * Math.PI / 180);
                    if ((r > 0 && r < 0.000000000000001) || (r < 0 && r > -0.000000000000001))
                        r = 0;
                }
                if (radioButtonRAD.Checked == true)
                {
                    r = Math.Sin(p);
                }
                i = "sin(" + p + ") = " + r + "\n";
                richTextBoxIST.Text += i;
                textBox1.Text = r.ToString();
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttoncos_Click(object sender, EventArgs e) // cos
        {
            try
            {
                p = double.Parse(textBox1.Text);
                if (radioButtonDEG.Checked == true)
                {
                    r = Math.Cos(p * Math.PI / 180);
                    if ((r > 0 && r < 0.0000000000000001) || (r < 0 && r > -0.0000000000000001))
                        r = 0;
                }
                if (radioButtonRAD.Checked == true)
                {
                    r = Math.Cos(p);
                }
                i = "cos(" + p + ") = " + r + "\n";
                richTextBoxIST.Text += i;
                textBox1.Text = r.ToString();
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttontan_Click(object sender, EventArgs e) // tan
        {
            try
            {
                p = double.Parse(textBox1.Text);
                if (radioButtonDEG.Checked == true)
                {
                    r = Math.Tan(p * Math.PI / 180);
                }
                if (radioButtonRAD.Checked == true)
                {
                    r = Math.Tan(p);
                }
                i = "tan(" + p + ") = " + r + "\n";
                richTextBoxIST.Text += i;
                textBox1.Text = r.ToString();
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonasin_Click(object sender, EventArgs e) // asin
        {
            try
            {
                p = double.Parse(textBox1.Text);
                double radijan = 0;
                radijan = Math.Asin(p);
                r = radijan;
                if (radioButtonDEG.Checked == true)
                {
                    r = radijan * 180 / Math.PI;//Pretvaram u stepene
                }
                i = "arcsin(" + p + ") = " + r + "\n";
                richTextBoxIST.Text += i;
                textBox1.Text = r.ToString();
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonacos_Click(object sender, EventArgs e) // acos
        {
            try
            {
                p = double.Parse(textBox1.Text);
                double radijan = 0;
                radijan = Math.Acos(p);
                r = radijan;
                if (radioButtonDEG.Checked == true)
                {
                    r = radijan * 180 / Math.PI;//Pretvaram u stepene
                }
                i = "arccos(" + p + ") = " + r + "\n";
                richTextBoxIST.Text += i;
                textBox1.Text = r.ToString();
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonatan_Click(object sender, EventArgs e) // atan
        {
            try
            {
                p = double.Parse(textBox1.Text);
                double radijan = 0;
                radijan = Math.Atan(p);
                r = radijan;
                if (radioButtonDEG.Checked == true)
                {
                    r = radijan * 180 / Math.PI;//Pretvaram u stepene
                }
                i = "arctan(" + p + ") = " + r + "\n";
                richTextBoxIST.Text += i;
                textBox1.Text = r.ToString();
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonlogx_Click(object sender, EventArgs e) // log(n1)=n2
        {
            try
            {
                p = double.Parse(textBox1.Text);
                textBox1.Text = "";
                o = "l";
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonround_Click(object sender, EventArgs e) // zaokruzuje
        {
            try
            {
                p = double.Parse(textBox1.Text);
                textBox1.Text = "";
                o = "z";
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonprocenat_Click(object sender, EventArgs e) //mod
        {
            try
            {
                p = double.Parse(textBox1.Text);
                textBox1.Text = "";
                o = "m";
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonrnd_Click(object sender, EventArgs e) // random
        {
            try
            {
                try
                {
                    r1 = int.Parse(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox1.Text = "";
                o = "r";
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region konverzija
        private void buttonconvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && Convert.ToInt64(textBox1.Text) >= 0)
                {
                    long dec = Convert.ToInt64(textBox1.Text);
                    textBoxBIN.Text = "";
                    textBoxOCT.Text = "";
                    textBoxHEX.Text = "";
                    long bin, oct, hex;
                    long decb = dec; //>bin
                    long deco = dec; //>oct
                    long dech = dec; //>hex
                    string hexs;
                    //bin
                    while (decb > 0)
                    {
                        bin = decb % 2;
                        decb /= 2;
                        textBoxBIN.Text = bin.ToString() + textBoxBIN.Text;
                    }
                    decb = dec;
                    bin = 0;
                    //oct
                    while (deco > 0)
                    {
                        oct = deco % 8;
                        deco /= 8;
                        textBoxOCT.Text = oct.ToString() + textBoxOCT.Text;
                    }
                    deco = dec;
                    oct = 0;
                    //hex
                    while (dech > 0)
                    {
                        hex = dech % 16;
                        dech /= 16;
                        switch (hex)
                        {
                            case 10:
                                hexs = "A";
                                textBoxHEX.Text = hexs + textBoxHEX.Text;
                                break;
                            case 11:
                                hexs = "B";
                                textBoxHEX.Text = hexs + textBoxHEX.Text;
                                break;
                            case 12:
                                hexs = "C";
                                textBoxHEX.Text = hexs + textBoxHEX.Text;
                                break;
                            case 13:
                                hexs = "D";
                                textBoxHEX.Text = hexs + textBoxHEX.Text;
                                break;
                            case 14:
                                hexs = "E";
                                textBoxHEX.Text = hexs + textBoxHEX.Text;
                                break;
                            case 15:
                                hexs = "F";
                                textBoxHEX.Text = hexs + textBoxHEX.Text;
                                break;
                            default:
                                textBoxHEX.Text = hex.ToString() + textBoxHEX.Text;
                                break;
                        }
                    }
                    dech = dec;
                    hex = 0;
                    if (dec == 0)
                    {
                        textBoxBIN.Text = "0";
                        textBoxOCT.Text = "0";
                        textBoxHEX.Text = "0";
                    }
                    richTextBoxIST.Text += "Convert " + dec + "\n";
                }
                else
                {
                    MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Unos nije u dobrom formatu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region podaplikacije
        Form f;
        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e) // uputstvo
        {
            //MessageBox.Show("Unos brojeva je moguć preko tastature ili preko ugrađenih dugmića na aplikaciji. Nakon unosa broja, izaberite željenu operaciju, ili, ako je potrebno, upišite još jedan broj pa kliknite dugme '='.\nKliknite na dugme 'Podaplikacije' da dobijete listu svih podaplikacija ovog kalkulatora i otvorite onu koja vam treba.", "Uputstvo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            Uput.Tekst = "Glavna aplikacija";
            f = new Uputstvo()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.ShowDialog();
        }
        
        private void verzijaToolStripMenuItem_Click(object sender, EventArgs e) // verzija
        {
            //MessageBox.Show("Kalkulator\nTrenutna verzija: 02.03.2023.\nPrva verzija: 21.11.2022.\nAutor: Luka Stefanović", "Verzija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f = new Info()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.Show();
        }

        private void X3SistemToolStripMenuItem_Click(object sender, EventArgs e) //sistemi
        {
            f = new SisKal()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.Show();
        }

        private void kvadratnaJednačinaToolStripMenuItem_Click(object sender, EventArgs e) //kvadratne jednacine
        {
            f = new KvadKal()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.Show();
        }

        private void analitikaTačkeToolStripMenuItem1_Click(object sender, EventArgs e) //tacka
        {
            f = new AnTac()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.Show();
        }

        private void analitikaPraveToolStripMenuItem1_Click(object sender, EventArgs e) //prava
        {
            f = new AnPrav()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.Show();
        }

        private void dužinaToolStripMenuItem_Click(object sender, EventArgs e) //duzina
        {
            f = new DuzKal()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.Show();
        }

        private void masaToolStripMenuItem_Click(object sender, EventArgs e) //masa
        {
            f = new MasKal()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.Show();
        }

        private void ugaoToolStripMenuItem_Click(object sender, EventArgs e) //ugao
        {
            f = new UglKal()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.Show();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e) //temperatura
        {
            f = new TempKal()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.Show();
        }

        private void kompleksniBrojToolStripMenuItem_Click(object sender, EventArgs e) //kompleksni brojevi
        {
            f = new KompKal()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.Show();
        }

        private void logičkeOperacijeToolStripMenuItem_Click(object sender, EventArgs e) //logicke operacije
        {
            f = new LogKal()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.Show();
        }

        private void kružnicaToolStripMenuItem_Click(object sender, EventArgs e) //kruznica
        {
            f = new Kruz()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            f.Show();
        }
        #endregion
        #region otvaranje i cuvanje istorije
        readonly string path = @"istorija.txt";
        private void sačuvajIstorijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime danasnjiDan = DateTime.Now;
            File.AppendAllText(path, danasnjiDan + "\n\n" + richTextBoxIST.Text + "\n\n-kraj\n\n");
            MessageBox.Show("Istorija uspešno sačuvana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void očistiFajlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Jeste li sigurni da želite da resetujete datoteku?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rez == DialogResult.Yes)
            {
                File.WriteAllText(path, "-----Ovde se cuva istorija-----\n\n\n\n\n");
                MessageBox.Show("Istorija uspešno obrisana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void otvoriFajlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"notepad.exe", path);
        }
        #endregion
    }
}