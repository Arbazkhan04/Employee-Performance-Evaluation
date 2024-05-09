namespace MSMSGUI.GUI.Main
{
    partial class AdminForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.BtnBudget = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnProducts = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnEmployeesInfo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnPersonalInfo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.adminProducts1 = new MSMSGUI.GUI.Panels.AdminProducts();
            this.adminEmployees1 = new MSMSGUI.GUI.Panels.AdminEmployees();
            this.customerProducts1 = new MSMSGUI.GUI.Panels.CustomerProducts();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.pnlLeft.Controls.Add(this.pnlRight);
            this.pnlLeft.Controls.Add(this.guna2GradientPanel1);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.BtnBudget);
            this.pnlLeft.Controls.Add(this.BtnProducts);
            this.pnlLeft.Controls.Add(this.BtnEmployeesInfo);
            this.pnlLeft.Controls.Add(this.BtnPersonalInfo);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Location = new System.Drawing.Point(-1, -1);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(287, 663);
            this.pnlLeft.TabIndex = 18;
            // 
            // pnlRight
            // 
            this.pnlRight.Location = new System.Drawing.Point(289, 4);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(815, 662);
            this.pnlRight.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MSMSGUI.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(61, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Location = new System.Drawing.Point(295, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(764, 633);
            this.guna2GradientPanel1.TabIndex = 16;
            // 
            // BtnBudget
            // 
            this.BtnBudget.BackColor = System.Drawing.Color.Transparent;
            this.BtnBudget.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBudget.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBudget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBudget.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBudget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBudget.FillColor = System.Drawing.Color.Empty;
            this.BtnBudget.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.BtnBudget.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.BtnBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBudget.ForeColor = System.Drawing.Color.Black;
            this.BtnBudget.Image = global::MSMSGUI.Properties.Resources.money;
            this.BtnBudget.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnBudget.ImageSize = new System.Drawing.Size(25, 30);
            this.BtnBudget.Location = new System.Drawing.Point(4, 415);
            this.BtnBudget.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBudget.Name = "BtnBudget";
            this.BtnBudget.Size = new System.Drawing.Size(292, 58);
            this.BtnBudget.TabIndex = 5;
            this.BtnBudget.Text = "  Group";
            this.BtnBudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnBudget.Click += new System.EventHandler(this.BtnBudget_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.BackColor = System.Drawing.Color.Transparent;
            this.BtnProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnProducts.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnProducts.FillColor = System.Drawing.Color.Empty;
            this.BtnProducts.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.BtnProducts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.BtnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducts.ForeColor = System.Drawing.Color.Black;
            this.BtnProducts.Image = global::MSMSGUI.Properties.Resources.products;
            this.BtnProducts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnProducts.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnProducts.Location = new System.Drawing.Point(4, 363);
            this.BtnProducts.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(292, 58);
            this.BtnProducts.TabIndex = 4;
            this.BtnProducts.Text = "  Evaluation";
            this.BtnProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnEmployeesInfo
            // 
            this.BtnEmployeesInfo.BackColor = System.Drawing.Color.Transparent;
            this.BtnEmployeesInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEmployeesInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEmployeesInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEmployeesInfo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEmployeesInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEmployeesInfo.FillColor = System.Drawing.Color.Empty;
            this.BtnEmployeesInfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.BtnEmployeesInfo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.BtnEmployeesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployeesInfo.ForeColor = System.Drawing.Color.Black;
            this.BtnEmployeesInfo.Image = global::MSMSGUI.Properties.Resources.EmployeesInfo;
            this.BtnEmployeesInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEmployeesInfo.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnEmployeesInfo.Location = new System.Drawing.Point(4, 310);
            this.BtnEmployeesInfo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEmployeesInfo.Name = "BtnEmployeesInfo";
            this.BtnEmployeesInfo.Size = new System.Drawing.Size(292, 58);
            this.BtnEmployeesInfo.TabIndex = 3;
            this.BtnEmployeesInfo.Text = "  Employee\'s Info";
            this.BtnEmployeesInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEmployeesInfo.Click += new System.EventHandler(this.BtnEmployeesInfo_Click);
            // 
            // BtnPersonalInfo
            // 
            this.BtnPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.BtnPersonalInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPersonalInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPersonalInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPersonalInfo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPersonalInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPersonalInfo.FillColor = System.Drawing.Color.Empty;
            this.BtnPersonalInfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.BtnPersonalInfo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.BtnPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonalInfo.ForeColor = System.Drawing.Color.Black;
            this.BtnPersonalInfo.Image = global::MSMSGUI.Properties.Resources.personalInfo;
            this.BtnPersonalInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPersonalInfo.Location = new System.Drawing.Point(4, 257);
            this.BtnPersonalInfo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPersonalInfo.Name = "BtnPersonalInfo";
            this.BtnPersonalInfo.Size = new System.Drawing.Size(292, 58);
            this.BtnPersonalInfo.TabIndex = 2;
            this.BtnPersonalInfo.Text = "Personal Info";
            this.BtnPersonalInfo.Click += new System.EventHandler(this.BtnPersonalInfo_Click);
            // 
            // adminProducts1
            // 
            this.adminProducts1.Location = new System.Drawing.Point(294, -1);
            this.adminProducts1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminProducts1.Name = "adminProducts1";
            this.adminProducts1.Size = new System.Drawing.Size(811, 662);
            this.adminProducts1.TabIndex = 20;
            // 
            // adminEmployees1
            // 
            this.adminEmployees1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.adminEmployees1.Location = new System.Drawing.Point(294, -1);
            this.adminEmployees1.Margin = new System.Windows.Forms.Padding(4);
            this.adminEmployees1.Name = "adminEmployees1";
            this.adminEmployees1.Size = new System.Drawing.Size(811, 662);
            this.adminEmployees1.TabIndex = 19;
            // 
            // customerProducts1
            // 
            this.customerProducts1.Location = new System.Drawing.Point(294, -1);
            this.customerProducts1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerProducts1.Name = "customerProducts1";
            this.customerProducts1.Size = new System.Drawing.Size(811, 650);
            this.customerProducts1.TabIndex = 21;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1103, 662);
            this.Controls.Add(this.customerProducts1);
            this.Controls.Add(this.adminProducts1);
            this.Controls.Add(this.adminEmployees1);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton BtnBudget;
        private Guna.UI2.WinForms.Guna2GradientButton BtnProducts;
        private Guna.UI2.WinForms.Guna2GradientButton BtnEmployeesInfo;
        private Guna.UI2.WinForms.Guna2GradientButton BtnPersonalInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlRight;
        private Panels.AdminEmployees adminEmployees1;
        private Panels.AdminProducts adminProducts1;
        private Panels.CustomerProducts customerProducts1;
    }
}