namespace MSMSGUI
{
    partial class Splash
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
            this.HProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.VProgressBar = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblMobileShop = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HProgressBar
            // 
            this.HProgressBar.Location = new System.Drawing.Point(-1, 452);
            this.HProgressBar.Name = "HProgressBar";
            this.HProgressBar.ProgressColor = System.Drawing.Color.Silver;
            this.HProgressBar.ProgressColor2 = System.Drawing.Color.Silver;
            this.HProgressBar.Size = new System.Drawing.Size(830, 25);
            this.HProgressBar.TabIndex = 0;
            this.HProgressBar.Text = "guna2ProgressBar1";
            this.HProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // VProgressBar
            // 
            this.VProgressBar.Location = new System.Drawing.Point(48, 0);
            this.VProgressBar.Name = "VProgressBar";
            this.VProgressBar.ProgressColor = System.Drawing.Color.Silver;
            this.VProgressBar.ProgressColor2 = System.Drawing.Color.Silver;
            this.VProgressBar.Size = new System.Drawing.Size(25, 538);
            this.VProgressBar.TabIndex = 1;
            this.VProgressBar.Text = "guna2VProgressBar1";
            this.VProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.Black;
            this.lblSystem.Location = new System.Drawing.Point(361, 128);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(113, 33);
            this.lblSystem.TabIndex = 44;
            this.lblSystem.Text = "System";
            // 
            // lblMobileShop
            // 
            this.lblMobileShop.AutoSize = true;
            this.lblMobileShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileShop.ForeColor = System.Drawing.Color.Black;
            this.lblMobileShop.Location = new System.Drawing.Point(249, 87);
            this.lblMobileShop.Name = "lblMobileShop";
            this.lblMobileShop.Size = new System.Drawing.Size(345, 33);
            this.lblMobileShop.TabIndex = 43;
            this.lblMobileShop.Text = "MobileShop Management";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MSMSGUI.Properties.Resources.store;
            this.pictureBox1.Location = new System.Drawing.Point(336, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(827, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.lblMobileShop);
            this.Controls.Add(this.VProgressBar);
            this.Controls.Add(this.HProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar HProgressBar;
        private Guna.UI2.WinForms.Guna2VProgressBar VProgressBar;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblMobileShop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
    }
}

