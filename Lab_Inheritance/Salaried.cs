using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance
{
    internal class Salaried:Employee
    {
        private double salary;

        public double Salary {       
            get
            {
                return salary;
            }
        }


        public override double Pay
        {
            get
            {
                return salary;
            }
        }


        public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
            this.salary = salary;
        }

        //public Salaried(string id, string name, double salary)
        //{
        //    this.id= id;
        //    this.name= name;
        //    this.salary= salary;
        //}




        //public double getPay()
        //{ return salary; }
    }
}
