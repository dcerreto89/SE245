using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Person
    {
        private string fName;
        private string mName;
        private string lName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;

        protected string feedback;

        public string FName
        {
            get { return fName; }
            set
            {
                if (Validation.ContainsBadWords(value))
                {
                    //dont store bad words
                    feedback += "\nERROR: First name has bad words in it.";
                }
                else
                {
                    fName = value;
                }
                
            }
        }
        public string MName
        {
            get { return mName; }
            set
            {
                if (Validation.ContainsBadWords(value))
                {
                    feedback += "\nERROR: Middle name has bad words in it.";
                }
                else
                {
                    mName = value;
                }                    
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (Validation.ContainsBadWords(value))
                {
                    feedback += "\nERROR: Last name has bad words in it.";
                }
                else
                {
                    lName = value;
                }
            }
        }
        public string Street1
        {
            get { return street1; }
            set
            {
                if (Validation.ContainsBadWords(value))
                {
                    feedback += "\nERROR: Street1 has bad words in it.";
                }
                else
                {
                    street1 = value;
                }
            }
        }
        public string Street2
        {
            get { return street2; }
            set
            {
                if (Validation.ContainsBadWords(value))
                {
                    feedback += "\nERROR: Street2 has bad words in it.";
                }
                else
                {
                    street2 = value;
                }
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (Validation.ContainsBadWords(value))
                {
                    feedback += "\nERROR: City has bad words in it.";
                }
                else
                {
                    city = value;
                }
            }
        }
        public string State
        {
            get { return state; }
            set
            {
                if (Validation.IsExactLength(value, 2))
                {
                    state = value;
                }
                else
                {
                    feedback += "\nERROR: State is not in the proper format ex) MA.";
                }
                
            }
        }
        public string Zip
        {
            get { return zip; }
            set
            {
                if (Validation.IsInteger(value) && Validation.IsExactLength(value, 5))
                {
                    zip = value;
                }
                else
                {
                    feedback += "\nERROR: Zipcode was entered incorrectly.";
                }
                
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (Validation.IsInteger(value) && Validation.IsExactLength(value, 10))
                {
                    phone = value;
                }
                else
                {
                    feedback += "\nERROR: Phone number was entered incorrectly.";
                }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (Validation.IsValidEmail(value))
                {
                    email = value;
                }
                else
                {
                    feedback += "\nERROR: Please enter a valid email address.";
                }
                
            }
        }

        public string Feedback
        {
            get { return feedback; }        //allows outside code to see feedback
            // Notice there is no SET...This is because only the class can change feedback  
        }

        // Constructor
        // Initializes all variables
        public Person()
        {
            fName = "";
            mName = "";
            lName = "";
            street1 = "";
            street2 = "";
            city = "";
            state = "";
            zip = "";
            phone = "";
            email = "";
            feedback = "";
        }
    }
}
