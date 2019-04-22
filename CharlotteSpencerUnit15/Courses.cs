using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlotteSpencerUnit15
{
    class Courses
    {
        private string courseName;
        private string unitName;
        private string unitName1;
        private string unitName2;
        private string unitName3;

        public Courses(string courseName, string unitName, string unitName1, string unitName2, string unitName3)
        {
            this.courseName = courseName;
            this.unitName = unitName;
            this.unitName1 = unitName1;
            this.unitName2 = unitName2;
            this.unitName3 = unitName3;
        }
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string UnitName
        {
            get { return unitName; }
            set { unitName = value; }
        }
        public string UnitName1
        {
            get { return unitName1; }
            set { unitName1 = value; }
        }
        public string UnitName2
        {
            get { return unitName2; }
            set { unitName2 = value; }
        }
        public string UnitName3
        {
            get { return unitName3; }
            set { unitName3 = value; }
        }
        


    }
}
