using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance
{
    internal class Wages : Employee
    {
        private double rate;

        public double Rate
        {
            get { return rate; }
        }

        public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
            this.rate = rate;
        }
    }
}
