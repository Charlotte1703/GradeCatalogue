using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlotteSpencerUnit15
{
    class Sandwich : Courses
    {
        private bool courseSandwich;

        public Sandwich(string courseName, string unitName, string unitName1, string unitName2, string unitName3, bool courseSandwich)
            : base(courseName, unitName, unitName1, unitName2, unitName3)
        {
            this.courseSandwich = courseSandwich;
        }

        public bool CourseSandwich
        {
            get { return courseSandwich; }
            set { courseSandwich = value; }
        }



    }
}
