using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharlotteSpencerUnit15
{
    public partial class Form1 : Form
    {
        //Charlotte Spencer 
        //C0189


        List<Campus> campusList = new List<Campus>();
        List<Units> unitList = new List<Units>();
        List<Courses> courseList = new List<Courses>();
        List<Student> studentList = new List<Student>();
        
        
        List<Units> unitGrade = new List<Units>();      

        int unitPoints;
        

        int studentDisplayed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.buttonNext, "Shows next record");
            toolTip1.SetToolTip(this.buttonPrevious, "Shows previous record");
            toolTip1.SetToolTip(this.textBoxCampus, "Campus where course is located");
            toolTip1.SetToolTip(this.textBoxCourseChosen, "Course being studied");
            toolTip1.SetToolTip(this.textBoxStudentID, "Student ID number");
            toolTip1.SetToolTip(this.textBoxStudentName, "Student name");
            toolTip1.SetToolTip(this.textBoxUnitGrade, "Grades achieved for respective units");
            toolTip1.SetToolTip(this.textBoxUnitName, "Name of units");
            toolTip1.SetToolTip(this.textBoxUnitPoints, "Points accrued from unit grades");
            toolTip1.SetToolTip(this.textBoxYearStart, "Date begin");
            
            
            campusList.Add(new Campus("Abbey Park"));
            campusList.Add(new Campus("Freeman's Park")); 

            unitList.Add(new Units("Software Development using Visual C#", 6));
            unitList.Add(new Units("Databases", 6));
            unitList.Add(new Units("Networking", 6));
            unitList.Add(new Units("Information Theory", 6));
            unitList.Add(new Units("Project", 12));
            unitList.Add(new Units("PC System Support", 6));                     
           
            courseList.Add(new Courses("Programming", "Software Development using Visual C#", "Databases", "Information Theory", "Project"));
            courseList.Add(new Courses("Networking", "Networking", "Information Theory", "PC System Support", "Project"));
            courseList.Add(new Sandwich("Sandwich with Work Placement Year", "Networking", "Information Theory", "PC System Support", "Project", true));

            studentList.Add(new Student("Cassie Tiel", 1, 2014, courseList[0], campusList[0], "pass", "pass", "pass", "pass"));
            studentList.Add(new Student("Dean Win", 2, 2014, courseList[1], campusList[1], "fail", "fail", "fail", "fail"));
            studentList.Add(new Student("Sam Chester", 3, 2014, courseList[2], campusList[1], "pass", "pass", "fail", "fail"));
            studentList.Add(new Student("Jimmy Novak", 4, 2014, courseList[0], campusList[0], "pass", "pass", "pass", "fail"));
            studentList.Add(new Student("Nidge Weasel", 5, 2014, courseList[1], campusList[1], "fail", "fail", "pass", "fail"));
            studentList.Add(new Student("Fran Moynihan", 6, 2014, courseList[2], campusList[1], "pass", "fail", "pass", "pass"));
            studentList.Add(new Student("Janet Towel", 7, 2014, courseList[0], campusList[0], "pass", "pass", "pass", "pass"));
            studentList.Add(new Student("Terence Little", 8, 2014, courseList[1], campusList[1], "fail", "fail", "pass", "pass"));
            studentList.Add(new Student("Elmo Smith", 9, 2014, courseList[1], campusList[1], "pass", "pass", "pass", "fail"));
            studentList.Add(new Student("Trish Black", 10, 2014, courseList[2], campusList[1], "pass", "pass", "pass", "pass"));
          
            studentDisplayed = 0;
            DisplayStudent(studentDisplayed);
          
        }

        void DisplayStudent(int studentDisplayed)
        {
            if (studentDisplayed < studentList.Count)
            {
                textBoxStudentID.Text = Convert.ToString(studentDisplayed + 1);
                
                textBoxYearStart.Text = DateTime.Today.ToString();

                Campus currentCampus = studentList[studentDisplayed].CampusName;
                textBoxCampus.Text = Convert.ToString(currentCampus.CampusName);

                Courses currentCourse = studentList[studentDisplayed].CourseName;
                textBoxCourseChosen.Text = Convert.ToString(currentCourse.CourseName);


                Student currentStudent = studentList[studentDisplayed];
                textBoxStudentName.Text = currentStudent.StudentName;

               
                textBoxUnitName.Text = Convert.ToString(currentCourse.UnitName) + Environment.NewLine + Convert.ToString(currentCourse.UnitName1) + Environment.NewLine + Convert.ToString(currentCourse.UnitName2) + Environment.NewLine + Convert.ToString(currentCourse.UnitName3);
                textBoxUnitGrade.Text = Convert.ToString(currentStudent.UnitGrade1) + Environment.NewLine + Convert.ToString(currentStudent.UnitGrade2) + Environment.NewLine + Convert.ToString(currentStudent.UnitGrade3) + Environment.NewLine + Convert.ToString(currentStudent.UnitGrade4);
                unitPoints = 0;


                if (currentStudent.UnitGrade1 == "pass")
                {
                    unitPoints = unitPoints + 6;
                }
                if (currentStudent.UnitGrade2 == "pass")
                {
                    unitPoints = unitPoints + 6;
                }
                if (currentStudent.UnitGrade3 == "pass")
                {
                    unitPoints = unitPoints + 6;
                }
                if (currentStudent.UnitGrade4 == "pass")
                {
                    unitPoints = unitPoints + 12;
                }
                else
                {
                }

                textBoxUnitPoints.Text = unitPoints.ToString();
              





            }    
               
         

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (studentDisplayed > 0)
            {
                studentDisplayed--;
            }
            DisplayStudent(studentDisplayed);
        
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (studentDisplayed < studentList.Count)
            {
                studentDisplayed++;
            }
            DisplayStudent(studentDisplayed);
        }



    }
}
