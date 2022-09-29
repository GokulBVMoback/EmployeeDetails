using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



namespace EmployeeDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empCount;
            Console.Write("How many Employee Details you want to add:");
            empCount=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=empCount; i++)
            {
                Emp emp= new Emp();
                emp.EmpId = i+22000;
                emp.SetEmpDetails();
                emp.SalaryPerAnnum();
                emp.GetEmpDetails();
            }
        }
    }
}
