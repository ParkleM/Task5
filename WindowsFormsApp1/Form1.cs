using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool _leftMove = true;
        private bool _upMove = true;
        int speed = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += _leftMove ? speed : -speed;
            pictureBox1.Top += _upMove ? speed : -speed;
            if (pictureBox1.Left <= ClientRectangle.Left)
                _leftMove = true;
            if (pictureBox1.Right >= ClientRectangle.Right)
                _leftMove = false;
            if (pictureBox1.Top <= ClientRectangle.Top)
                _upMove = true;
            if (pictureBox1.Bottom >= ClientRectangle.Bottom)
                _upMove = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speed = Convert.ToInt32(textBox1.Text);
        }
    }
}
