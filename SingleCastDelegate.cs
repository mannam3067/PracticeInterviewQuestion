using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewQuestions
{
    public delegate int DelAddTwoValues(int i, int j);
    public delegate string DelSayHello(string name);
    class SingleCastDelegate
    {
        public int AddTwoValues(int a,int b)
        {
            return a + b;
        }

        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {

            SingleCastDelegate singleCastDelegate = new SingleCastDelegate();

            //create the object for delegate beacause of delegate is args reference type
            DelAddTwoValues delAddTwoValues = new DelAddTwoValues(singleCastDelegate.AddTwoValues);
            Console.WriteLine(delAddTwoValues(100,400));
            DelSayHello delSayHello = new DelSayHello(SayHello);
            Console.WriteLine(delSayHello("Arjun"));
            //Step1:creating object and call the instancemethods
            //int value=singleCastDelegate.AddTwoValues(100,200);
            //Console.WriteLine(value);
            //string str=SingleCastDelegate.SayHello("mallikharjuna");
            //Console.WriteLine(str);
            Console.ReadLine();
        }
    }
    
}
