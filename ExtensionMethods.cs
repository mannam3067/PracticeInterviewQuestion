using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewQuestions
{

    public class ExtensionMethod
    {
        public void Test1()
        {
            Console.WriteLine("Test 1");
        }
        public void Test2()
        {
            Console.WriteLine("Test 2");
        }
    }
    public class ExtensionMethods
    {
        
        static void Main(string[] args)
        {
            ExtensionMethod extensionMethod = new ExtensionMethod();
            extensionMethod.Test1();
            extensionMethod.Test2();
            extensionMethod.Test3(10);

            //creating the extension method on class
            string str = "mallikharjna";
            string result = str.ChangeFirstLetterCase();
            Console.WriteLine(result);
            

            //Add the extension method to struct
            int i = 8;
            long facResult = i.Factorial();
            Console.WriteLine("factorial of {0} is:{1}",i,facResult);

            //add the extension methods on scealed class
            string str1 = "Hello hOW ArE YoU";
            //str1 = str1.ToUpper();
            //str1 = str1.ToLower();
            string strresult = str1.ToProper();
            Console.WriteLine(strresult);

            Console.ReadLine();

            //Extension Methods:-
            //This is a new feature that has been added in CSharp 3.0

            //inheritence is a mechanism using which we can extend the functionalities of a class.

            //we can't apply inheritence on scealed classes.
            //if the original type(base class) is not a class and it's a structure.

            //it's a mechanism of adding new methods into an existing class or 
            //structure also with out modifying the source code of the original type
            //and in this process we don't require any permission from original type
            //and the original type doesn't require any re-compilation.

            //Extension methods are defined as static but once they are bounded with any
            //class or structure they turn into non-static

            //if an extension method is defined with the same name and signature of an
            //existing method in the class,then extension method will not be called
            //and the preference always goes to the original method only

            //the first parameter of an extension method should be the name of the
            //type of which the method has to be bound with and this parameter is not
            //taken into consideration while calling the extension method.

            //An extension method should have one and only one binding parameter and
            //it should be in the first place of the parameter list

            //note:- if an existion method is  definedwith n parameter then while
            //calling it there will be n-1 parameter only because the binding parameter excluded.





        }
    }
}
