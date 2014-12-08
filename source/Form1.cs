using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double disc = Math.Pow(Convert.ToDouble(b.Text), 2) - 4 * Convert.ToDouble(a.Text) * Convert.ToDouble(c.Text);

            if (disc >= 0 && Convert.ToDouble(a.Text) > 0)
            {
                label6.Text = "A megoldás:";
                label6.Visible = true;

                lx1.Visible = true;
                lx2.Visible = true;

                x1.Visible = true;
                x2.Visible = true;

                x1.Text = ((-Convert.ToDouble(b.Text) + Math.Sqrt(disc)) / (2 * Convert.ToDouble(a.Text))).ToString();
                x2.Text = ((-Convert.ToDouble(b.Text) - Math.Sqrt(disc)) / (2 * Convert.ToDouble(a.Text))).ToString();
            }
            else
            {
                label6.Text = "Nincs megoldása az egyenletnek mivel a gyök alatt mínusz szám áll, és/vagy az A éréke kisseebb mint 0!";
                label6.Visible = true;
            }

            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            a.Text = "";
            b.Text = "";
            c.Text = "";
            x1.Text = "";
            x2.Text = "";

            lx1.Visible = false;
            lx2.Visible = false;

            x1.Visible = false;
            x2.Visible = false;

            button2.Visible = false;
        }
    }
}
