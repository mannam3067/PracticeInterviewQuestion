using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewQuestions
{
    class CanHaveAbstractConstructor
    {
        //An abstract class constructor can also be used to execute code 
        //that is relevant for every /*child class*/. This prevents duplicate code.
        public static void Main()
        {
            CorporateCustomer1 CC = new CorporateCustomer1();
            //here 1st execute the base class costrucor then execute the derived class contructor
            Console.WriteLine(CC.Id1);

            SavingsCustomer1 SC = new SavingsCustomer1();
            Console.WriteLine(SC.Id1);

            Console.ReadLine();
        }


       
    }
    public abstract class Customer1
    {
        //we would provide a constructor for an abstract class if we want to initialise 
        //certain fields of the abstract class  before the instantiation of a child-class takes place.

        //Before an instance of CorporateCustomer or SavingsCustomer class is created, a Globally Unique
        //Identifier(GUID) must be stored in the _id field of the abstract class. This can be achieved 
        //using abstract class constructor as shown below.Since initialisation is done in the base abstract 
        //Customer class, we don't have to duplicate this logic in CorporateCustomer and SavingsCustomer classes.

        //If we were to move the initialisation code to respective derived classes, the design would look as shown below.Notice the amount of duplicate code.
       //we cannot create an instance of an abstract class, we can create instances of the classes that
       // are derived from the abstract class. So, when an instance of derived class is created, 
       //the parent abstract class constructor is automatically called.
        public Customer1()
        {
            this._id = Guid.NewGuid();
        }

        public Guid Id1
        {
            get
            {
                return this._id;
            }
        }

        private Guid _id;

        // Other abstract members
        // public abstract void Save();
    }
    public class CorporateCustomer1:Customer1
    {
       
    }
    public class SavingsCustomer1:Customer1
    {
       
    }
}
