using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class Course
    {
        public override string ToString()
        {
            return $"{Id}. {Department}-{Number}: {Name}, {Credits} Credits";
        }
    }

    partial class Enrollment
    {
        public override string ToString()
        {
            return $"{Id}. {Student.Name} -> {Section.Course.Name}:{Grade}";
        }
    }

    partial class Instructor
    {
        public override string ToString()
        {
            return $"{Id}. {Name}, #{Phone}, @{Office}";
        }
    }

    partial class Major
    {
        public override string ToString()
        {
            return $"{Id}. {Name}";
        }
    }

    partial class Section
    {
        public override string ToString()
        {
            return $"{Id}. {Days} {Time} c:{Course.Name} w/ {Instructor.Name}";
        }
    }

    partial class Student
    {
        public override string ToString()
        {
            return $"{Id}. {Name}:{UMID} c:{Credits_Earned} m:{Major.Name}";
        }
    }
}
