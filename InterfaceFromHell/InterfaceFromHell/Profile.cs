using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFromHell
{
    class Profile
    {
        string fName;
        string mName;
        string lName;
        string uName;
        string pw;
        string fakeUserName;
        public Profile()
        {
            fName = "";
            mName = "";
            lName = "";
            uName = "";
            pw = "";
            fakeUserName = "";
        }
        public Profile(string fN, string mN, string lN, string uN, string pword)
        {
            fName = fN;
            mName = mN;
            lName = lN;
            uName = uN;
            pw = pword;
        }
    }
}
