using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEmployee_gabriel
{
    class Node
    {
        private string _data;
        private Node _next;
        //private string name, age, department, salary, lastName, firstName;
        private Employee _employee;

        public Node(Employee Employee)
        {
            _employee = Employee;           
        }
        public Node(string Data)
        {
            _data = Data;
        }
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }
        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }     
        public Employee Employee
        { get { return _employee; }
           set { _employee = value; }
        }
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //public string Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}
        //public string LastName
        //{
        //    get { return lastName; }
        //    set { lastName = value; }
        //}
        //public string Salary
        //{
        //    get { return salary; }
        //    set { salary = value; }
        //}
        //public string FirstName
        //{
        //    get { return firstName; }
        //    set { firstName = value; }
        //}
    }
}
