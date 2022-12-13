using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT_cafe
{
    public partial class sok : Form
    {
        int x, z;
        public string[] date = new string[3];
        public sok()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(label0.Text);
            x++;
            label0.Text = Convert.ToString(x);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                x = int.Parse(label0.Text);
                x--;
                label0.Text = Convert.ToString(x);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(label20.Text);
            x++;
            label20.Text = Convert.ToString(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                x = int.Parse(label20.Text);
                x--;
                label20.Text = Convert.ToString(x);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(label23.Text);
            x++;
            label23.Text = Convert.ToString(x);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                x = int.Parse(label23.Text);
                x--;
                label23.Text = Convert.ToString(x);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(label32.Text);
            x++;
            label32.Text = Convert.ToString(x);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                x = int.Parse(label32.Text);
                x--;
                label32.Text = Convert.ToString(x);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(label21.Text);
            x++;
            label21.Text = Convert.ToString(x);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                x = int.Parse(label21.Text);
                x--;
                label21.Text = Convert.ToString(x);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(label88.Text);
            x++;
            label88.Text = Convert.ToString(x);
        }
       
private void button11_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                x = int.Parse(label88.Text);
                x--;
                label88.Text = Convert.ToString(x);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(label0.Text) > 0)  
            {
                z = Convert.ToInt32(label2.Text.Replace("TL", " ")) * Int32.Parse(label0.Text);
                x = z + Int32.Parse(Program.ord.toplam.Text);
                Program.ord.toplam.Text = Convert.ToString(x);

                date[0] = label1.Text;  
                date[1] = label0.Text;  
                date[2] = label2.Text.Replace("TL", " ");  
                Program.ord.data.Rows.Add(date);
                label0.Text = "0";  
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(label20.Text) > 0)  
            {
                z = Convert.ToInt32(label5.Text.Replace("TL", " ")) * Int32.Parse(label20.Text);
                x = z + Int32.Parse(Program.ord.toplam.Text);
                Program.ord.toplam.Text = Convert.ToString(x);

                date[0] = label6.Text;  
                date[1] = label20.Text;  
                date[2] = label5.Text.Replace("TL", " ");  
                Program.ord.data.Rows.Add(date);
                label20.Text = "0";  
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(label23.Text) > 0)  
            {
                z = Convert.ToInt32(label8.Text.Replace("TL", " ")) * Int32.Parse(label23.Text);
                x = z + Int32.Parse(Program.ord.toplam.Text);
                Program.ord.toplam.Text = Convert.ToString(x);

                date[0] = label9.Text;  
                date[1] = label23.Text;  
                date[2] = label8.Text.Replace("TL", " ");  
                Program.ord.data.Rows.Add(date);
                label23.Text = "0";  
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(label32.Text) > 0)  
            {
                z = Convert.ToInt32(label11.Text.Replace("TL", " ")) * Int32.Parse(label32.Text);
                x = z + Int32.Parse(Program.ord.toplam.Text);
                Program.ord.toplam.Text = Convert.ToString(x);

                date[0] = label12.Text;  
                date[1] = label32.Text;  
                date[2] = label11.Text.Replace("TL", " ");  
                Program.ord.data.Rows.Add(date);
                label32.Text = "0";  
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(label21.Text) > 0)  
            {
                z = Convert.ToInt32(label8.Text.Replace("TL", " ")) * Int32.Parse(label21.Text);
                x = z + Int32.Parse(Program.ord.toplam.Text);
                Program.ord.toplam.Text = Convert.ToString(x);

                date[0] = label15.Text;  
                date[1] = label21.Text;  
                date[2] = label8.Text.Replace("TL", " ");  
                Program.ord.data.Rows.Add(date);
                label21.Text = "0";  
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(label88.Text) > 0)  
            {
                z = Convert.ToInt32(label17.Text.Replace("TL", " ")) * Int32.Parse(label88.Text);
                x = z + Int32.Parse(Program.ord.toplam.Text);
                Program.ord.toplam.Text = Convert.ToString(x);

                date[0] = label18.Text;  
                date[1] = label88.Text;  
                date[2] = label17.Text.Replace("TL", " ");  
                Program.ord.data.Rows.Add(date);
                label88.Text = "0";  
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
