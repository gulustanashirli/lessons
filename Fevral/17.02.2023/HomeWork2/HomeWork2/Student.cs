using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Student
    {
        private string _name;
        private string _surname;
        private string _email;

        public string Name
        {
            set
            {
                if (!(string.IsNullOrEmpty(_surname)))
                {
                    _email = _name + _surname + "@gmail.com";

                }
                this._name = value;
               
           
            }


            get
            {

                return this._name;
            }


        }

        public string SurName
        {
            set
            {
                if (!(string.IsNullOrEmpty(_name)))
                {
                    _email = _name + _surname + "@gmail.com";
                }


                this.SurName = value;


            }

            get
            {
                return this.SurName; 
            }


        }
          

         
           
           
    }
}    

