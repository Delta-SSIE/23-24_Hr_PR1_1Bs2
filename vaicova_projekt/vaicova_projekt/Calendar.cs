using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaicova_projekt
{
    internal class Calendar
    {
        List<Part> taskList;

        public Calendar()
        {
            taskList = new List<Part>();
        }

        public void AddTasks(Part task)
        {
            taskList.Add(task);
        }

        public void ShowAllTasks()
        {
            foreach (Part task in taskList)
            {
                task.Vypis();
            }
        }

        public void DeleteTask(string taskName)
        {
            for (int i = 0; i < taskList.Count; i++)
            {
                if (taskList[i].getTask() == taskName)
                {
                    taskList.RemoveAt(i);
                    return;
                }
            }
        }

        public void DeleteAllTasks()
        {
            taskList.Clear();
        }
    }
}
