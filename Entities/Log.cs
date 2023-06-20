using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Entities
{
    public  class Log
    {
        public Guid Id { get; set; }
        public DateTime? TimeStamp { get; set; }
        public uint TimeShift { get; set; } // 0, 1, 3,4
        public Log() { }
        public Log(DateTime timestamp, uint timeShift)
        {
            this.Id = Guid.NewGuid();
            this.TimeStamp = timestamp;
            this.TimeShift = timeShift;
        }

    }
}
