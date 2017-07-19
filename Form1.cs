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
    public partial class Form1 : Form
    {
        
        MembershipList ml = new MembershipList();
        

        /// <summary>
        /// Default constructor calls the event and Save and Write method from MembershipData class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            ml.Changed += member =>
             {

                 ml.Save();
                 listBox1.Items.Clear();
                 fill();
             };


            ml.Write();
            fill();
        }

            
            /// <summary>
            /// Fill method adds the members into listbox from members list
            /// </summary>
            public void fill()
            {
                for (var i = 0; i < ml.Count; i++)
                {
                    listBox1.Items.Add(ml[i].getDisplayText());

                }
            }


        /// <summary>
        /// OnClick Add pop-ups the new Form and if the DialogueResult is OK then it adds new member into list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
        
            Form2 form2 = new Form2();
            form2.ShowDialog();

            if (form2.DialogResult == DialogResult.OK)
            {
                Member m = new Member(form2.Firstname, form2.Lastname, form2.Email);
                ml+= m; //Use of overloading operator +
            }
        }


        /// <summary>
        /// OnClick Delete removes the selected item from listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Remove the item in the List.
                if (this.listBox1.SelectedIndex >= 0)
                {
                 
                    ml-=ml[this.listBox1.SelectedIndex]; //Use of indexer
                    
                }
                
                if (listBox1.Items.Count == 0)
                {
                    Delete.Enabled = false;
                }
            }
            catch(Exception)
            {
                
            }

        }

        /// <summary>
        /// OnClick Exit closes the Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
