using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaicova_projekt
{
    internal class Part
    {
        private string TaskName;
        private int Day;
        private int Month;
        private string Notes;

        public void setTask(string TaskName)
        {
            this.TaskName = TaskName;
        }
        public void setDay(int Day)
        {
            this.Day = Day;
        }
        public void setMonth(int Month)
        {
            this.Month = Month;
        }
        public void setNotes(string Notes)
        {
            this.Notes = Notes;
        }

        public string getTask()
        {
            return TaskName;
        }
        public int getDay()
        {
            return Day;
        }
        public int getMonth()
        {
            return Month;
        }
        public string getNotes()
        {
            return Notes;
        }

        public Part(string TaskName, int Day, int Month, string Notes)
        {
            this.TaskName = TaskName;
            this.Day = Day;
            this.Month = Month;
            this.Notes = Notes;
        }

        public void Vypis()
        {
           
                Console.WriteLine(TaskName);
        }
    }
}
