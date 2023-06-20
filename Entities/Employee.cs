using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Entities
{
    public class Employee
    {
        public Guid IdentityId { get; set; }
        public string? FullName { get; set; }
        public string? Position { get; set; }
        public string? CardNo { get; set; }
        public IList<Log>?  Logs { get; set; }
        public Employee() { }
        public Employee (string fullName, string? position, string? cardNo)
        {
            this.IdentityId = Guid.NewGuid();
            this.FullName = fullName;
            this.Position = position;
            this.CardNo = cardNo;
            this.Logs = new List<Log>();
        }
    }
}
