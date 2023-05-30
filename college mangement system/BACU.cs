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
    public partial class BACU : Form 
    {
        public BACU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Doctor add_Doctor = new Add_Doctor();
            add_Doctor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new_admission na = new new_admission();
            na.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employees el = new employees();
            el.Show();
        }

        private void BACU_Load(object sender, EventArgs e)
        {

        }
    }
}
