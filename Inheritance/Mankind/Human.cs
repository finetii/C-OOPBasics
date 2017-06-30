using System;
using System.Text;

namespace Mankind
{
    class Human
    {
        private string firstName;
        private string lastName;
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (char.IsLower(value[0]))
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                this.firstName = value;
            }
        }

        public virtual string LastName
        {
            get { return this.lastName; }
            set
            {
                if (char.IsLower(value[0]))
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                this.lastName = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}")
                .AppendLine($"Last Name: {this.LastName}");
                
            return sb.ToString();
        }
    }
}
