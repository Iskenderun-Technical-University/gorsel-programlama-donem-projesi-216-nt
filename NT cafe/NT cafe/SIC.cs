using Microsoft.Win32;
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
        int x,z;
        public string[] date = new string[3];
        
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
            if(x > 0)
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
             if(x > 0)
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
             if(x > 0)
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
             if(x > 0)
            {
                x = int.Parse(label10.Text);
                x--;
                label10.Text = Convert.ToString(x);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
             if(x > 0)
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
             if(x > 0)
            {
                x = int.Parse(label16.Text);
                x--;
                label16.Text = Convert.ToString(x);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(label4.Text) > 0)
            {
                z = Convert.ToInt32(label5.Text.Replace("TL", " ")) * Int32.Parse(label4.Text);
                x = z + Int32.Parse(Program.ord.toplam.Text);
                Program.ord.toplam.Text = Convert.ToString(x);

                date[0] = label6.Text;
                date[1] = label4.Text;
                date[2] = label5.Text.Replace("TL", " ");
                Program.ord.data.Rows.Add(date);
                label4.Text = "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(label7.Text) > 0)
            {
                z = Convert.ToInt32(label8.Text.Replace("TL", " "))  * Int32.Parse(label7.Text);
                x = z + Int32.Parse(Program.ord.toplam.Text);
                Program.ord.toplam.Text = Convert.ToString(x);

                date[0] = label9.Text; 
                date[1] = label7.Text; 
                date[2] = label8.Text.Replace("TL", " ");  
                Program.ord.data.Rows.Add(date);
                label7.Text = "0";  
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(label10.Text) > 0) // ad
            {
                z = Convert.ToInt32(label11.Text.Replace("TL", " ")) * Int32.Parse(label10.Text);
                x = z + Int32.Parse(Program.ord.toplam.Text);
                Program.ord.toplam.Text = Convert.ToString(x);

                date[0] = label12.Text; // name
                date[1] = label10.Text; //adet
                date[2] = label11.Text.Replace("TL", " "); //price
                Program.ord.data.Rows.Add(date);
                label10.Text = "0"; //ad
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(label13.Text) > 0) // ad
            {
                z = Convert.ToInt32(label14.Text.Replace("TL", " ")) * Int32.Parse(label13.Text);
                x = z + Int32.Parse(Program.ord.toplam.Text);
                Program.ord.toplam.Text = Convert.ToString(x);

                date[0] = label15.Text; // name
                date[1] = label13.Text; //adet
                date[2] = label14.Text.Replace("TL", " "); //price
                Program.ord.data.Rows.Add(date);
                label13.Text = "0"; //ad
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(label16.Text) > 0) // ad
            {
                z = Convert.ToInt32(label17.Text.Replace("TL", " ")) * Int32.Parse(label16.Text);
                x = z + Int32.Parse(Program.ord.toplam.Text);
                Program.ord.toplam.Text = Convert.ToString(x);

                date[0] = label18.Text; // name
                date[1] = label16.Text; //adet
                date[2] = label17.Text.Replace("TL", " "); //price
                Program.ord.data.Rows.Add(date);
                label16.Text = "0"; //ad
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            if (Int32.Parse(label3.Text) > 0)
            {
               
                z = Convert.ToInt32(label2.Text.Replace("TL", " ")) * Int32.Parse(label3.Text);
                /* if (Program.ord.toplam.Text == "0")
                 {
                     z = 0;
                     z += Int32.Parse(label3.Text);
                 }*/
                x = z + Int32.Parse( Program.ord.toplam.Text);
                Program.ord.toplam.Text = Convert.ToString(x);
                
                date[0] = label1.Text;
                date[2] = label2.Text.Replace("TL", " ");
                date[1] = label3.Text;
                Program.ord.data.Rows.Add(date);
                label3.Text = "0";
            }
                

        }
    }
}
