namespace LinkedListEmployee_gabriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] csvFile = System.IO.File.ReadAllLines(@"C:\Users\Keri Gabriel\Downloads\employees.csv");
            string choice;
            bool isRunning = true;
            //Node Head = new Node();
            //Node currentNode = Head;
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
                        Console.WriteLine(company.SearchNodeLastName(lastname));
                        // Only the first match will be displayed:
                        break;
                    case "3":
                        Console.WriteLine("3. Find Employee by Firstname ");
                        // Only the first match will be displayed:
                        Console.WriteLine("Enter first Name: ");
                        string firstname = Console.ReadLine();
                        Console.WriteLine(company.SearchNodeFirstName(firstname));
                        break;
                    case "4":
                        Console.WriteLine("4. Find Employee by Department");
                        // Only the first match will be displayed:
                        Console.WriteLine("Enter Department Name: ");
                        string depatment = Console.ReadLine();
                        Console.WriteLine(company.SearchNodeFirstName(depatment));

                        break;
                    case "5":
                        Console.WriteLine("5. Add Employee ");
                        //adds an employee to the list by sort order of Lastname, Firstname
                        break;
                    case "6":
                        Console.WriteLine("6. Display average employee salary ");
                        
                        Console.WriteLine();

                        break;
                    case "7":
                        Console.WriteLine("7. Edit Employee ");
                        //All fields are editable and could effect the sort order
                        break;
                    case "8":
                        Console.WriteLine("8. Delete Employee");
                        //If duplications, all instances of that firstname/lastname should be deleted
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
                    company.addNode(emp);                   
                }               
            }
        }
    }
}
