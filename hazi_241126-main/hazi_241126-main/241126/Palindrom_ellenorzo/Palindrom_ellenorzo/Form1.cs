using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindrom_ellenorzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            if (Palindrom(input))
            {
                lblResult.Text = "A szöveg palindróm.";
            }
            else
            {
                lblResult.Text = "A szöveg nem palindróm.";
            }
        }

        private bool Palindrom(string text)
        {
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
