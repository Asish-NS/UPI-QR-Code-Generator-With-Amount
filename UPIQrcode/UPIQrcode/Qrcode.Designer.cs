namespace UPIQrcode
{
    partial class Qrcode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.qrpic = new System.Windows.Forms.PictureBox();
            this.qrcodegenerator_tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qrpic)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(66, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Sample QR Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qrpic
            // 
            this.qrpic.Location = new System.Drawing.Point(369, 26);
            this.qrpic.Name = "qrpic";
            this.qrpic.Size = new System.Drawing.Size(353, 292);
            this.qrpic.TabIndex = 2;
            this.qrpic.TabStop = false;
            // 
            // qrcodegenerator_tmr
            // 
            this.qrcodegenerator_tmr.Interval = 2;
            this.qrcodegenerator_tmr.Tick += new System.EventHandler(this.qrcodegenerator_tmr_Tick);
            // 
            // Qrcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qrpic);
            this.Controls.Add(this.button1);
            this.Name = "Qrcode";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Qrcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox qrpic;
        private System.Windows.Forms.Timer qrcodegenerator_tmr;
    }
}

