using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace EPE
{
    public partial class Form1 : MaterialForm
    {
        int empId = 0;
        public Form1()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            string email = materialSingleLineTextField1.Text;
            if(email == "")
            {
                MessageBox.Show("Email is null");
            }
            else
            {
               int Id = getEmpId(email);
                MessageBox.Show("Employee ID: " + Id);

                if(Id == 8)
                {
                    // hr dashborad
                    HrDashboardForm hr = new HrDashboardForm();
                    this.Hide();
                    hr.Show();
                }
                else
                {
                    // employee dashboard
                    EmployeeDashboard emp = new EmployeeDashboard(empId);
                    this.Hide();
                    emp.Show();
                }
            }
        }

        public int getEmpId(string email)
        {
            int designationId = 0;
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT Employee.Empl_id, Employee.Designation_id FROM Person INNER JOIN Employee ON Person.id = Employee.Empl_id WHERE Person.Email = @Email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Email", email);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                empId = reader.GetInt32(0);
                designationId = reader.GetInt32(1);
            }
            reader.Close();
            con.Close();
            return designationId;

        }
    }
}
