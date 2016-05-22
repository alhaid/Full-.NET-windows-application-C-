using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Ov : Form
    {
        public Ov()
        {
            InitializeComponent();
            Oven ov = new Oven();
            listBoxOven.Items.Add(ov.pop() + "  Cup popcorn kernels");
            listBoxOven.Items.Add(ov.salt() + "  Teaspoon kosher salt");
            listBoxOven.Items.Add(ov.butter() + "  Tablespoons unsalted butter");
            listBoxOven.Items.Add(ov.cheesef() + "  Tablespoons cheese flavour");
            listBoxOven.Items.Add(ov.degree() + "  Degrees Fahrenheit");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OvPicture op = new OvPicture();
            op.ShowDialog();
        }
    }
}
