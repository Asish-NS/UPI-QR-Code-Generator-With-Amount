using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPIQrcode
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            foreach (string cmdline in args)
            {
                string[] inputdata = cmdline.Split(new string[] { "{||}" }, StringSplitOptions.None);
                imagecredentials.qrcode_string = inputdata[0].ToString();
                imagecredentials.image_path = inputdata[1].ToString();                
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Qrcode());
        }
    }
}
