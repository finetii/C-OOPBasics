using System;
using System.Text;

namespace Animals
{
    class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }        

        public int Age
        {
            get { return age; }
            set
            {
                if(string.IsNullOrEmpty(value.ToString()) || string.IsNullOrWhiteSpace(value.ToString()) || value <= 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }       

        public string Gender
        {
            get { return gender; }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return "Invalid input!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} {this.Age} {this.Gender}");
            sb.Append(Environment.NewLine);
            sb.Append(ProduceSound());
            return sb.ToString();
        }
    }
}
