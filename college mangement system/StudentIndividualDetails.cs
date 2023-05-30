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
    public partial class StudentIndividualDetails : Form
    {
        public StudentIndividualDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            textFullname.Clear();
            textMname.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            dateTimePickerBOD.ResetText();
            textMobile.Clear();
            textEmail.Clear();
            textStandard.ResetText();
            textMedium.ResetText();
            textSchoolname.Clear();
            textDuration.ResetText();
            textAddress.Clear();
        }
    }
}
