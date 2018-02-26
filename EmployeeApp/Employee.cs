using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
       
        
        // methods
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);

        }

        // get
        public string GetName()
        {
            return empName;
        }
        // set
        public void SetName(string name)
        {
            // Do a check on incoming value before making assignment
            if (name.Length > 15)
                Console.WriteLine("Error! Name must be less than 16 characters!");
            else
                empName = name;
        }
        // c# properties
        public string Name
        {
            get
            {
                return empName;
            }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name must be less than 16 characters!");
                else
                    empName = value;
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        
    }
}
