using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college_mangement_system
{
    class Stuff:Human
    {
        private long Id_access;
        private int salary;

        public long _Id_access
        {
            set
            {
                this.Id_access = value;
            }
            get
            {
                return Id_access;
            }
        }
        public int _salary
        {
            set
            {
                this.salary = value;
            }

            get
            {
                return salary;

            }
        }

    }
}
