using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToCSharp
{
    public class Helper
    {
        protected int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }

    public class Test : Helper
    {
        public Test()
        {
           _id = 17019; 
        }

    }
}
