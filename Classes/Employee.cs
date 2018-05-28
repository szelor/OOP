using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee
    {
        private int empID;
        private string loginName;
        private string password;
        private string department;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LoginName { get; set; }

        public string Department { get; set; }

        public int EmployeeID
        {
            get { return empID; }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 6)
                {
                    password = value;
                }
                else
                {
                    throw new Exception("Password must be at least 6 characters");
                }
            }
        }
        public void Login(string loginName, string password)
        {
            if (loginName == "Jones" & password == "mj")
            {
                empID = 1;
                department = "HR";
            }
            else
            {
                throw new Exception("Login incorrect.");
            }
        }
        public Employee(int empID)
        {
            if (empID == 1)
            {
                LoginName = "Smith";
                Password = "js";
                Department = "IT";
                Name = "Jerry Smith";
            }
            else
            {
                throw new Exception("Invalid Employee ID");
            }
        }
        public int AddEmploye(string loginName, string password, string department, string name)
        {
            empID = 2;
            LoginName = loginName;
            Password = password;
            Department = department;
            Name = name;
            return empID;
        }
        
        public int AddEmploye(string department, string name)
        {
            empID = 3;
            Department = department;
            Name = name;
            return empID;
        }

        public Employee() => empID = -1;
    }
}
