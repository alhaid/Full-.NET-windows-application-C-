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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            microwave();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            oven();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            numPeople.Enabled = true;
        }

        private void microwaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            microwave();
        }

        private void microwaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            microwave();
        }

        public void microwave() {
            int num;
            if (int.TryParse(numPeople.Text, out num))
            {
                double popcorn = num * 0.25;
                double butter = num * 2;
                double salt = num * 0.75;
                double chessef = num * 1;

                Microwave mic = new Microwave(popcorn, butter, salt, chessef);

                this.Hide();
                Mic f3 = new Mic();
                f3.ShowDialog();
            }
            else {
                MessageBox.Show("Must be a number", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void oven()
        {
            int num;
            if (int.TryParse(numPeople.Text, out num))
            {
                double popcorn = num * 0.25;
                double butter = num * 2;
                double salt = num * 0.75;
                double chessef = num * 1;
                int degree = 450;

                Oven mic = new Oven(popcorn, butter, salt, chessef, degree);

                this.Hide();
                Ov f4 = new Ov();
                f4.ShowDialog();
            }
            else
            {
                MessageBox.Show("Must be a number", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info info = new Info();
            info.ShowDialog();
        }

        private void ovenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oven();
        }

        private void ovenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            oven();
        }

    }
}
