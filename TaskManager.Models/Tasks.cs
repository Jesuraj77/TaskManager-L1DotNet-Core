using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Models
{
  public  class Tasks
    {
        public  int TaskId { get; set; }
        public int ParentTaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }

    }
}
