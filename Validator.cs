using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    class Validator
    {
            private static string title = "Entry Error";

            public static string Title
            {
                get
                {
                    return title;
                }
                set
                {
                    title = value;
                }
            }

            
            /// <summary>
            /// IsPresent method validates that the field is not empty
            /// </summary>
            /// <param name="textBox"></param>
            /// <returns>
            /// true if not empty and false if empty
            /// </returns>
            public static bool IsPresent(TextBox textBox)
            {
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
                return true;
            }


        /// <summary>
        /// IsWithinRange method validates the field has max character limit
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="max"></param>
        /// <returns>
        /// true if less than limit and false if exceeds
        /// </returns>
        public static bool IsWithinRange(TextBox textBox, decimal max)
        {
            
            if (textBox.Text.Length > max)
            {
                MessageBox.Show(textBox.Tag + " must be less than"
                + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }


        /// <summary>
        /// Validates email address with @ and .
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>
        /// true if valid and false if not
        /// </returns>
        public static bool IsValidEmail(TextBox textBox)
            {
                if (textBox.Text.IndexOf("@") == -1 ||
                textBox.Text.IndexOf(".") == -1)
                {
                    MessageBox.Show(textBox.Tag + " must be a valid email address.",
                    Title);
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }


