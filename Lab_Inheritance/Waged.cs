using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance
{
    internal class Waged : Employee
    {
        private double rate;

        public double Rate
        {
            get { return rate; }
        }

        private double hours;
        public double Hours
        {
            get { return hours; }
        }


        public Waged(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
            this.rate = rate;
            this.hours = hours;
        }

        //public double getPay()
        //{
        //    double rate = this.rate;
        //}
        public override double Pay
        {
            get
            {
                double pay;
                double rate = this.Rate;
                double hours = this.Hours;

                if (hours > 40)
                {
                    double overtimeHours = hours - 40;
                    double overtimePay = overtimeHours * (rate * 1.5);

                    pay = rate * 40;
                    pay += overtimePay;
                }
                else
                {
                    pay = rate * hours;
                }

                return pay;
            }
        }
    }
}
