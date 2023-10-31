using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Globalization;

namespace LinkedListEmployee_gabriel
{
    internal class  Company
    {
        private Node Head;
        public enum search
        {
            _lastName,
            _firstName,
            Department
        }
        public void addNode(string data)
        {
            // create a new node, assign string to node data
            Node NewNode = new Node(data);
            NewNode.Data = data;
            // assign null to next node
            NewNode.Next = null;
            //check to see if head is empty
            if (Head == null) Head = NewNode;
            //add new node to end of list
            else
            {
                // make a temp node
                Node temp = new Node(data);
                temp = Head;
                // while temp.next is not null temp = temp.next
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                //assign newNode to temp.next
                temp.Next = NewNode;
            }
            //NewNode.Next = Head;
            //Head = NewNode;
            //^^^^^^^ This adds to front of list
        }
        public void addNode(Employee data)
        {
            // create a new node, assign string to node data
            Node NewNode = new Node(data);
            // assign null to next node
            NewNode.Next = null;
            //check to see if head is empty
            if (Head == null) Head = NewNode;
            //add new node to end of list
            else
            {
                // make a temp node
                Node temp = new Node(data);
                temp = Head;
                // while temp.next is not null temp = temp.next
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                //assign newNode to temp.next
                temp.Next = NewNode;
            }            
        }
        public void SortedAdd(Employee data)
        {
            // create a new node, assign string to node data
            Node NewNode = new Node(data);
            // assign null to next node
            NewNode.Next = null;
            Node current;
            // check head
            if (Head == null )
            {                
                Head = NewNode;
                return;
            }
            // compare nodes last names
            //  0 strings are =
            //  + int 1st string goes after 2nd
            // - int 1st string goes before 2nd string
            int result;
            string _lastnameHead = Head.Employee.lastName.ToString();
            string _lastnameNewnode = NewNode.Employee.lastName.ToString();
            result = String.Compare(_lastnameHead, _lastnameNewnode);
            if (result > 0)
            {
                Node temp = new Node(data);
                temp = Head;
                // while temp.next is not null temp = temp.next
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                //assign newNode to temp.next
                temp.Next = NewNode;
                return;
            }            
            if (result == 0)
            {
                result = String.Compare(Head.Employee.firstName, NewNode.Employee.firstName);
                
                if (result > 0)
                {
                    Node temp = new Node(data);
                    temp = Head;
                    // while temp.next is not null temp = temp.next
                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    //assign newNode to temp.next
                    temp.Next = NewNode;
                    return;
                }
            }
            //else
            //{
            //    current = Head;
            //    while (current.Next != null )
            //    {
            //        result = String.Compare(Head.Employee.lastName, NewNode.Employee.lastName);
            //        if (result < 0)
            //        {
            //            current = current.Next;
            //            NewNode.Next = current.Next;
            //            current.Next = NewNode;
            //        }
            //    }
            //}           
        }
        public void print()
        {
            Node current = Head;
            // go through list and print until list is empty
            while (current != null)
            {
                Console.WriteLine(current.Employee);
                current = current.Next;
            }
        }
        public string SearchNodeLastName(string searchNode)
        {
            Node current = Head;
            string result = string.Empty;
            //go through list and search for data string entered and return found Node
            // if not found return search string not found
            while (current != null)
            {
                if (current.Employee.lastName == searchNode)
                {
                    result = "Found " + current.Employee.ToString();
                    return result;
                }
                if (current.Employee.lastName != searchNode)
                {
                    result = searchNode + " Not found";
                    current = current.Next;
                }               
            }
            return result;
        }
        public string SearchNodeFirstName(string searchNode)
        {
            Node current = Head;
            string result = string.Empty;
            //go through list and search for data string entered and return found Node
            // if not found return search string not found
            while (current != null)
            {
                if (current.Employee.firstName == searchNode)
                {
                    result = "Found " + current.Employee.ToString();
                    return result;
                }
                if (current.Employee.firstName != searchNode)
                {
                    result = searchNode + " Not found";
                    current = current.Next;
                }
            }
            return result;
        }
        public string SearchNodeDepartment(string searchNode)
        {
            Node current = Head;
            string result = string.Empty;
            //go through list and search for data string entered and return found Node
            // if not found return search string not found
            while (current != null)
            {
                if (current.Employee.department == searchNode)
                {
                    result = "Found " + current.Employee.ToString();
                    return result;
                }
                if (current.Employee.department != searchNode)
                {
                    result = searchNode + " Not found";
                    current = current.Next;
                }
            }
            return result;
        }

        public string DeleteNode(string deleteNode)
        {
            string result = string.Empty;
            // if head is null return, 
            if (Head == null) 
            {
                result = " There is no data in list"; 
                return result; 
            }
            //if head data = delete string change head to the next node
            if (Head.Employee.Name.Contains(deleteNode))
            {
                Head = Head.Next;
                result = "Deleted Employee";
                return result;
            }
            // loop through list until string matches data, then reset head
            Node current = Head;
            while (current.Next.Employee.Name != deleteNode)
            {
                current = current.Next;
            }
            if (current.Next.Employee.Name == deleteNode)
                {
                    current.Next = current.Next.Next;

                    result =  "Deleted Employee";
                    return result;
                }           
            return result;
        }     

        public decimal Salary()
        {
            List<decimal> list = new List<decimal>();
            Node current = Head;
            // go through list and print until list is empty
            while (current != null)
            {
                //decimal value = decimal.Parse(current.Employee.salary, CultureInfo.InvariantCulture);
                list.Add(current.Employee.salary);
                //Console.WriteLine(value);
                current = current.Next;
            }
            decimal result = list.Average();
            return result;
        }
    }
}

