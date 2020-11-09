using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask3
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;

        public string setCorseName ()
        { return courseName; }

        public void getCorseName( string Corsename)
        { courseName = Corsename; }

        public string setCorseCode()
        { return courseCode; }

        public void getCorseCode( string CourseCode)
        { courseCode = CourseCode; }

        public int setCourseCredit()
        { return courseCredit; }

        public void setCourseCredit(int CourseCredit)
        { courseCredit = CourseCredit; }
    }
}
