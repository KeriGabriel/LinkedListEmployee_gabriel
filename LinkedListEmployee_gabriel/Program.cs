﻿using System.Globalization;
using System.Transactions;

namespace LinkedListEmployee_gabriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.ToString();
            string gp = path+ @"\employees.csv";
            string[] csvFile = System.IO.File.ReadAllLines(gp);
            string choice;
            bool isRunning = true;

            Company company = new Company();
            var employees = new List<Employee>();
            var c = new List<Company>();
            load();
            while (isRunning)
            {
                printMenu();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("1. View Employee List ");
                        company.print();
                        break;
                    case "2":
                        Console.WriteLine("2. Find Employee by Lastname");
                        Console.WriteLine("Enter Last Name: ");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("\n" + company.SearchNodeLastName(lastname));
                        // Only the first match will be displayed:
                        break;
                    case "3":
                        Console.WriteLine("3. Find Employee by Firstname ");
                        // Only the first match will be displayed:
                        Console.WriteLine("Enter first Name: ");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("\n" + company.SearchNodeFirstName(firstname));
                        break;
                    case "4":
                        Console.WriteLine("4. Find Employee by Department");
                        // Only the first match will be displayed:
                        Console.WriteLine("Enter Department Name: ");
                        string department = Console.ReadLine();
                        Console.WriteLine("\n"+company.SearchNodeDepartment(department));
                        break;
                    case "5":
                        Console.WriteLine("5. Add Employee ");
                        AddEmployee();

                        break;
                    case "6":
                        Console.WriteLine("6. Display average employee salary ");                       
                        Console.WriteLine(company.Salary().ToString("C3", CultureInfo.CurrentCulture));
                        break;
                    case "7":
                        Console.WriteLine("7. Edit Employee ");
                        //All fields are editable and could effect the sort order
                        Console.WriteLine("Enter first and last name");
                        string Name = Console.ReadLine();
                        Employee Edit = company.SearchNodeName(Name);
                        Console.WriteLine(Edit);
                        changeEmployee(Edit);
                        break;
                    case "8":
                        Console.WriteLine("8. Delete Employee");                 
                        Console.WriteLine("Enter first and last name");
                        string deleteNode = Console.ReadLine();
                        Console.WriteLine(company.DeleteNode(deleteNode));
                        break;
                    case "9":
                        Console.WriteLine("9. Exit");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("choose a number");
                        break;
                }
            }
            void printMenu()
            {
                Console.WriteLine();
                Console.WriteLine("Main Menu ");
                Console.WriteLine("Choose a number from the menu ");
                Console.WriteLine("1. View Employee List ");
                Console.WriteLine("2. Find Employee by last name ");
                Console.WriteLine("3. Find Employee by first name ");
                Console.WriteLine("4. Find Employee by Department ");
                Console.WriteLine("5. Add Employee ");
                Console.WriteLine("6. Display average employee salary ");
                Console.WriteLine("7. Edit Employee ");
                Console.WriteLine("8. Delete Employee");
                Console.WriteLine("9. Exit");
                choice = Console.ReadLine();
                Console.WriteLine("");
            }
            void load ()
            {
                for (int i = 1; i < csvFile.Length; i++)
                {
                    Employee emp = new Employee(csvFile[i]);
                                      
                  //company.addNode(emp);
                   company.SortedAdd(emp);
                }
            }
            void AddEmployee()
            {
                string age;
                string _department;
                string lastName;
                string firstName;
                string salary;
                //adds an employee to the list by sort order of Lastname, Firstname
                Console.WriteLine("Enter Employee age ");
                age = Console.ReadLine();
                Console.WriteLine("Enter Employee last Name ");
                lastName = Console.ReadLine();
                Console.WriteLine("Enter Employee first Name ");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter Employee department ");
                _department = Console.ReadLine();
                Console.WriteLine("Enter Employee salary ");
                salary = Console.ReadLine();
                company.AddEmployee(age, _department, lastName, firstName, salary);
                load();
            }
            void changeEmployee(Employee employee)
            {              
                string age;
                string _department;
                string lastName;
                string firstName;
                string salary;
                //adds an employee to the list by sort order of Lastname, Firstname
                Console.WriteLine("Enter Employee age ");
                age = Console.ReadLine();
                Console.WriteLine("Enter Employee last Name ");
                lastName = Console.ReadLine();
                Console.WriteLine("Enter Employee first Name ");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter Employee department ");
                _department = Console.ReadLine();
                Console.WriteLine("Enter Employee salary ");
                salary = Console.ReadLine();
                company.AddEmployee(age, _department, lastName, firstName, salary);
                load();
            }
        }
    }
}
