using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewQuestions
{
    public delegate int DelAddTwoValues(int i, int j);
    public delegate string DelSayHello(string name);
    public delegate void DelGetArea(double width, double height);
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

        public void GetArea(double width,double height)
        {
            Console.WriteLine(width*height);
        }

        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine((2*(width * height)));
        }
        static void Main(string[] args)
        {

            SingleCastDelegate singleCastDelegate = new SingleCastDelegate();
            //singleCastDelegate.GetArea(100, 200);
            //singleCastDelegate.GetPerimeter(300, 400);
            //create the object to MulticastDelegate 
            //DelGetArea multiCastdDlGetArea = new DelGetArea(singleCastDelegate.GetArea);
            //multiCastdDlGetArea.Invoke(200, 400);
            DelGetArea multiCastdDlGetArea = singleCastDelegate.GetArea;
            multiCastdDlGetArea += singleCastDelegate.GetPerimeter;
            multiCastdDlGetArea.Invoke(200, 400);

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
