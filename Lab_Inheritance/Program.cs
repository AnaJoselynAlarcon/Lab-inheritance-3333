using System;
using System.IO;
//this is important to provide the funcitonality that we need to input and Output.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Data.SqlClient;

namespace Lab_Inheritance
{
    /// <summary>
    /// Lab 2 : INHERITANCE
    /// </summary>
    /// <remarks> Author: Ana Alarcon</remarks>
    /// <remarks>Date: January 2023 </remarks>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Relative path to employees.txt file
            string path = "employees.txt";

            // Get lines/rows in file as string array
            string[] lines = File.ReadAllLines(path);

            //lines = File.ReadAllLines(path);

            // Create list that holds any type of Employee
            List<Employee> employees = new List<Employee>();

            // Loop through each line/row
            foreach (string line in lines)
            {
                //this is to loop on everything
                //find a method to split
                //first create a variable bc it will return a string array
                // Extract each part/cell from line/row
                string[] parts = line.Split(':');
                //we use single quotes for a char, not double quotes


                //now we can start using the elements of the array
                string id = parts[0];
                string name = parts[1];
                string address = parts[2];
                string phone = parts[3];
                long sin = long.Parse(parts[4]);
                string dob = parts[5];
                string dept = parts[6];







                // --------Get first digit of ID--------
                //substring is to take a part of a string and loop on only that part,
                //create a variable to do it
                string firstDigit;
                firstDigit = id.Substring(0, 1);

                //if (firstDigit =="0" || firstDigit == "2" || firstDigit == "3" || firstDigit == "4")
                //{
                //-------------THIS IS A LOT OF CODE!!
                //}

                // using math: find out how many digits, and etc

                //we'll need to change it first to an INT bc is a STRING NOW
                int firstDigitNum = int.Parse(firstDigit);

                if (firstDigitNum >=0 && firstDigitNum <=4)
                {
                    //Salaried
                    double salary = double.Parse(parts[7]);

                    // Create instance of Salaried
                    Salaried salaried;

                    //create a variabole w data type salary
                    salaried = new Salaried(id, name, address, phone, sin, dob, dept, salary);

                    //--------------IDK why is 


                    // Add to employees
                    employees.Add(salaried);

                    //we need to fill a list
                }




                else if (firstDigitNum >=5 || firstDigitNum <=7) 
                {
                    //Waged
                    double rate = double.Parse(parts[7]);
                    double hours = double.Parse(parts[8]);

                    // TODO: Create Waged instance and add it to employee list.
                    Waged waged = new Waged(id, name, rate);
                    employees.Add(waged);

                    
                }
                else if (firstDigitNum >=8 && firstDigitNum <=9)
                {
                    //Part Time
                    double salary = double.Parse(parts[7]);

                    PartTime partTime;

                    //Create variables for hours and rate
                    double rate = double.Parse(parts[7]);
                    double hours = double.Parse(parts[8]);

                    //PartTime instance and add it to employee list.
                    PartTime partTime = new PartTime(id, name, rate, hours);
                    employees.Add(partTime);
                }

                


            }


            //string[] lines = [];

            //List<string> lines2 = new List<string>(lines);




            /**
                 *TODO:
                 *-Determine average weekly pay of all employees.
                 *-Determine highest paid waged employee.
                 *-Determine lowest paid salaried employee.
                 *-Determine percentage of employees that are salaried, waged, and part - time.
                 */



            double weeklyPaySum = 0;

            // It's okay to use loop through employees multiple times.
            foreach (Employee employee in employees)
            {
                if (employee is PartTime partTime)
                {
                    //downcast to change employee into part time

                    //PartTime partTime = (PartTime)employee;

                    double rate = partTime.Rate;
                    double hours = partTime.Hours;

                    double pay = rate * hours;
                    weeklyPaySum += pay;
                }
                else if (employee is Waged waged)
                {
                    double rate = waged.Rate;
                    double hours = waged.Hours;

                    if(hours >40)
                    {
                        //create variable 
                        double overtimeHours = hours - 40;

                        //separate variable to calculate overtime pay
                        double overtimePay = overtimeHours * (rate * 1.5);

                        //we'll need to assume that they have 40 hours 
                        double pay = rate * 40;

                        weeklyPaySum += overtimePay + pay;
                    }
                    else
                    {
                        double pay = rate + hours;
                        weeklyPaySum += pay;
                    }
                }
                else if(employee is Salaried salaried)
                {
                    double pay = salaried.Salary;

                    weeklyPaySum += pay;

                }
            }



            //------------CALCULATE AVERAGE PAY
            double averageWeeklyPay = weeklyPaySum / employees.Count;
            Console.WriteLine(string.Format("Average weekly pay: {0:C2}" , averageWeeklyPay));
        }
    }
}
//avg 117022