using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college_mangement_system
{
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
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
            string Department = txtDepartment.Text;
            long CollegeID = long.Parse(txtCollegeID.Text);
            string address = txtAddress.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            dateTimePickerDOB.ResetText();
            txtMobile.Clear();
            txtEmail.Clear();
            txtDepartment.ResetText();
            txtNationalty.ResetText();
            txtAddress.ResetText();
            txtCollegeID.ResetText();

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
