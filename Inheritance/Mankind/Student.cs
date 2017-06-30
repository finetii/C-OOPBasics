using System;
using System.Text;


namespace Mankind
{
    class Student:Human
    {
        private string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber)
            :base (firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string FirstName
        {
            get { return base.FirstName; }
            set
            {
                if (value.Length < 4)
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                base.FirstName = value;
            }
        }
        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10 || !IsValidFacultyNumber(value))
                    throw new ArgumentException("Invalid faculty number!");
                this.facultyNumber = value;
            }
        }

        private bool IsValidFacultyNumber(string value)
        {
            bool isNumber = true;
            foreach (char symbol in value)
            {
                if (char.IsLetter(symbol))
                    isNumber = false;
            }
            return isNumber;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Faculty number: {this.FacultyNumber}");

                
            return sb.ToString();
        }
    }
}
