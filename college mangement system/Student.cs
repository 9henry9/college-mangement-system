using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college_mangement_system
{
    class Student : Human
    {

        private int college_ID;
      


        public int _college_ID
        {
            set
            {
                this.college_ID = value;
            }

            get
            {
                return college_ID;
            }

        }

        


    }
}
