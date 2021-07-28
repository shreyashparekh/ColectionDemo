using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    //Don't want to create tables 
    enum Feedback 
    {
        Poor, Fair, Good, Excellent 
    };

    //Auto-increment by 1

    class Department
    {
        protected int Did { get; set; }
        //Protected is used within class and derived class
        protected string Dname { get; set; }
        protected string City { get; set; }

        internal Department(int Did,string Dname,string City)
        {
            Console.WriteLine("Department Constructor");
            this.Did = Did;
            this.Dname = Dname;
            this.City = City;
        }

       protected internal void DisplayDepartmentinfo()
        {
            Console.WriteLine("Did: {0} || Dname: {1}", Did, Dname);
                
        }
    }

    //Single Inheritance
    //Employee is Child or Derived Class 
    class Employee : Department

    {
        internal static string CompanyName = "LTI";
        internal int Eid { get; set; }
        internal String Name { get; set; }
        internal String City = "Pune";

        internal Employee(int Eid, string Name, int Did, String Dname,String City):base(Did,Dname,City)
        {
            Console.WriteLine("Employee Constructor");
            this.Eid = Eid;
            this.Name = Name;
        }

        internal void DisplayEmployeeinfo()
        {
            DisplayDepartmentinfo();
            Console.WriteLine("City is {0}", City);
            Console.WriteLine("Eid: {0} || Ename: {1} || feedback: {2}", Eid, Name, (int)Feedback.Excellent);

        }
    }


    class PartTimeEmployee : Employee
    {
        internal int hoursofwork { get; set; }

        internal int salary { get; set; }

        internal PartTimeEmployee(int Eid, string Name, int Did, String Dname, string City, int hoursofwork, int salary) : base(Eid, Name, Did, Dname, City)
        {
            this.hoursofwork = hoursofwork;
            this.salary = salary;
        }

        internal int MonthlySalary()
        {
            int Payment = hoursofwork * 30 * salary;
            return Payment;
        }
        /*
        ~PartTimeEmployee()
        {
            Console.WriteLine("PartTimeEmployee Destructor")
        }
        */
    }
    class MultiLevelInheritance
    {
        static void Main()
        {
            //Single Inheritance
            /* Employee employee = new Employee (1001,"SAI",101,"HR","Madurai");

             employee.DisplayEmployeeinfo(); */

            //Error : Since Protected
            //employee. DisplayDepartmentinfo();

            //Multilevel Inheritance

            PartTimeEmployee pt = new PartTimeEmployee(1001, "SAI", 101, "HR", "Madurai", 67, 200);
            pt.DisplayEmployeeinfo();
            Console.WriteLine("Monthly Salary: {0}", pt.MonthlySalary());

            GC.Collect();
            //Garbage Collector for destructors
          

        }
    }
}
