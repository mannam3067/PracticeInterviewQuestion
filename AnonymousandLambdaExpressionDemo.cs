using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewQuestions
{
    class AnonymousandLambdaExpressionDemo
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("sampe1");
            names.Add("sample2");
            names.Add("Sample3");

            string result = names.Find(SearchName);

            string result1 = names.Find(delegate(string obj) { return obj.Equals("Sample3"); });

            string result2 = names.Find(f=>f.ToLower()=="sample3".ToLower());

            if (result==null) { Console.WriteLine("Name Not Found"); } else { Console.WriteLine("Name found..."); }
            if (result1 == null) { Console.WriteLine("Anonymous Name Not Found"); } else { Console.WriteLine("Anonymous Name found..."); }
            if (result2 == null) { Console.WriteLine("Lambada Name Not Found"); } else { Console.WriteLine("Lambada Name found..."); }
            Console.ReadKey();
        }
        private static bool SearchName(string obj)
        {
            return obj.Equals("Sample3");
        }
    }
}
