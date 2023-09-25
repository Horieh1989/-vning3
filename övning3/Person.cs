using övning3;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace övning3
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        public double Height { get; set; }
        public double weight { get; set; }


        public int Age// age can only be greater than 0
        {


            get 
            { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("age must be greater than 0");
                }


            }
        }
        public string Fname//must not be less than 2 charactor or more than 10 charactor
        {
            get { return fName; }

            set {

                if
                 (string.IsNullOrEmpty(value) && fName.Length <= 2 && fName.Length >= 15);
                { fName = value; }
                
                else
                { throw new ArgumentException("Family name must be between 2 and 10 charactor");
                }
             }   
        }

        public string LName//must not be less than 3 charactor or more than 15 charactor
        {

            get { return lName; }

            set
            {
                if (string.IsNullOrEmpty(value) && value.Length >= 3 && value.Length <= 15) ;

                else
                {

                    throw new ArgumentException("Last name must be between 3 and 15 charactor");
                }
            }
        }
        

        
    }

}