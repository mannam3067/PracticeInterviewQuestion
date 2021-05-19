using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewQuestions
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
    public class Company
    {
        List<Employee> employees = new List<Employee>
        { new Employee { EmployeeId=0001,Name="mallikharjuna",Gender="male"},
          new Employee { EmployeeId=0002,Name="Arjun",Gender="Male"},
          new Employee { EmployeeId=0003,Name="Mannam",Gender="FeMale"}

        };
        public string this[int employeeId]
        {
            get
            {
                return employees.FirstOrDefault(x => x.EmployeeId == employeeId).Name;
            }
            set
            {
                employees.FirstOrDefault(x => x.EmployeeId == employeeId).Name = value;
            }
        }

        public string this[string gender]
        {
            get
            {
                return employees.Count(x => x.Gender.ToLower() == gender.ToLower()).ToString();
            }
            set
            {
                foreach (var item in employees)
                {
                    if (item.Gender.ToLower() == gender.ToLower())
                    {
                        item.Gender = value;
                    }
                }
                
            }
        }
    }
}
