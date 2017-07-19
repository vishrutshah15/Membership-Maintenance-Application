using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form2 : Form
    {
       
        MembershipList membershiplist = new MembershipList();
        MembershipList.ChangeHandler myDelegate = new MembershipList.ChangeHandler(PrintToConsole);


        /// <summary>
        /// Default constructor of Form2
        /// </summary>
        public Form2()
        {
            InitializeComponent();  
        }


        /// <summary>
        /// Properties of Firstname, Lastname, Email
        /// </summary>
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        // a method with the same signature as the delegate
        private static void PrintToConsole(MembershipList members)
        {
            Console.WriteLine("The products list has changed!");
            for (int i = 0; i < members.Count; i++)
            {
                Member m = members[i];
                Console.WriteLine(m.getDisplayText());
            }
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// OnClick save button validates all the field then sets the properties according to the textbox texts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(firstName) &&
            Validator.IsPresent(lastName)&&
            Validator.IsPresent(email))
            {
                if(Validator.IsWithinRange(firstName, 25) &&
                Validator.IsWithinRange(lastName, 25)&&
                Validator.IsWithinRange(email, 25)&&
                Validator.IsValidEmail(email))
                {
                    DialogResult = DialogResult.OK;

                    Firstname = firstName.Text;
                    Lastname = lastName.Text;
                    Email = email.Text;

                    this.Close();
                }
            } 

        }


        /// <summary>
        /// OnClick cancel button closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
