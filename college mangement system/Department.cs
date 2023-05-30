using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college_mangement_system
{
    class Department : deparmtents
    {

        private string Doctor_name;
        private int DEP_ID;
        private int Dotor_ID;

        public string _Doctor_name
        {
            set
            {
                this.Doctor_name = value;
            }

            get
            {
                return Doctor_name;
            }

        }

        public int _DEP_ID
        {

            set
            {
                this.DEP_ID = value;
            }

            get
            {
                return DEP_ID;
            }

        }

        public int _Doctor_ID
        {
            set
            {
                this.Dotor_ID = value;

            }


            get
            {
                return Dotor_ID;
            }

        }
    }
}
