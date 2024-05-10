using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;

namespace EPE
{
    public partial class EmployeeDashboard : MaterialForm
    {
        public int id;
        public EmployeeDashboard(int id)
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
            this.id = id;

            //show name
            materialSingleLineTextField1.Text = fName();
            materialSingleLineTextField3.Text = ratting().ToString();
            materialSingleLineTextField2.Text =  depName();



        }
    

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        public string fName()
        {
            string fn = "";
            var con = Configuration.getInstance().getConnection();
            con.Open();
            string query = "select Full_name from employee where Employee.Empl_id = @empId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@empId", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                fn = reader.GetString(0);
            }
            reader.Close();
            return fn;
        }

        public double ratting()
        {
            int ratting = 0;
            var con = Configuration.getInstance().getConnection();
            string query = "select avg(rating) from Evaluation where Employee_id = @empId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@empId", id);
             ratting = Convert.ToInt32(cmd.ExecuteScalar());
            return ratting;
        }

        public string depName()
        {
            string fn = "";
            var con = Configuration.getInstance().getConnection();
            string query = "select Department.Department_name from Department inner join Employee on Employee.Department_id = Department.dep_id where Employee.Empl_id = @empId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@empId", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                fn = reader.GetString(0);
            }
            reader.Close();
            return fn;
        }
    }


}
