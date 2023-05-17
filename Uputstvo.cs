using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Uputstvo : Form
    {
        public Uputstvo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text switch
            {
                "Glavna aplikacija" => "Unos brojeva je moguć preko tastature ili preko ugrađenih dugmića na aplikaciji. Nakon unosa broja, izaberite željenu operaciju, ili, ako je potrebno, upišite još jedan broj pa kliknite dugme '='.\nKliknite na dugme 'Podaplikacije' da dobijete listu svih podaplikacija ovog kalkulatora i otvorite onu koja vam treba",
                "Kvadratne jednačine" => "Unos je moguć preko tastature. Unesite željene množioce za nepoznate, pa kliknite na dugme 'Izračunaj' da dobijete rezultate kvadratne jednačine",
                "3x3 sistem jednačina" => "Unos je moguć preko tastature. Unesite željene vrednosti u polja za množioce nepoznatih i rešenja jednačina, pa kliknite dugme 'Izračunaj' da dobijete vrednosti nepoznatih",
                "Analitika tačke" => "Unos je moguć preko tastature. Unesite x i y koordinate svih tačaka i razmeru podela svih duži (unesite 1 ako želite težišne duži) pa kliknite na dugme 'Izračunaj' da bi vam se sva rešenja ispisala",
                "Analitika prave" => "Unos je moguć preko tastature. Unesite sve potrebne vrednosti za pravu pa kliknite na dugme 'Izračunaj' da dobijete sve jednačine",
                "Analitika kružnice" => "Unos je moguć preko tastature. Unesite sve potrebne vrednosti za pravu pa kliknite na dugme 'Izračunaj' da dobijete sve potrebne rezultate",
                "Konverzija dužine" => "Unos je moguć preko tastature. Izaberite sistem jedinica, unesite željene brojeve pa kliknite dugme 'Pretvori'",
                "Konverzija mase" => "Unos je moguć preko tastature. Izaberite sistem jedinica, unesite željene brojeve pa kliknite dugme 'Pretvori'",
                "Konverzija uglova" => "Unos je moguć preko tastature. Izaberite jedinicu, unesite željenu vrednost pa kliknite na dugme 'Pretvori'",
                "Konverzija temperature" => "Unos je moguć preko tastature. Izaberite jedinicu, unesite željenu vrednost pa kliknite na dugme 'Pretvori'",
                "Kompleksni brojevi" => "Unos je moguć preko tastature. Unesite željene brojeve, izaberite operaciju pa kliknite na dugme 'Izračunaj'",
                "Logičke operacije" => "Izaberite vrednosti na levoj strani pa kliknite na željenu operaciju",
                _ => "Nepoznata podaplikacija",
            };
        }

        private void Uputstvo_Load(object sender, EventArgs e)
        {
            comboBox1.Text = Uput.Tekst;
            button1_Click(sender, e);
        }
    }
}
