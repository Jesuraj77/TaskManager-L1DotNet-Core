using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Models;
namespace TaskManagerServices
{
   public class TaskService
    {

        public void AddTask(Tasks task)
        {
        }

        public void EndTask(Tasks task)
        {
        }

        public Tasks SearchTask(Tasks task)
        {
            Tasks tasks = new Tasks();
            return tasks;
        }


        public Tasks UpdateTask(int TaskId)
        {
            Tasks task = new Tasks();
            return task;
        }


        public List<Tasks> ViewTask()
        {
            List<Tasks> tasklist = new List<Tasks>();
            return tasklist;
        }


        public Tasks GetTaskById(int TaskId)
        {
            Tasks task = new Tasks();
            return task;
        }

    }
}
