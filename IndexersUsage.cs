using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewQuestions
{
    class IndexersUsage
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine(company[0001]);
            Console.WriteLine(company["Male"]);

            // Set accessor of string indexer is invoked to change the gender
            // all "Male" employees to "Female"

            company["male"] = "Arjun reddy";

            Console.WriteLine(company["Male"]);
            Console.ReadLine();
        }
    }
}
