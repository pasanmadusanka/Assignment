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
    public partial class Student_Registration : Form
    {
        public Student_Registration()
        {
            InitializeComponent();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                string name = TextName.Text;
                string dob = TxtDate.Value.Date.ToString("MM/dd/yyyy");
                double grade = Convert.ToDouble(TxtAvg.Text);
                bool active = Convert.ToBoolean(checkActive.CheckState);

                Registration regForm = new Registration(name, dob, grade, active);
                regForm.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
