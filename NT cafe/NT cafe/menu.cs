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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        public void Loadform(object Form)
        {
            if (this.anapanel.Controls.Count > 0)
                this.anapanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.anapanel.Controls.Add(f);
            this.anapanel.Tag = f;
            f.Show();

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Loadform(Program.sicak);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Loadform(Program.soguk);
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click_1(object sender, EventArgs e)
        {
            Loadform(Program.ord);
        }
    }
}
