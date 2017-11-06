using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */

            var result = "";

            List<Course> courses = new List<Course>()
            {
                new Course { CourseId = 101, Name = "Biology", Students = new List<Student>() {
                    new Student() { StudentId = 1004, Name = "Tupac Shakur"},
                    new Student() { StudentId = 1005, Name = "Notorious BIG"}
                }
                },
                new Course { CourseId = 102, Name = "Algebra", Students = new List<Student>() {
                    new Student() { StudentId = 1006, Name = "Q-Tip"},
                    new Student() { StudentId = 1007, Name = "Kendrick Lamar"}
                }
                },
                new Course { CourseId = 103, Name = "Physics", Students = new List<Student>() {
                    new Student { StudentId = 1008, Name = "Red Man"},
                    new Student { StudentId = 1009, Name = "Method Man"}
                }
                },
                new Course { CourseId = 104, Name = "Spanish", Students = new List<Student>() {
                    new Student { StudentId = 1010, Name = "Mos Def"},
                    new Student { StudentId = 1011, Name = "Lupe Fiasco"}
                }
                },
                new Course { CourseId = 105, Name = "American History", Students = new List<Student>() {
                    new Student { StudentId = 1012, Name = "Talib Kweli"},
                    new Student { StudentId = 1013, Name = "Busta Rhymes"}
                }
                },
                new Course { CourseId = 106, Name = "Sociology", Students = new List<Student>() {
                    new Student { StudentId = 1014, Name = "Big Pun"},
                    new Student { StudentId = 1015, Name = "Tech N9ne"}
                }
                },
                new Course { CourseId = 107, Name = "Geography", Students = new List<Student>() {
                    new Student { StudentId = 1016, Name = "Marshall Mathers"},
                    new Student { StudentId = 1017, Name = "Dr. Dre"}
                }}
            };

            foreach (var course in courses)
            {
                result += string.Format("<br/><br/><b>Course: {0} - {1}</b>", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    result += String.Format("<br/>&nbsp;&nbsp;Student: {0} - {1}", student.StudentId, student.Name);
                }
            }

           
            resultLabel.Text = result;


        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */
            var result = "";

            Course course1 = new Course() { CourseId = 101, Name = "Biology" };
            Course course2 = new Course() { CourseId = 102, Name = "Algebra" };
            Course course3 = new Course() { CourseId = 103, Name = "Physics" };
            Course course4 = new Course() { CourseId = 104, Name = "Spanish" };
            Course course5 = new Course() { CourseId = 106, Name = "Sociology" };
            Course course6 = new Course() { CourseId = 107, Name = "Geogoraphy" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 10020, new Student { StudentId = 10020, Name = "Wayne Rooney", Courses = new List<Course>(){course1, course2}} },
                { 10021, new Student { StudentId = 10021, Name = "Eric Cantona", Courses = new List<Course>() {course2, course3}} },
                { 10022, new Student { StudentId = 10022, Name = "Ryan Giggs", Courses = new List<Course>() {course3, course4}} },
                { 10023, new Student { StudentId = 10023, Name = "Paul Scholes", Courses = new List<Course>() {course4, course5}} },
                { 10024, new Student { StudentId = 10024, Name = "David Beckham", Courses = new List<Course>() {course5, course6}} },
                { 10025, new Student { StudentId = 10025, Name = "Roy Keane", Courses = new List<Course>() {course6, course1 }} }
            };

            foreach (var student in students)
            {
                result += String.Format("<br/><br/><b>Student: {0} - {1}</b>", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    result += String.Format("<br/>&nbsp;&nbsp;Course: {0} - {1}", course.CourseId, course.Name);
                }
            }


            resultLabel.Text = result;
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            // Student student = new Student() { StudentId = 1101, Name = "Jackie Chan" };

            string result = "";

            List<Student> students = new List<Student>()
            {
                new Student() { StudentId = 1101, Name = "Jackie Chan", Enrollments = new List<Enrollment>(){
                    { new Enrollment() {Grade = 94, Course = new Course{ CourseId = 101, Name = "Biology"} } },
                    { new Enrollment() {Grade = 98, Course = new Course{ CourseId = 102, Name = "Algebra"}} }
                }
                },
                new Student() { StudentId = 1102, Name = "Bruce Lee", Enrollments = new List<Enrollment>()
                {
                    new Enrollment() {Grade = 95, Course = new Course {CourseId = 103, Name = "Physics"}},
                    new Enrollment() {Grade = 91, Course = new Course {CourseId = 104, Name = "Spanish"}}
                }
                },
                new Student() { StudentId = 1103, Name = "Van Damme", Enrollments = new List<Enrollment>()
                {
                    new Enrollment() {Grade = 92, Course = new Course{ CourseId = 105, Name = "Sociology"}},
                    new Enrollment() {Grade = 93, Course = new Course {CourseId = 106, Name = "Geogrophy"}}
                }
                },
                new Student() { StudentId = 1104, Name = "Jet Lee", Enrollments = new List<Enrollment>()
                {
                    new Enrollment{ Grade = 90, Course = new Course{CourseId = 102, Name = "Algebra"}},
                    new Enrollment{Grade = 97, Course = new Course{CourseId = 101, Name = "Biology"}}   
                }
                }
            };

            foreach (var student in students)
            {
                result += String.Format("<br/><br/><b>Student: {0} - {1}</b>", student.StudentId, student.Name);
                foreach (var enrollment in student.Enrollments)
                {
                    result += String.Format("<br/>&nbsp;&nbsp;Course: {0} - {1}&nbsp;&nbsp;&nbsp;&nbsp;<b>Grade: {2}</b>", 
                        enrollment.Course.CourseId, enrollment.Course.Name, enrollment.Grade);
                }
            }
            resultLabel.Text = result;
        }
    }
}