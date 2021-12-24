
namespace burcuHesaplama
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblYasadiginizGun = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBurcunuz = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblYasiniz = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğum Tarihiniz";
            // 
            // lblYasadiginizGun
            // 
            this.lblYasadiginizGun.AutoSize = true;
            this.lblYasadiginizGun.Location = new System.Drawing.Point(209, 241);
            this.lblYasadiginizGun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYasadiginizGun.Name = "lblYasadiginizGun";
            this.lblYasadiginizGun.Size = new System.Drawing.Size(0, 20);
            this.lblYasadiginizGun.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yaşınız:";
            // 
            // lblBurcunuz
            // 
            this.lblBurcunuz.AutoSize = true;
            this.lblBurcunuz.Location = new System.Drawing.Point(209, 275);
            this.lblBurcunuz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBurcunuz.Name = "lblBurcunuz";
            this.lblBurcunuz.Size = new System.Drawing.Size(0, 20);
            this.lblBurcunuz.TabIndex = 0;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(83, 77);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(254, 26);
            this.dtpDogumTarihi.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(143, 134);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(124, 35);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblYasiniz
            // 
            this.lblYasiniz.AutoSize = true;
            this.lblYasiniz.Location = new System.Drawing.Point(210, 207);
            this.lblYasiniz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYasiniz.Name = "lblYasiniz";
            this.lblYasiniz.Size = new System.Drawing.Size(0, 20);
            this.lblYasiniz.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yaşadığınız Gün:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Burcunuz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(427, 368);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBurcunuz);
            this.Controls.Add(this.lblYasiniz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblYasadiginizGun);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYasadiginizGun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBurcunuz;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblYasiniz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

