using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT_cafe
{
    internal static class Program
    {
        public static Form1 frm;
        public static menu mnu;
        public static SIC sicak;
        public static sok soguk;
        public static frmORDER ord;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm = new Form1();
            mnu = new menu();
            sicak = new SIC();
            soguk = new sok();
            ord = new frmORDER();
            Application.Run(frm);
        }
    }
}
