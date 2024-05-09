using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSMSGUI.GUI;
using MSMSGUI.GUI.Main;

namespace MSMSGUI
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
        int startPoint = 0;
        private void timer_tick(object sender, EventArgs e)
        {
            startPoint++;
            VProgressBar.Value = startPoint;
            HProgressBar.Value = startPoint;
            if (HProgressBar.Value == 100 && VProgressBar.Value == 100)
            {
                VProgressBar.Value = startPoint;
                HProgressBar.Value = startPoint;

                this.Hide();
                timer.Stop();
                GUI.Main.MainMenu menu = new GUI.Main.MainMenu();
                menu.Show();

            }
        }
    }
}
