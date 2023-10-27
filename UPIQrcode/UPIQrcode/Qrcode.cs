using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace UPIQrcode
{
    public partial class Qrcode : Form
    {
        int timertrigger = 0;
        public Qrcode()
        {

            InitializeComponent();
            //qrcodegenerator_tmr.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();            
            string upistring = "upi://pay?pa=UPI Address@ybl&pn=UPINAME&tn=Testing&am=100&cu=INR"; 
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(upistring, QRCodeGenerator.ECCLevel.L);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(5);            
            qrpic.Image = qrCodeImage;
        }

        private void qrcodegenerator_tmr_Tick(object sender, EventArgs e)
        {
            if (timertrigger == 0)
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                //string upistring = "upi://pay?pa=UPI Address@ybl&pn=UPINAME&tn=Testing&am=100&cu=INR";
                string upistring = imagecredentials.qrcode_string;
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(upistring, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(5);
                qrCodeImage.Save(imagecredentials.image_path);
                
                Application.Exit();
                Application.DoEvents();
            }
            if (timertrigger == 0)
                timertrigger = 1;
            else
                timertrigger = 0;
        }

        private void Qrcode_Load(object sender, EventArgs e)
        {

        }
    }
}
