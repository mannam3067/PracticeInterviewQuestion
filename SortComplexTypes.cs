using System;
using System.Collections.Generic;
using PracticeInterviewQuestions.Model;

namespace PracticeInterviewQuestions
{
    class SortComplexTypes
    {
        static List<CustomerDetails> customerDetails = new List<CustomerDetails>
        {
            new CustomerDetails{ID = 101, Name = "Mallikharjuna",    Salary = 5000 },
                new CustomerDetails{ID = 102, Name = "Arjun",    Salary = 50000 },
                new CustomerDetails{ID = 103, Name = "Saidulu",    Salary = 55000 }
        };

        public static int CompareCustomerDetails(CustomerDetails x, CustomerDetails y)
        {
            return x.Name.CompareTo(y.Name);
        }
        static void Main(string[] args)
        {
            //Step1
            Console.WriteLine("Sorting the items using IComparable<T> interface on model class and CompareTo");
            //customerDetails.Sort();

            //Step2
            Console.WriteLine("Sorting the items using IComparer<T x> interface and Compare(T x, T y) method");
            SortBySalary sortBySalary = new SortBySalary();
            customerDetails.Sort(sortBySalary);
            foreach (CustomerDetails item in customerDetails)
            {
                Console.WriteLine("Id={0} Name={1} Salary={2}", item.ID, item.Name, item.Salary);
            }

            //Step 3 process to sort the items using Delegate
            Console.WriteLine("Sorting the items using delegate syntax");
            Comparison<CustomerDetails> custDetailsDelegate = new Comparison<CustomerDetails>(CompareCustomerDetails);
            customerDetails.Sort(custDetailsDelegate);
            foreach (CustomerDetails item in customerDetails)
            {
                Console.WriteLine("Id={0} Name={1} Salary={2}", item.ID, item.Name, item.Salary);
            }

            //Step 4
            Console.WriteLine("Sorting the items using delegate sort syntax");
            customerDetails.Sort(delegate (CustomerDetails x, CustomerDetails y) { return (x.Name.CompareTo(y.Name)); });
            foreach (CustomerDetails item in customerDetails)
            {
                Console.WriteLine("Id={0} Name={1} Salary={2}", item.ID, item.Name, item.Salary);
            }
            //Step5
            Console.WriteLine("Sorting the items using lambda expression ");
            customerDetails.Sort((x, y) => x.Salary.CompareTo(y.Salary));
            foreach (CustomerDetails item in customerDetails)
            {
                Console.WriteLine("Id={0} Name={1} Salary={2}",item.ID, item.Name, item.Salary);
            }
            Console.ReadKey();

           
        }

    }
    class SortBySalary : IComparer<CustomerDetails>
    {
        public int Compare(CustomerDetails x, CustomerDetails y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
}
