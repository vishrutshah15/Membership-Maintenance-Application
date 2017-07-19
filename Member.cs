using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2
{
    class Member
    {
        private string firstName;

        private string lastName;

        private string email;

       
        /// <summary>
        /// Default constructor
        /// </summary>
        public Member()
        { 
            
        }

        /// <summary>
        /// Parameterized constructor of Member class
        /// </summary>
        /// <param name="f"></param>
        /// <param name="l"></param>
        /// <param name="e"></param>
        public Member(string f, string l, string e)
        {
            this.firstName = f;
            this.lastName = l;
            this.email = e;
        }

        /// <summary>
        /// FirstName property. </summary>
        /// <value>
        /// sets the value of firstname if the characters are less than 25.
        /// </value>
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 25)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be less than 25 characters");

                firstName = value;
            }
        }

        /// <summary>
        /// LirstName property. </summary>
        /// <value>
        /// sets the value of lirstname if the characters are less than 25.
        /// </value>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 25)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be less than 25 characters");

                lastName = value;
            }
        }

        /// <summary>
        /// Email property. </summary>
        /// <value>
        /// sets the value of email if the characters are less than 25.
        /// </value>
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Length > 25)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be less than 25 characters");

                email = value;
            }
        }

        public string getDisplayText()
        {
            return firstName + lastName + "," + email;
        }
    }
}
