using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentCoursesChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            // Course list created w/ at least 2 students sub list
            List<Course> courses = new List<Course>()
            {
                new Course() {CourseId = 1, Name="Stats 243", Students=new List<Student>() {
                    new Student() { StudentId = 1, Name = "Steve Holt" },
                    new Student() { StudentId = 2, Name = "Maebe Funke"}}},
                new Course() { CourseId = 2, Name ="Anatomy 201", Students = new List<Student>() {
                    new Student() { StudentId = 3, Name = "Tobias Funke" },
                    new Student() { StudentId = 4, Name = "Gob Bluth"}}},
                new Course() { CourseId = 3, Name = "Chem 101", Students = new List<Student>() {
                    new Student() { StudentId = 5, Name = "George Michael Bluth"},
                    new Student() { StudentId = 6, Name = "Kitty Sanchez"}}}
            };

            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("<br/>Course: {0} - {1}", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("<br/>&nbsp;&nbsp;Student: {0} - {1}", student.StudentId, student.Name);
                }
            }
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            // Dictionary of Students (w/student ID as key)
            Course course1 = new Course() { CourseId = 1, Name = "P.E." };
            Course course2 = new Course() { CourseId = 2, Name = "Photography 401" };
            Course course3 = new Course() { CourseId = 3, Name = "Hip Hop II" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 1, new Student { StudentId = 1, Name ="Daenerys Targaryen", Courses = new List<Course> { course1, course3 }}},
                { 2, new Student { StudentId = 2, Name = "Jon Snow", Courses = new List<Course> { course2, course3}}},
                { 3, new Student { StudentId = 3, Name = "Tyrion Lannister", Courses = new List<Course> { course1, course2}}}
            };

            // Student w/Courses printed
            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<br/>Student: {0} - {1}", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("<br/>&nbsp;&nbsp;Course: {0} {1}", course.CourseId, course.Name);
                }
            }

        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            // Student,Grade and Course tracking
            Student student = new Student();
            student.StudentId = 8;
            student.Name = "Walter White";
            student.Enrollments = new List<Enrollment>() {
                new Enrollment { Grade = 99, Course = new Course { CourseId = 1, Name = "Chem 101"}},
                new Enrollment { Grade = 15, Course = new Course { CourseId = 2, Name = "Business Ethics 101"}}
            };

            // Print Course name w/Grade and Student
            resultLabel.Text += String.Format("<br/>Student: {0} {1}", student.StudentId, student.Name);
            foreach (var enrollment in student.Enrollments)
            {
                resultLabel.Text += String.Format("<br/>Enrolled In: {0} - Grade: {1}", enrollment.Course.Name, enrollment.Grade);
            }
        }
    }
    
}