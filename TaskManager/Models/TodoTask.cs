using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class TodoTask
    {
        public TodoTask(int? TodoTaskID, string Title, string DateAndTime)
        {
            this.TodoTaskID = TodoTaskID ?? 0;
            this.Title = Title ?? "No Title Added";
            this.DateAndTime = DateAndTime ?? DateTime.Now.ToShortDateString();
        }
        public int TodoTaskID { get; set; }
        public string Title { get; set; }
        public string DateAndTime { get; set; }
    }
}
