using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10.0)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }
        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (1.0 > value || value > 12.0)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }

       
        private double GetSalaryPerHour()
        {

            double salaryPerHour = this.weekSalary / (this.workHoursPerDay * 5);
            return salaryPerHour;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("First Name: ").AppendLine(base.FirstName)
                .Append("Last Name: ").AppendLine(base.LastName)
                .Append("Week Salary: ").AppendLine($"{this.WeekSalary:f2}")
                .Append("Hours per day: ").AppendLine($"{this.WorkHoursPerDay:f2}")
                .Append("Salary per hour: ").AppendLine($"{GetSalaryPerHour():f2}")
                .AppendLine();

            return sb.ToString();
        }

    }
}
