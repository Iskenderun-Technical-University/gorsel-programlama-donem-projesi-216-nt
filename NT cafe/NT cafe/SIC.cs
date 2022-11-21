using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT_cafe
{
    public partial class SIC : Form
    {
        int x;
        public SIC()
        {
            InitializeComponent();
        }

        private void SIC_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(x > 1)
            {
                x = int.Parse(label3.Text);
                x--;
                label3.Text = Convert.ToString(x);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(label3.Text);
            x++;
            label3.Text = Convert.ToString(x);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(label4.Text);
            x++;
            label4.Text = Convert.ToString(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if(x > 1)
            {
                x = int.Parse(label4.Text);
                x--;
                label4.Text = Convert.ToString(x);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(label7.Text);
            x++;
            label7.Text = Convert.ToString(x);
        }

        private void button5_Click(object sender, EventArgs e)
        {
             if(x > 1)
            {
                x = int.Parse(label7.Text);
                x--;
                label7.Text = Convert.ToString(x);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(label10.Text);
            x++;
            label10.Text = Convert.ToString(x);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(label13.Text);
            x++;
            label13.Text = Convert.ToString(x);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
             if(x > 1)
            {
                x = int.Parse(label10.Text);
                x--;
                label10.Text = Convert.ToString(x);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
             if(x > 1)
            {
                x = int.Parse(label13.Text);
                x--;
                label13.Text = Convert.ToString(x);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(label16.Text);
            x++;
            label16.Text = Convert.ToString(x);
        }

        private void button11_Click(object sender, EventArgs e)
        {
             if(x > 1)
            {
                x = int.Parse(label16.Text);
                x--;
                label16.Text = Convert.ToString(x);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
