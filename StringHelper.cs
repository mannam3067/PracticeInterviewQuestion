using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewQuestions
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inputString)
        {
            if (inputString.Trim().Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ?
                    char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }

            return inputString;
        }


        public static IEnumerable<int> LinqWrappermethod()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers, n => n % 2 == 0);
            return EvenNumbers.ToList();
        }

        public static void Test3(this ExtensionMethod extensionMethod, int i)
        {
            Console.WriteLine("Test 3" + i);
        }
        public static long Factorial(this Int32 X)
        {
            if (X == 1)
                return 1;
            if (X == 2)
                return 2;
            else
                return X * Factorial(X - 1);
        }

        public static string ToProper(this String oldstr)
        {
            if (oldstr.Trim().Length > 0)
            {
                string newstr = null;
                oldstr = oldstr.ToLower();
                string[] sarr = oldstr.Split(' ');
                foreach (string item in sarr)
                {
                    char[] carr = item.ToCharArray();
                    carr[0]=Char.ToUpper(carr[0]);                   
                    if (newstr == null)
                        newstr += new string(carr);
                    else
                        newstr += " " + new string(carr);
                    
                }
                return newstr;
            }
            return oldstr;
        }
    }
}
