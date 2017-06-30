using System;
using System.Text;


namespace Mankind
{
    class Worker:Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public override string LastName
        {
            get { return base.LastName; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                base.LastName = value;
            }
        }
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10)
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                this.workHoursPerDay = value;
            }
        }
        private decimal SalaryPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine()
                .Append(base.ToString())                        
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")                
                .AppendLine($"Hours per day: {WorkHoursPerDay:f2}")                
                .AppendLine($"Salary per hour: {SalaryPerHour():f2}");
            return sb.ToString().Trim();
        }
    }
}
