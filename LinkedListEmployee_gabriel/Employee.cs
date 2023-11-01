using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEmployee_gabriel
{
    internal class Employee
    {
        public string Name,age,department, lastName, firstName;
        public decimal salary;
        public Employee(string data)
        {
            LoadData(data);          
        }
        public Employee(string age, string department, string lastName, string firstName, string salary) 
        {
            this.age = age;
            this.department = department;
            this.lastName = lastName;
            this.firstName = firstName;
            //this.salary = salary;
            this.salary = decimal.Parse(salary, CultureInfo.InvariantCulture);
            this.Name = firstName + " " + lastName;
        }

        private void SplitName()
        {
            string[] Namestrings = Name.Split(' ');
            firstName = Namestrings[0];
            if (Namestrings.Length == 2)
            {
                lastName = Namestrings[1];
            }
            else if (Namestrings.Length > 2)
            {
                lastName = Namestrings.Last();               
            }
        }
        private void LoadData(string data)
        {
            string[] split_data = data.Split(',');
            Name = split_data[0];
            age = split_data[1];
            //salary = split_data[2];
            department = split_data[3];
            SplitName();
            salary = decimal.Parse(split_data[2], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            string str = "Name: " + $"{firstName} " + $"{lastName}" + "\n" +
                "Age: " + $"{age} " + "\n" +
                "Salary: " + $"${salary}" + "\n" +
                "Department: " + $"{department}" + "\n";                
            return str;
        }
    }
}
