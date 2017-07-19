using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2
{
    class MembershipData
    {
        private const string dir = @"E:\";
        private const string path = dir + "Members.txt";  


        /// <summary>
        /// SaveMembership method stores the list of members into file
        /// </summary>
        /// <param name="members"></param>
        public static void SaveMembership(List<Member> members)
        {
            
            // if the directory doesn't exist, create it
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            StreamWriter textOut =
            new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));

            // write each member from the list to the file
            foreach (Member m in members)
            {
                textOut.Write(m.FirstName + "|");
                textOut.Write(m.LastName + "|");
                textOut.WriteLine(m.Email);
            }

            // write the end of the document
            textOut.Close();

        }


        /// <summary>
        /// getMembership method retrieves the list of members from file.
        /// </summary>
        /// <returns>
        /// List of members
        /// </returns>
        public static List<Member> getMembership()
        {
            StreamReader textIn =
            new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            var m = new List<Member>();

            // read the data from the file and store it in the ArrayList
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                m.Add(new Member(columns[0], columns[1], columns[2]));
            }
            textIn.Close();

            return m;
        }
    }
}
