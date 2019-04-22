using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlotteSpencerUnit15
{
    class Campus
    {
        private string campusName;

        public Campus(string campusName)
        {
            this.campusName = campusName;
        }
        public string CampusName
        {
            get { return campusName; }
            set { campusName = value; }
        }
    }
}
