using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college_mangement_system
{
    class Computing :Department
    {
        private string special_Days;
        private string DR_name;
        private int Hall_NUM;

        public string _special_Days
        {
            set
            {
                this.special_Days = value;
            }
            get
            {
                return special_Days;
            }
        }

        public string _DR_name
        {
            set
            {
                this.DR_name = value;
            }

            get
            {
                return DR_name;

            }

        }

        public int _Hall_NUM
        {
            set
            {
                this.Hall_NUM = value;
            }


            get
            {
                return Hall_NUM;
            }
        }
    }
}
