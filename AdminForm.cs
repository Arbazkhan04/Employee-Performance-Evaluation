using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMSGUI.GUI.Main
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnPersonalInfo_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnEmployeesInfo_Click(object sender, EventArgs e)
        {
            adminEmployees1.BringToFront();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            adminProducts1.BringToFront();
        }

        private void BtnBudget_Click(object sender, EventArgs e)
        {
            customerProducts1.BringToFront();
        }
    }
}
