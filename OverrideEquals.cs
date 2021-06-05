using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewQuestions
{
    class OverrideEquals
    {
        static void Main(string[] args)
        {

            int i = 10;
            int j = 10;
            //we can convert general datatype from int to string using boxing and unboxing 
            //but we cann't convert custom datatype 
            //so we need to ovverride the tostring method to print the custom type object data
            Console.WriteLine(i.ToString());

            //using equal operator and equal method to comparing 2 general data type data but we can't get exact output using              
            //equal operator and equal method so we must ovveride equla method and check obj!=null,the second both the object type should be same type then we can compare the two objects data

            Console.WriteLine(i==j);
            Console.WriteLine(i.Equals(j));

            CustomerEqual c1 = new CustomerEqual();
            c1.FirstName = "mallikarjuna";
            c1.SecondName = "mallikarjuna";
            CustomerEqual c2 = c1;
            //print the custom data type data using ovveride tostring()

            Console.WriteLine(c1.ToString());

            Console.WriteLine("==================");
            Console.WriteLine(c1 == c2);  //result =true becz both the object reference variable pointing to the same object so reference equality and value equality true
            Console.WriteLine(c1.Equals(c2)); // reference equality and value equality are same 
            //Since  c1 and c2 both refer to the same object the reference equality and value equality is true
            Console.WriteLine("========================");

            CustomerEqual c3 = new CustomerEqual();
            c3.FirstName = "mallikarjuna";
            c3.SecondName = "mallikarjuna";

            Console.WriteLine(c1 == c3);//return false because c1 and c3 referring to different objects
            Console.WriteLine(c1.Equals(c3));//retuen false inspite of the values across c1 and c2 beign same hence make secnce to override the Equal() method to return true

            CustomerEqual c4 = new CustomerEqual();
            c4.FirstName = "mallikarjuna";
            c4.SecondName = "mallikha";

           
            Console.WriteLine("=========================");
            Console.WriteLine(c1.Equals(c4));


            Console.ReadLine();
        }
    }
    public class CustomerEqual
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public override string ToString()
        {
            return this.FirstName + "," + this.SecondName;
        }
        public override bool Equals(object obj)
        {

            //make sure the passed in object is not null and can be casted to the type we are comparing
            if (obj == null)
            {
                return false;
            }
            if (!(obj is CustomerEqual))
            {
                return false;
            }

            return this.FirstName == ((CustomerEqual)obj).FirstName && this.SecondName == ((CustomerEqual)obj).SecondName;
        }
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ SecondName.GetHashCode(); 
        }
    }
}
