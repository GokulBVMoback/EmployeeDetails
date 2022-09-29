using System;
using System.Reflection;
namespace EmployeeDetails
{
	public class Emp
	{
		private int _EmpId;
		private string _EmpName;
		private string _empAddress;
		private int _EmpAge;
		private int _Salary;
		private int _Benefits;
		private int salaryPerAnnum;
        private int _CTC;
		private int _absence;
		private int _absenDeduct;
		public int EmpId
		{
			set { _EmpId = value; }
			get { return _EmpId; }
		}
        public string EmpName
        {
            set { _EmpName = value; }
            get { return _EmpName; }
        }
		public string EmpAddress
		{
			set { _empAddress = value; }
			get { return _empAddress; }
		}
        public int EmpAge
        {
            set { _EmpAge = value; }
            get { return _EmpAge; }
        }
        public int Salary
        {
            set { _Salary = value; }
			get { return _Salary; }
        }
		public int Benefits
		{
			set { _Benefits = value; }
			get { return _Benefits; }	
		}
		public int CTC
		{
			get { return salaryPerAnnum+(_Benefits*12); }
		}
        public int SalaryPerAnnum()
		{
            salaryPerAnnum = Salary * 12;
			return salaryPerAnnum;
		}
		public int Absence
		{
			set { _absence=value; }
			get { return _absence; }
		}
		public int AbsenceDeduction()
		{
			_absenDeduct = Salary - (Absence * 100);
			return _absenDeduct;
		}
        public void SetEmpDetails()
		{
            Console.Write("Enter Employee Name:");
            EmpName = Console.ReadLine();
            Console.Write("Enter Employee Address:");
            EmpAddress = Console.ReadLine();
            Console.Write("Enter Employee Age:");
            EmpAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Salary:");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Benefits:");
            Benefits = Convert.ToInt32(Console.ReadLine());
        }

        public void GetEmpDetails()
		{
			Console.WriteLine("Employee Id:"+EmpId);
			Console.WriteLine("Employee Name:" + EmpName);
            Console.WriteLine("Address:" + EmpAddress);
            Console.WriteLine("Age:"+EmpAge);
			Console.WriteLine("Salary Per Annum:" + salaryPerAnnum);
			Console.WriteLine("CTC:"+CTC);
		}
	}
}