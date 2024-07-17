using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.UI
{
    public static class TaskMGR
    {
        public static List<Task> tasklist = new List<Task>();

        public static void Update()
        {
            foreach (Task task in taskmgr)
            {
                task.Run();
            }
        }

        public static void Start(Task task)
        {
            TaskMGR.Add(task);
            task.Start();
        }

        public static void Stop(Task task)
        {
            TaskMGR.Remove(task);
        }
    }
}