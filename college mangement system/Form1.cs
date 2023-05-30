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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;

            if (Username == "  " && Password == "  ")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
            }

            else
            {
                MessageBox.Show("Username Or Password is Wrong Please Try Agian", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void newAdmissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new_admission na = new new_admission();
            na.Show();
        }

        private void updateSemsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upgrade_semester up = new upgrade_semester();
            up. Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fees fs = new fees();
            fs.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();

        }

        private void indivdiualStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentIndividualDetails sid = new StudentIndividualDetails();
            sid.Show();

        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Doctor doctor = new Add_Doctor();
            doctor.Show();

        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_doctor sd = new search_doctor();
            sd.Show();

        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void admissionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }

        private void humanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BACU hn = new BACU();
            hn.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deparmtents dp = new deparmtents();
            dp.Show();
            
        }
    }
}
