using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mankind
{
   public class Human
    {
        private string firstName;
        private string lastName;
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        protected string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
               if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }               
                this.firstName = value;
            }
        }
        protected string LastName
        {
            get { return this.lastName; }
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
               if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                this.lastName = value;
            }
        }
        private bool IsValidName(string name)
        {
            bool isValid = false;
            if (Regex.IsMatch(name, @"([A-Z]\w+)"))
            {
                isValid = true; 
            }
            return isValid;
        }
    }
}
