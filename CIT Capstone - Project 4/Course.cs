using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT_Capstone___Project_4
{
    class Course
    {
        private string _courseName;  // Fields
        private bool _courseType;
        private bool _nursing;
        private int _creditHours;

        public Course(string courseName, bool courseType, bool nursing, int creditHours) // All arg constructor
        {
            _courseName= courseName;
            _courseType= courseType;
            _nursing= nursing;
            _creditHours= creditHours;
        }

        public string CourseName        // Properties
        {
            get { return _courseName; }
            set { _courseName= value; }
        }

        public bool CourseType
        {
            get { return _courseType; }
            set { _courseType= value; }
        }

        public bool Nursing
        {
            get { return _nursing; }
            set{ _nursing = value; }
        }

        public int CreditHours
        {
            get { return _creditHours; }
            set { _creditHours = value; }
        }
    }
}
