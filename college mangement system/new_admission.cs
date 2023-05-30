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

namespace college_mangement_system
{
    public partial class new_admission : Form
    {
        public new_admission()
        {
            InitializeComponent();
        }

        private void new_admission_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
            string mname = txtMotherName.Text;
            string gender = "";
            bool ischecked = radioButtonFemale.Checked;
            if (ischecked)
            {
                gender = radioButtonFemale.Text;

            }
            else
            {
                gender = radioButtonMale.Text;
            }
            string dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string email = txtEmail.Text;
            string semester = txtSemester.Text;
            string Department = txtDepartment.Text;
            string sname = txtSchool.Text;
            string duration = txtDuration.Text;
            string address = txtAddress.Text;

           
          

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtMotherName.Clear();
            radioButtonFemale. Checked= false;
            radioButtonMale.Checked = false;
            dateTimePickerDOB.ResetText();
            txtMobile.Clear();
            txtEmail.Clear();
            txtSemester.ResetText();
            txtDepartment.ResetText();
            txtSchool.Clear();
            txtDuration.ResetText();
            txtAddress.Clear();
           
        }
    }
}
