using PracticeInterviewQuestions.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewQuestions
{
    class SampleDemoDictionary
    {
        static void Main(string[] args)
        {
            // Create a Dictionary, CustomerID is the key. Type is int
            // Customer object is the value. Type is Customer
            Dictionary<int, CustomerDetails> dictionaryCustomers = new Dictionary<int, CustomerDetails>();

            List<CustomerDetails> customerDetails = new List<CustomerDetails>
            {
                new CustomerDetails{ID = 101, Name = "Mallikharjuna",    Salary = 50000 },
                new CustomerDetails{ID = 102, Name = "Arjun",    Salary = 5000 },
                new CustomerDetails{ID = 103, Name = "Saidulu",    Salary = 55000 }
            };

            CustomerDetails customerDetails1 = new CustomerDetails
            {
                ID=101,
                Name="satish",
                Salary=75000
            };
            foreach (CustomerDetails item in customerDetails)
            {
                dictionaryCustomers.Add(item.ID, item);
            }

            Console.WriteLine("--------------------------------------------------");
            // It is also possible to loop thru each key/value pair in a dictionary
            Console.WriteLine("All customer keys and values in customer dictionary");
            foreach (KeyValuePair<int, CustomerDetails> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                CustomerDetails cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            Console.WriteLine("--------------------------------------------------");

            // You can also use implicitly typed variable VAR to loop thru each key/value pair in a dictionary. But try
            // to avoid using var, as this makes your code less readable
            Console.WriteLine("All customer keys and values in customer dictionary");
            foreach (var customerKeyValuePair1 in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + customerKeyValuePair1.Key);
                CustomerDetails cust = customerKeyValuePair1.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            Console.WriteLine("--------------------------------------------------");

            // To get all the keys in the dictionary
            Console.WriteLine("All Keys in Customer Dictionary");
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("--------------------------------------------------");

            // To get all the values in the dictionary
            Console.WriteLine("All Customer objects in Customer Dictionary");
            foreach (CustomerDetails customer in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }

            // If you try to add a key that already exists in the dictionary you 
            // will get an exception - An item with same key has already been 
            // added. So, check if the key already exists
            if (!dictionaryCustomers.ContainsKey(101))
            {
                dictionaryCustomers.Add(customerDetails1.ID, customerDetails1);
            }

            // When accessing a dictionary value by key, make sure the dictionary 
            // contains the key, otherwise you will get KeyNotFound exception.
            if (dictionaryCustomers.ContainsKey(110))
            {
                CustomerDetails cus = dictionaryCustomers[110];
            }
            else
            {
                Console.WriteLine("Key does not exist in the dictionary");
            }

            Console.ReadLine();
        }


    }
}
