using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2
{
    class MembershipList
    {
        
        private List<Member> members;  
        public delegate void ChangeHandler(MembershipList members); //Declare the delegate
        public event ChangeHandler Changed; // declare the event
        
        

        /// <summary>
        /// Default constructor of Membership class
        /// </summary>
        public MembershipList()
            {
                members = new List<Member>();
            }


        /// <summary>
        /// Member Indexerproperty
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Member this[int i]
        {
            get
            {
                return members[i];
            }
            set
            {
                members[i] = value;
            }
        }


        /// <summary>
        /// Count variable stores the number of members
        /// </summary>
        public int Count => members.Count;


        /// <summary>
        /// + overloading operator
        /// </summary>
        /// <param name="ml"></param>
        /// <param name="m"></param>
        /// <returns>
        /// return membershiplist after adding member
        /// </returns>
        public static MembershipList operator +(MembershipList ml, Member m)
        {
            ml.Add(m);
            return ml;
        }


        /// <summary>
        /// - overloading operator
        /// </summary>
        /// <param name="ml"></param>
        /// <param name="m"></param>
        /// <returns>
        /// returns membershiplist after removing member
        /// </returns>
        public static MembershipList operator -(MembershipList ml, Member m)
        {
            ml.Remove(m);
            return ml;
        }


        /// <summary>
        /// Add method which adds member into list of members
        /// </summary>
        /// <param name="member"></param>
        public void Add(Member member)
        {
            members.Add(member);
            Changed(this); // raise the event
        }


        /// <summary>
        /// Add method which adds member into list of members with different parameters
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="email"></param>
        public void Add(string firstname, string lastname, string email)
        {
             Member m = new Member(firstname, lastname, email);
             members.Add(m);
            Changed(this);
        }


        /// <summary>
        /// Indexer getMemberByIndex
        /// </summary>
        /// <param name="i"></param>
        /// <returns>
        /// return the specific index of member
        /// </returns>
        public Member GetMemberByIndex(int i) => members[i];


        /// <summary>
        /// Remove method which removes member from membershiplist
        /// </summary>
        /// <param name="member"></param>
        public void Remove(Member member)
        {
            members.Remove(member);
            Changed(this);
        }


        /// <summary>
        /// Write method which calls getMembership method from MembershipData class.
        /// </summary>
        public void Write()
        {
            
           members = MembershipData.getMembership();
        }


        /// <summary>
        /// Save method which calls SaveMembership method from MembershipData class.
        /// </summary>
        public void Save()
        {
            
           MembershipData.SaveMembership(members);
            
        }
        
    }
}

