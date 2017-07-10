using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public static List<Employees> CompanyEmployees = new List<Employees>();

        // Create a method that allows external code to add an employee
        public void addEmployee(Employees emp)
        {
            CompanyEmployees.Add(emp);
        }
        // Create a method that allows external code to remove an employee

        public void removeEmployee(Employees emp)
        {
            CompanyEmployees.Remove(emp);
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime date){
            Name = name;
            CreatedOn = date;
        }

        public void PrintEmpList(){
            foreach (Employees e in CompanyEmployees) {
                Console.WriteLine(e.Name + " " + e.JobTitle);
            }
        }
    }

    public class Employees
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public DateTime DateStarted { get; set; }

        public Employees(string name, string title, DateTime date)
        {
            Name = name;
            JobTitle = title;
            DateStarted = date;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Company MattersCom = new Company("Matt's Better Company LLC. ", DateTime.Now);

            Employees Matt = new Employees("Matt", "Software Developer", DateTime.Now);
            Employees Chaz = new Employees("Chaz", "Worster Software Developer", DateTime.Now);
            Employees Json = new Employees("Json", "MEhher Software Developer", DateTime.Now);

            MattersCom.addEmployee(Matt);
            MattersCom.addEmployee(Chaz);
            MattersCom.addEmployee(Json);
            MattersCom.removeEmployee(Json);


            Console.WriteLine(MattersCom.Name, MattersCom.CreatedOn);
            MattersCom.PrintEmpList();


        }
    }
}
