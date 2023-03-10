using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance
{
    /// <summary>
     /// <summary>
     /// Represents a Part-Time Employee
     /// </summary>
     /// <remarks>Author: Ana Alarcon</remarks>
     /// <remarks>Date: Jan 30, 2023</remarks>
    internal class PartTime : Employee
    {
        /// <summary>
        /// Field of PartTime Employee
        /// </summary>
        private double rate;

        /// <summary>
        ///Properties
        /// </summary>
        public double Rate
        {
            get { return rate; }
        }
        private double hours;
        public double Hours
        {
            get { return hours; }
        }

        //public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.address = address;
        //    this.phone = phone;
        //    this.sin = sin;
        //    this.dob = dob;
        //    this.dept = dept;
        //    this.rate = rate;
        //}

        public override double Pay
        {
            get
            {
                double rate = this.Rate;
                double hours = this.Hours;

                double pay = rate * hours;

                return pay;
            }
        }


        public PartTime(string id, string name, double rate, double hours)
        {
            this.id = id;
            this.name = name;
            this.rate = rate;
            this.hours = hours;
        }

    }
}
