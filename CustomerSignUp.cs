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
    public partial class CustomerSignUp : UserControl
    {
        public CustomerSignUp()
        {
            InitializeComponent();
        }

        private void LinkLblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerSignIn customerSignIn = new CustomerSignIn();
            Panel.Controls.Clear();
            Panel.Controls.Add(customerSignIn);
        }
    }
}
