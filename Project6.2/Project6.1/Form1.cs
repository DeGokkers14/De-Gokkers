using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //achter naam moet de naam komen.
            //In het blok achter player moet je je inzet kunnen invoeren van minimaal 5 tot maximaal 15.
            //De Logs knop moet naar het logs scherm gaan.
            //De Go knop is nog onbekend.
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Movement.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(pictureBox3.Location.X + 5, pictureBox3.Location.Y);
        }

        private void Movement_Tick(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X + 1, pictureBox2.Location.Y);
            pictureBox4.Location = new Point(pictureBox4.Location.X + 1, pictureBox4.Location.Y);
            pictureBox5.Location = new Point(pictureBox5.Location.X + 1, pictureBox5.Location.Y);
            pictureBox3.Location = new Point(pictureBox3.Location.X + 1, pictureBox3.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movement.Enabled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(pictureBox4.Location.X + 5, pictureBox4.Location.Y);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Location = new Point(pictureBox5.Location.X + 5, pictureBox5.Location.Y);
        }
    }
}
