using System;
using System.Collections.Generic;
using System.Text;

namespace GymSystem
{
    internal class GymMember
    {
     // Private Properties
        private int memberId;
        private string name;

    // Public Properties
        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
