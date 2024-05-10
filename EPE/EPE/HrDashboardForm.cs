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
using System.Data.SqlClient;
using System.Xml.Linq;

namespace EPE
{
    public partial class HrDashboardForm : MaterialForm
    {
        public HrDashboardForm()
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
            PopulateSupervisorIDsComboBox();
            PopulateDepartmentIDsComboBox();

            //add employee
            PopulateEmployeeIDsComboBox(comboBox4);
            PopulateEmployeeIDsComboBox(comboBox5);
            PopulateGroupIDsComboBox(comboBox3);
            PopulateGroupIDsComboBox(comboBox10);
        }

        private void HrDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            string name = materialSingleLineTextField1.Text; 
            int depId = int.Parse(comboBox1.Text);
            int supId = int.Parse(comboBox2.Text);
            DateTime date = DateTime.Parse(dateTimePicker1.Text);

            //check fields
            if (name == "" || depId == 0 || supId == 0 || date == null)
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                //insert into database
                var con = Configuration.getInstance().getConnection();
                string query = "insert into Groups (Name,Department_id,Supervisor_id,DateCreated,Status_id) values (@Name,@Department_id,@Supervisor_id,@DateCreated,@Status_id)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Department_id", depId);
                cmd.Parameters.AddWithValue("@Supervisor_id", supId);
                cmd.Parameters.AddWithValue("@DateCreated", date);
                cmd.Parameters.AddWithValue("@Status_id", 3);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("group added successfully");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PopulateSupervisorIDsComboBox()
        {

             var con = Configuration.getInstance().getConnection();
            // Define SQL query to retrieve supervisor IDs
            string query = "select Supervisor_id from Supervisor";
            con.Open();
            // Execute query
            SqlCommand command = new SqlCommand(query, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing items in the ComboBox
                            comboBox2.Items.Clear();

                            // Add each supervisor ID to the ComboBox
                            while (reader.Read())
                            {
                                // Assuming SupervisorID is of type int, adjust as needed
                                int supervisorID = Convert.ToInt32(reader["Supervisor_id"]);
                                comboBox2.Items.Add(supervisorID);
                            }
                        }
        }

        public void PopulateDepartmentIDsComboBox()
        {

            var con = Configuration.getInstance().getConnection();
            // Define SQL query to retrieve supervisor IDs
            string query = "select dep_id from Department";

            // Execute query
            SqlCommand command = new SqlCommand(query, con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // Clear existing items in the ComboBox
                comboBox1.Items.Clear();

                // Add each supervisor ID to the ComboBox
                while (reader.Read())
                {
                    // Assuming SupervisorID is of type int, adjust as needed
                    int supervisorID = Convert.ToInt32(reader["dep_id"]);
                    comboBox1.Items.Add(supervisorID);
                }
            }
        }


        // add employee start from here 
        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            
            int gid = int.Parse(comboBox3.Text);
            int empID = int.Parse(comboBox4.Text);
            DateTime date = DateTime.Parse(dateTimePicker2.Text);

            //check fields
            if (gid == 0 || empID == 0 || date == null)
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                //insert into database
                var con = Configuration.getInstance().getConnection();
                string query = "insert into GroupEmployee (Group_id,Employee_id,DateJoined) values (@Group_id,@Employee_id,@DateJoined)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Group_id", gid);
                cmd.Parameters.AddWithValue("@Employee_id", empID);
                cmd.Parameters.AddWithValue("@DateJoined", date);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee added successfully");
            }
        }

        public void PopulateEmployeeIDsComboBox(ComboBox comboBox4)
        {

            var con = Configuration.getInstance().getConnection();
            // Define SQL query to retrieve supervisor IDs
            string query = "select Empl_id from Employee";

            // Execute query
            SqlCommand command = new SqlCommand(query, con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // Clear existing items in the ComboBox
                comboBox4.Items.Clear();

                // Add each supervisor ID to the ComboBox
                while (reader.Read())
                {
                    // Assuming SupervisorID is of type int, adjust as needed
                    int empid = Convert.ToInt32(reader["Empl_id"]);
                    comboBox4.Items.Add(empid);
                }
            }
        }

        public void PopulateGroupIDsComboBox(ComboBox comboBox3)
        {

            var con = Configuration.getInstance().getConnection();
            // Define SQL query to retrieve supervisor IDs
            string query = "select id from Groups";

            // Execute query
            SqlCommand command = new SqlCommand(query, con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // Clear existing items in the ComboBox
                comboBox3.Items.Clear();

                // Add each supervisor ID to the ComboBox
                while (reader.Read())
                {
                    // Assuming SupervisorID is of type int, adjust as needed
                    int empid = Convert.ToInt32(reader["id"]);
                    comboBox3.Items.Add(empid);
                }
            }
        }


        // employee evaulation start from here 
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton13_Click(object sender, EventArgs e)
        {
            int empID = int.Parse(comboBox5.Text);
            int rating = int.Parse(comboBox7.Text);
            string metric = comboBox6.Text;
            string comment = materialSingleLineTextField2.Text;
            DateTime date = DateTime.Parse(dateTimePicker3.Text);

            //check fields
            if (empID == 0 || rating == 0 || metric == "" || comment == "" || date == null)
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                //insert into database
                var con = Configuration.getInstance().getConnection();
                string query = "insert into Evaluation (Employee_id,Metric_id,rating,DateOfEvaluation,Remarks) values (@Employee_id,@Metric_id,@rating,@DateOfEvaluation,@Remarks)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Employee_id", empID);
                cmd.Parameters.AddWithValue("@Metric_id", getMetricID(metric));
                cmd.Parameters.AddWithValue("@rating", rating);
                cmd.Parameters.AddWithValue("@DateOfEvaluation", date);
                cmd.Parameters.AddWithValue("@Remarks", comment);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Evaluation added successfully");
            }   
            
        }

        public int getMetricID(string metric)
        {
            int metricID = 0;
            var con = Configuration.getInstance().getConnection();
            string query = "select Met_id from Metrics where Name = @Name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", metric);
            metricID = Convert.ToInt32(cmd.ExecuteScalar());
            return metricID;

        }

        //group evalution
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton14_Click(object sender, EventArgs e)
        {
            int grpID = int.Parse(comboBox10.Text);
            int rating = int.Parse(comboBox8.Text);
            string metric = comboBox9.Text;
            string comment = materialSingleLineTextField3.Text;
            DateTime date = DateTime.Parse(dateTimePicker4.Text);

            //check fields
            if (grpID == 0 || rating == 0 || metric == "" || comment == "" || date == null)
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                //insert into database
                var con = Configuration.getInstance().getConnection();
                string query = "insert into GroupEvaluation (Group_id,Metric_id,rating,DateOfEvaluation,Remarks) values (@Group_id,@Metric_id,@rating,@DateOfEvaluation,@Remarks)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Group_id", grpID);
                cmd.Parameters.AddWithValue("@Metric_id", getMetricID(metric));
                cmd.Parameters.AddWithValue("@rating", rating);
                cmd.Parameters.AddWithValue("@DateOfEvaluation", date);
                cmd.Parameters.AddWithValue("@Remarks", comment);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Group Evaluation added successfully");
            }
        }
    }
}
