using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college_mangement_system
{
    class Doctors :Human 
    {
        private long college_ID;
        private int salary;
        



        public long _college_ID
        {
            set
            {
                this._college_ID = value;

            }

            get
            {
                return college_ID;

            }
        }

        public int _salary
        {
            set
            {
                this._salary = value;
            }
            get
            {
                return salary;
            }
        }

        
    }
}
