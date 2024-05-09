using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMSGUI.GUI.Panels
{
    public partial class CustomerSignIn : UserControl
    {
        public CustomerSignIn()
        {
            InitializeComponent();
        }

     

        private void linlLblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerSignUp customerSignUp = new CustomerSignUp();
            panel.Controls.Clear();
            panel.Controls.Add(customerSignUp); 
        }
    }
}
