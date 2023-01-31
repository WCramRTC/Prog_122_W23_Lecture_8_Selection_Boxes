using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_W23_Lecture_8_Selection_Boxes
{
    public class Student
    {
        // fields
        public string FirstName;
        public string LastName;
        public int CSIGrade;
        public int GenEdGrade;

        public Student(string firstName, string lastName, int cSIGrade, int genEdGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = cSIGrade;
            GenEdGrade = genEdGrade;
        }

        // Override our ToString()

        public override string ToString()
        {
            return FirstName + " " + LastName + " - " + CSIGrade;
        }

    }
}
