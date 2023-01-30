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

        public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate)
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
