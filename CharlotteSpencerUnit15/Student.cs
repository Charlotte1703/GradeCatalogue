using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlotteSpencerUnit15
{
    class Student
    {
        private string studentName;
        private int studentID;
        private int yearStart;
        private Courses courseName;
        private Campus campusName;
        private string unitGrade1;
        private string unitGrade2;
        private string unitGrade3;
        private string unitGrade4;

        public Student(string studentName, int studentID, int yearStart, Courses courseName, Campus campusName, string unitGrade1, string unitGrade2, string unitGrade3, string unitGrade4)
        {
            this.studentName = studentName;
            this.studentID = studentID;
            this.yearStart = yearStart;
            this.courseName = courseName;
            this.campusName = campusName;
            this.unitGrade1 = unitGrade1;
            this.unitGrade2 = unitGrade2;
            this.unitGrade3 = unitGrade3;
            this.unitGrade4 = unitGrade4;
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public int YearStart
        {
            get { return yearStart; }
            set { yearStart = value; }
        }
        public Courses CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public Campus CampusName
        {
            get { return campusName; }
            set { campusName = value; }
        }
        public string UnitGrade1
        {
            get { return unitGrade1; }
            set { unitGrade1 = value; }
        }
        public string UnitGrade2
        {
            get { return unitGrade2; }
            set { unitGrade2 = value; }
        }
        public string UnitGrade3
        {
            get { return unitGrade3; }
            set { unitGrade3 = value; }
        }
        public string UnitGrade4
        {
            get { return unitGrade4; }
            set { unitGrade4 = value; }
        }
    }
}
