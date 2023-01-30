using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance
{
    internal class Employee
    {
        protected string id;
        protected string name;
        protected string address;
        protected string phone;
        protected long sin;
        protected string dob;
        protected string dept;


        public string Id
        {
            get { return id; }
        }



        public string Name
        {
            get { return name; }
        }



        public string Address
        {
            get { return address; }
        }

        public string Phone
        {
            get { return phone; }
        }

        public long Sin
        {
            get { return sin; }
        }

        public string Dob
        {
            get { return dob; }
        }

        public string Dept
        {
            get { return dept; }
        }
        /// <summary>
        /// no-Arg constructor
        /// </summary>
        public Employee()
        {

        }

        public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
        }

        //public override string ToString()
        //{
        //    return id;
        //}








    }
}
}
