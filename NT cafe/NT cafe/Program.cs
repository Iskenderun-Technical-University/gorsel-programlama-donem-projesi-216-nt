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
            SIC sicak = new SIC();
            soguk = new sok();  
            Application.Run(new Form1());
        }
    }
}
