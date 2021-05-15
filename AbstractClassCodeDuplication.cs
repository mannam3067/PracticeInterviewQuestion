using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewQuestions
{
    class AbstractClassCodeDuplication
    {        
        static void Main(string[] args)
        {
            CorporateCustomer CC = new CorporateCustomer();
            Console.WriteLine(CC.Id);

            SavingsCustomer SC = new SavingsCustomer();
            Console.WriteLine(SC.Id);

            Console.ReadLine();
        }
       
    }
    public abstract class Customer
    {
        public abstract Guid Id { get; }

        // Other abstract members
        // public abstract void Save();
    }

    public class CorporateCustomer : Customer
    {
        public CorporateCustomer()
        {
            this._id = Guid.NewGuid();
        }

        private Guid _id;

        public override Guid Id
        {
            get { return this._id; }
        }
    }

    public class SavingsCustomer : Customer
    {
        public SavingsCustomer()
        {
            this._id = Guid.NewGuid();
        }

        private Guid _id;

        public override Guid Id
        {
            get { return this._id; }
        }
    }
}
