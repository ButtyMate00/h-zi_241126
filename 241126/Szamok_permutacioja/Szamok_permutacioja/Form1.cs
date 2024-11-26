using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szamok_permutacioja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string bemenet = txtInput.Text;

            if (Szamellenorzes(bemenet))
            {
                List<string> permutaciok = new List<string>();
                GeneraldPermutaciok(bemenet, "", permutaciok);

                List<string> egyediPermutaciok = duplikacio(permutaciok);


                listBoxPermutations.Items.Clear();
                for (int i = 0; i < egyediPermutaciok.Count; i++)
                {
                    listBoxPermutations.Items.Add(egyediPermutaciok[i]);
                }

                // A kombinációk számának helyes kiszámítása

                lblCombinationCount.Text = "Kombinációk száma: " + egyediPermutaciok.Count;
            }
            else
            {
                MessageBox.Show("Kérlek csak számokat adj meg!");
            }
        }

        private bool Szamellenorzes(string bemenet)
        {
            for (int i = 0; i < bemenet.Length; i++)
            {
                if (bemenet[i] < '0' || bemenet[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }

        private void GeneraldPermutaciok(string bemenet, string kimenet, List<string> permutaciok)
        {
            if (bemenet.Length == 0)
            {
                permutaciok.Add(kimenet);
                return;
            }

            for (int i = 0; i < bemenet.Length; i++)
            {
                string ujBemenet = bemenet.Substring(0, i) + bemenet.Substring(i + 1); // Az aktuális karakter nélkül
                string ujKimenet = kimenet + bemenet[i]; // Hozzáadjuk az aktuális karaktert a kimenethez
                GeneraldPermutaciok(ujBemenet, ujKimenet, permutaciok);
            }
        }

        private List<string> duplikacio(List<string> permutaciok)
        {
            List<string> egyediPermutaciok = new List<string>();

            for (int i = 0; i < permutaciok.Count; i++)
            {
                if (!egyediPermutaciok.Contains(permutaciok[i]))
                {
                    egyediPermutaciok.Add(permutaciok[i]);
                }
            }

            return egyediPermutaciok;
        }

        // Faktoriális számítása
        private int Faktorialis(int n)
        {
            if (n == 0)
                return 1; // Alapeset: 0! = 1
            return n * Faktorialis(n - 1); // Rekurzív faktoriális számítás
        }

        // Ismétlődések faktoriálisának kiszámítása karaktertömb segítségével

    }
}
