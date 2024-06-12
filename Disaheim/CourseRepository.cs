using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            if (course != null)
            {
                courses.Add(course);
            }
        }

        public Course GetCourse(string name)
        {
            foreach (var course in courses) //var betyder variable, og er en fleksibel datatype (systemet regner selv ud hvad det skal være)
            {
                if (course.Name == name)
                {
                    return course;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;

            Utility utility = new Utility();

            foreach (var course in courses)
            {
                total = total + utility.GetValueOfCourse(course);
            }
            return total;
        }
    }
}
