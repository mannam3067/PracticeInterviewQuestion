using PracticeInterviewQuestions.Model;
using System;
using System.Collections.Generic;

namespace PracticeInterviewQuestions
{
     class SampleDictionary
    {
         Dictionary<int, EmploeeDetails> dicti = new Dictionary<int, EmploeeDetails>();
        private static EmploeeDetails empdetails = new EmploeeDetails();


        private List<EmploeeDetails> employeeDetails = new List<EmploeeDetails>
        {
            new EmploeeDetails { ID = 101, Name = "mallikharjuna", Salary = 100000 },
            new EmploeeDetails { ID = 102, Name = "Satya", Salary = 200000 },
            new EmploeeDetails { ID = 103, Name = "sati", Salary = 300000 }

        };

        static void Main(string[] args)
        {
            SampleDictionary sampleDictionary = new SampleDictionary();

            foreach (EmploeeDetails item in sampleDictionary.employeeDetails)
            {
                sampleDictionary.dicti.Add(item.ID, item);
            }

            if(sampleDictionary.dicti.TryGetValue(101, out empdetails))
            {
                Console.WriteLine(empdetails.ID+""+empdetails.Name);
            }
            else
            {
                Console.WriteLine("there is record to find from the list");
            }

            Console.ReadKey();
        }


    }



}
