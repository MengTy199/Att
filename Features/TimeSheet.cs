using AttendanceManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Features
{
    public  class TimeSheet
    {
        public List<Employee>? Employees { get; set; }
        public TimeSheet() { 
            Employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee, string cardNo)
        {
            if (string.IsNullOrEmpty(employee.FullName) || string.IsNullOrEmpty(employee.Position) || string.IsNullOrEmpty(employee.CardNo))
            {
                throw new ArgumentException("Please provide all employee data!");
            }
            if (Employees!.Exists(e => e.CardNo == cardNo))
            {
                throw new ArgumentException("Card number already exists!");
                

            }
            else
            {
                Employees?.Add(employee);
            }
           
        }

        public void UpdateEmployee(string IdentityId, string Fullname, string Position)
        {
            if (string.IsNullOrEmpty(Fullname) || string.IsNullOrEmpty(Position))
            { //Check for Empty data
                throw new ArgumentException("Please provide all employee data!");
            }
            int foundIndex = Employees!.FindIndex(em => em.IdentityId == new Guid(IdentityId));
            Employees[foundIndex].FullName = Fullname;
            Employees[foundIndex].Position = Position;
            
        }

        //delete
        public void DeleteEmployee(string IdentityId, string Fullname, string Position)
        {
            if (string.IsNullOrEmpty(Fullname) || string.IsNullOrEmpty(Position))//check for emty data
            {
                throw new ArgumentException("Please provide all employee data!");
            }

            int foundIndex = Employees!.FindIndex(em => em.IdentityId == new Guid(IdentityId));
            Employees[foundIndex].Position = Position;
            Employees[foundIndex].FullName = Fullname;
            Employees.RemoveAt(foundIndex);
            
        }
        public void LogEmployee(string cardNo, Log logInfo)
        {
            if(string.IsNullOrEmpty(cardNo))//check  for empty card
            {
                throw new ArgumentException("Card No is empty!");
            }

            int foundIndex = Employees!.FindIndex(emp => emp.CardNo == cardNo.Trim());
            if(foundIndex < 0)
            {
                throw new ArgumentException($"Card No {cardNo} not found in employee list.");

            }
            Employees[foundIndex].Logs!.Add(logInfo);
        }

        public List<EmployeeView> GetAllEmployee()
        {
            //using LINQ to select data without log property
            return Employees!.Select(emp => new EmployeeView(){
                    IdentityId = emp.IdentityId,
                    FullName = emp.FullName,
                    Position = emp.Position,
                    CardNo = emp.CardNo
            }).ToList();
        }

        public List<Employee> GetAllEmployee(bool isSimpleVersion)
        {
            return Employees!;
        }

    }
}
