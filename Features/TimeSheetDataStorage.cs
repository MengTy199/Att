using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Features
{
    public  class TimeSheetDataStorage
    {
        public static void SaveTimeSheetToStorage(TimeSheet AttenList)
        {
            var jsonString = JsonSerializer.Serialize<TimeSheet>(AttenList);
            File.WriteAllText("timesheet.json", jsonString);
        }
        public static TimeSheet LoadTimeSheetFromStorage()
        {
/*            using FileStream stream = File.OpenRead("timesheets.json");*/
            using FileStream stream = File.Open("timesheet.json", FileMode.OpenOrCreate);
            if (stream.Length > 0)
            {
                var loadList = JsonSerializer.Deserialize<TimeSheet>(stream);
                return loadList!;
            }
            return new TimeSheet();
        }
    }
}
