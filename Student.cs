using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4._1.Student
{
    internal class Student
    {
        private String mName;
        private DateTime mDateOfBirth;

        public String Name
        {
            get
            {
                return mName;
            }
            set
            {
                if((value != null) && (value.Length > 0)){
                    mName = value;

                } else
                {
                    throw new ArgumentException("Invalid name");
                }
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                if((value.Year >= 1900) && (value.Year <= DateTime.Now.Year))
                {
                    mDateOfBirth = value;
                }
                else
                {
                    throw new ArgumentException("Invalid date of birth");
                }
            }
        }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = now.Year - mDateOfBirth.Year;
                if (now < mDateOfBirth.AddYears(age))
                {
                    age--;
                }
                return age;
            }
        }
    }
}
