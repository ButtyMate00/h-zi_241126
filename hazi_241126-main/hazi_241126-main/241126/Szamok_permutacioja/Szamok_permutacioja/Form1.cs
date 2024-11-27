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
            try
            {
                int bemenet = int.Parse(txtInput.Text);

                    List<string> kombinaciok = new List<string>();
                    kombinacio_generalas(bemenet.ToString(), "", kombinaciok);

                    List<string> kombinacio_clear = duplikacio(kombinaciok);


                    listBoxKombinacio.Items.Clear();
                    for (int i = 0; i < kombinacio_clear.Count; i++)
                    {
                        listBoxKombinacio.Items.Add(kombinacio_clear[i]);
                    }

                    lblkombinaciocount.Text = "Kombinációk száma: " + kombinacio_clear.Count;
            }
            catch
            {
                MessageBox.Show("Kérlek csak számokat adj meg!");
                return;
            }
        }
        private void kombinacio_generalas(string bemenet, string kimenet, List<string> kombinaciok)
        {
            if (bemenet.Length == 0)
            {
                kombinaciok.Add(kimenet);
                return;
            }

            for (int i = 0; i < bemenet.Length; i++)
            {
                string ujbemenet = bemenet.Substring(0, i) + bemenet.Substring(i + 1);
                string ujkimenet = kimenet + bemenet[i];
                kombinacio_generalas(ujbemenet, ujkimenet, kombinaciok);
            }
        }

        private List<string> duplikacio(List<string> kombinaciok)
        {
            List<string> kombinacio_clear = new List<string>();

            for (int i = 0; i < kombinaciok.Count; i++)
            {
                if (!kombinacio_clear.Contains(kombinaciok[i]))
                {
                    kombinacio_clear.Add(kombinaciok[i]);
                }
            }

            return kombinacio_clear;
        }



    }
}
