using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3._2
{
    abstract public class Employee
    {
        int Id;
        String Name;
        String Designation;
        int Experience;
        int Asalary;
        String jdate;

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string NAME
        {
            get { return Name; }
            set { Name = value; }
        }
        public int SALARY
        {
            get { return Asalary; }
            set { Asalary = value; }
        }
       
        public string DESIGNATION
        {
            get { return Designation; }
            set { Designation = value; }
        }
        public int EXPERIENCE
        {
            get { return Experience; }
            set { Experience = value; }
        }
        public string Joing_Date
        {
            get { return jdate; }
            set { jdate = value; }
        }
        public abstract void Annualsalary();
    }
    class HR : Employee
    {
        int id;
        String name;
        String design;
        int exp;
        int sal;
        String d;
        public HR(int Id, String Name, String Designation, int Experience, int Asalary, String jdate)
        {
            this.id=Id;
            this.name = Name;
            this.design = Designation;
            this.exp = Experience;
            this.sal = Asalary;
            this.d = jdate;

        }

        public override void Annualsalary()
        {
            Console.WriteLine("Hr Details =" + id + " " + name + " " + design + " " + exp + " " + sal + " " + d);
            int h = sal + (1000 * exp);
            Console.WriteLine("HR Annual Salary ="+" "+h);
        }
    }
    class Developer : Employee
    {
        int id;
        String name;
        String design;
        int exp;
        int sal;
        String d;
        public Developer(int Id, String Name, String Designation, int Experience, int Asalary, String jdate)
        {
            this.id = Id;
            this.name = Name;
            this.design = Designation;
            this.exp = Experience;
            this.sal = Asalary;
            this.d = jdate;
        }
        public override void Annualsalary()
        {
            Console.WriteLine("Developer Details ="+id+" "+name+" "+design+" "+exp+" "+sal+" "+d);
            int s = sal + (2000 * exp);
            Console.WriteLine("Developer Annual Salary ="+" "+s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {            
            HR a = new HR(1, "XYZ", "HR", 4, 8000, "1/12/2013");
            Developer b = new Developer(1, "ABC", "Developer", 5, 8000, "1/12/2012");
            a.Annualsalary();
            b.Annualsalary();          
            
        }
    }
}