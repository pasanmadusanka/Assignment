using Segment_5_Pasan.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segment_5_Pasan
{
    public partial class Registration : Form
    {
        private string reg_name;
        private string reg_dob;
        private double reg_grade;
        private bool reg_active;

        Database data = new Database();

        public Registration(string name, string dob, double grade, bool active)
        {

            InitializeComponent();
            this.reg_name = name;
            this.reg_dob = dob;
            this.reg_grade = grade;
            this.reg_active = active;
        }

        public Registration()
        {
            InitializeComponent();
            // TODO: Complete member initialization
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Student_Registration std = new Student_Registration();
            std.Show();
            this.Dispose();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            GetGrid();
            if (reg_name != null)
            {
                NewRecord();
            }
        }

        public void NewRecord()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("StudentId"), new DataColumn("Name"), new DataColumn("DOB"), new DataColumn("GradePointAvg"), new DataColumn("Active") });
            dt.Rows.Add("", reg_name, reg_dob, reg_grade, reg_active);
            RegistrationGrid.DataSource = dt;
        }

        public void GetGrid()
        {
            DataSet ds = data.FillGrid();
            RegistrationGrid.DataSource = ds.Tables["Registration"].DefaultView;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.AddNewStudent(reg_name, reg_dob, reg_grade, Convert.ToInt32(reg_active)))
                {
                    MessageBox.Show("Sucessfully " + reg_name + " added");
                }
                else
                {
                    MessageBox.Show("Error occured");
                }
                GetGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
