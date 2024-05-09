namespace MSMSGUI.GUI.Main
{
    partial class MainMenu
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
            this.MainMenuRightPnl = new System.Windows.Forms.Panel();
            this.ControlBoxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAdmin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnEmployee = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnCustomer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnInfo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainMenuRightPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuRightPnl
            // 
            this.MainMenuRightPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuRightPnl.Controls.Add(this.ControlBoxMinimize);
            this.MainMenuRightPnl.Controls.Add(this.ControlBoxClose);
            this.MainMenuRightPnl.Location = new System.Drawing.Point(221, 0);
            this.MainMenuRightPnl.Name = "MainMenuRightPnl";
            this.MainMenuRightPnl.Size = new System.Drawing.Size(608, 538);
            this.MainMenuRightPnl.TabIndex = 20;
            this.MainMenuRightPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenuRightPnl_Paint);
            // 
            // ControlBoxMinimize
            // 
            this.ControlBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ControlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlBoxMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ControlBoxMinimize.IconColor = System.Drawing.Color.White;
            this.ControlBoxMinimize.Location = new System.Drawing.Point(516, 3);
            this.ControlBoxMinimize.Name = "ControlBoxMinimize";
            this.ControlBoxMinimize.PressedColor = System.Drawing.Color.Red;
            this.ControlBoxMinimize.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxMinimize.TabIndex = 1;
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ControlBoxClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ControlBoxClose.IconColor = System.Drawing.Color.White;
            this.ControlBoxClose.Location = new System.Drawing.Point(560, 3);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.PressedColor = System.Drawing.Color.Red;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MSMSGUI.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(46, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdmin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdmin.FillColor = System.Drawing.Color.Empty;
            this.BtnAdmin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.BtnAdmin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.BtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin.ForeColor = System.Drawing.Color.Black;
            this.BtnAdmin.Image = global::MSMSGUI.Properties.Resources.user;
            this.BtnAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAdmin.Location = new System.Drawing.Point(3, 218);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(219, 47);
            this.BtnAdmin.TabIndex = 2;
            this.BtnAdmin.Text = "   Admin";
            this.BtnAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.BtnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEmployee.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEmployee.FillColor = System.Drawing.Color.Empty;
            this.BtnEmployee.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.BtnEmployee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.BtnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployee.ForeColor = System.Drawing.Color.Black;
            this.BtnEmployee.Image = global::MSMSGUI.Properties.Resources.employees;
            this.BtnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEmployee.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnEmployee.Location = new System.Drawing.Point(3, 261);
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.Size = new System.Drawing.Size(219, 47);
            this.BtnEmployee.TabIndex = 3;
            this.BtnEmployee.Text = "  Employee";
            this.BtnEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.BtnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCustomer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCustomer.FillColor = System.Drawing.Color.Empty;
            this.BtnCustomer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.BtnCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.BtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomer.ForeColor = System.Drawing.Color.Black;
            this.BtnCustomer.Image = global::MSMSGUI.Properties.Resources.customer;
            this.BtnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCustomer.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnCustomer.Location = new System.Drawing.Point(3, 304);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(220, 47);
            this.BtnCustomer.TabIndex = 4;
            this.BtnCustomer.Text = "  Customer";
            this.BtnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.BackColor = System.Drawing.Color.Transparent;
            this.BtnInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnInfo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnInfo.FillColor = System.Drawing.Color.Empty;
            this.BtnInfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.BtnInfo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.BtnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInfo.ForeColor = System.Drawing.Color.Black;
            this.BtnInfo.Image = global::MSMSGUI.Properties.Resources.about;
            this.BtnInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnInfo.ImageSize = new System.Drawing.Size(25, 30);
            this.BtnInfo.Location = new System.Drawing.Point(3, 346);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(219, 47);
            this.BtnInfo.TabIndex = 5;
            this.BtnInfo.Text = "  Info";
            this.BtnInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Home";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Location = new System.Drawing.Point(221, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(573, 514);
            this.guna2GradientPanel1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.guna2GradientPanel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BtnInfo);
            this.panel1.Controls.Add(this.BtnCustomer);
            this.panel1.Controls.Add(this.BtnEmployee);
            this.panel1.Controls.Add(this.BtnAdmin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 541);
            this.panel1.TabIndex = 19;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(827, 538);
            this.Controls.Add(this.MainMenuRightPnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MainMenuRightPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainMenuRightPnl;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAdmin;
        private Guna.UI2.WinForms.Guna2GradientButton BtnEmployee;
        private Guna.UI2.WinForms.Guna2GradientButton BtnCustomer;
        private Guna.UI2.WinForms.Guna2GradientButton BtnInfo;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}