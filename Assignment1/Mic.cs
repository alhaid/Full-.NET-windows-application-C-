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
    public partial class Mic : Form
    {
        public Mic()
        {
            InitializeComponent();
            Microwave mic = new Microwave();
            listBox.Items.Add(mic.pop() + "  Cup popcorn kernels");
            listBox.Items.Add(mic.salt() + "  Teaspoon kosher salt");
            listBox.Items.Add(mic.butter() + "  Tablespoons unsalted butter");
            listBox.Items.Add(mic.cheesef() + "  Tablespoons cheese flavour");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MicPicture mp = new MicPicture();
            mp.ShowDialog();
        }


    }
}
