using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college_mangement_system
{
    class Human : BACU
    {


        private string full_name;
        private string mother_name; 
        private int age;
        private string e_mail;
        private long phone_number;
        private string gender;
        private string nationalty;
        private string department;

        //this is all the Properties of the (Human) Class in our colleges software

        public string _full_name
        {
            set
            {
                this.full_name = value;
            }
            get
            {
                return full_name;
            }
        }
        public string _mother_name
        {
            set
            {
                this.mother_name = value;
            }
            get
            {
                return mother_name;
            }
        }

        public int _age
        {
            set
            {
                this.age = value;
            }
            get
            {
                return age;
            }
        }

        public string _e_mail
        {
            set
            {
                this.e_mail = value;
            }
            get
            {
                return e_mail;
            }
        }
       

        public long _phone_number
        {
            set
            {

                this.phone_number = value;
            }

            get
            {
                return phone_number;
            }

        }

        public string _gendr
        {
            set
            {
                this.gender = value;
            }
            get
            {
                return gender;
            }
        }

        public string _nationalty
        {
            set
            {
                this.nationalty = value;
            }
            get
            {
                return nationalty;
            }
        }

        public string _department
        {
            set
            {
                this.department = value;

            }

            get
            {
                return department;
            }

        }
     }
}
