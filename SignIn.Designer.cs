namespace MSMSGUI.GUI.Panels
{
    partial class SignIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblMobileShop = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblViewPassword = new System.Windows.Forms.Label();
            this.ToggleSwitchViewPassword = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSystem);
            this.panel1.Controls.Add(this.lblMobileShop);
            this.panel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 538);
            this.panel1.TabIndex = 0;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.Black;
            this.lblSystem.Location = new System.Drawing.Point(244, 96);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(113, 33);
            this.lblSystem.TabIndex = 33;
            this.lblSystem.Text = "System";
            // 
            // lblMobileShop
            // 
            this.lblMobileShop.AutoSize = true;
            this.lblMobileShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileShop.ForeColor = System.Drawing.Color.Black;
            this.lblMobileShop.Location = new System.Drawing.Point(132, 55);
            this.lblMobileShop.Name = "lblMobileShop";
            this.lblMobileShop.Size = new System.Drawing.Size(345, 33);
            this.lblMobileShop.TabIndex = 32;
            this.lblMobileShop.Text = "MobileShop Management";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 75;
            this.guna2CustomGradientPanel1.Controls.Add(this.txtPassword);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtUsername);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblViewPassword);
            this.guna2CustomGradientPanel1.Controls.Add(this.ToggleSwitchViewPassword);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSignIn);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblSignIn);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(148)))), ((int)(((byte)(208)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(148)))), ((int)(((byte)(208)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(148)))), ((int)(((byte)(208)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(148)))), ((int)(((byte)(208)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(169, 150);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(270, 334);
            this.guna2CustomGradientPanel1.TabIndex = 31;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(148)))), ((int)(((byte)(208)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(148)))), ((int)(((byte)(208)))));
            this.txtPassword.BorderRadius = 20;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.IconLeft = global::MSMSGUI.Properties.Resources.password;
            this.txtPassword.IconLeftSize = new System.Drawing.Size(17, 17);
            this.txtPassword.Location = new System.Drawing.Point(36, 148);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Enter Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(199, 38);
            this.txtPassword.TabIndex = 20;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(148)))), ((int)(((byte)(208)))));
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(148)))), ((int)(((byte)(208)))));
            this.txtUsername.BorderRadius = 20;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.IconLeft = global::MSMSGUI.Properties.Resources.username;
            this.txtUsername.Location = new System.Drawing.Point(36, 92);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Enter Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(199, 38);
            this.txtUsername.TabIndex = 19;
            // 
            // lblViewPassword
            // 
            this.lblViewPassword.AutoSize = true;
            this.lblViewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(148)))), ((int)(((byte)(208)))));
            this.lblViewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPassword.ForeColor = System.Drawing.Color.Black;
            this.lblViewPassword.Location = new System.Drawing.Point(78, 209);
            this.lblViewPassword.Name = "lblViewPassword";
            this.lblViewPassword.Size = new System.Drawing.Size(84, 15);
            this.lblViewPassword.TabIndex = 18;
            this.lblViewPassword.Text = "View Pasword";
            // 
            // ToggleSwitchViewPassword
            // 
            this.ToggleSwitchViewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(148)))), ((int)(((byte)(208)))));
            this.ToggleSwitchViewPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleSwitchViewPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleSwitchViewPassword.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitchViewPassword.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitchViewPassword.Location = new System.Drawing.Point(36, 203);
            this.ToggleSwitchViewPassword.Name = "ToggleSwitchViewPassword";
            this.ToggleSwitchViewPassword.Size = new System.Drawing.Size(36, 21);
            this.ToggleSwitchViewPassword.TabIndex = 17;
            this.ToggleSwitchViewPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitchViewPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitchViewPassword.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitchViewPassword.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(148)))), ((int)(((byte)(208)))));
            this.btnSignIn.BorderRadius = 18;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.btnSignIn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnSignIn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSignIn.Location = new System.Drawing.Point(79, 247);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(118, 35);
            this.btnSignIn.TabIndex = 16;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(148)))), ((int)(((byte)(208)))));
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.Black;
            this.lblSignIn.Location = new System.Drawing.Point(85, 30);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(105, 33);
            this.lblSignIn.TabIndex = 13;
            this.lblSignIn.Text = "Sign In";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.panel1);
            this.Name = "SignIn";
            this.Size = new System.Drawing.Size(608, 538);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblMobileShop;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lblViewPassword;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitchViewPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnSignIn;
        private System.Windows.Forms.Label lblSignIn;
    }
}
