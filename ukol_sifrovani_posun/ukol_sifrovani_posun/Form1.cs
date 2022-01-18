using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_sifrovani_posun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                int posun = Int32.Parse(textBox2.Text);
                string lolec = "";
                foreach (char lol in input)
                {
                    if (lol >= 'A' && lol <= 'Z')
                    {
                        if (lol + posun > 'Z') { lolec += (char)(lol + posun - 26); }
                        else
                        {
                            lolec += (char)(lol + posun);
                        }
                    }
                    else if (lol >= 'a' && lol <= 'z')
                    {
                        if (lol + posun > 'z') { lolec += (char)(lol + posun - 26); }
                        else
                        {
                            lolec += (char)(lol + posun);
                        }
                    }
                    else
                    {
                        lolec += lol;
                    }
                }
                label3.Text = lolec;
            }
            catch
            {
                MessageBox.Show("Nezadal jsi žádnou nebo špatnou hodnotu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }
    }
}
    
