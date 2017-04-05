using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Household_Chores.Models;
using System.Linq;

namespace Household_Chores.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        public ObservableCollection<MainTask> Tasks { get; set; }

        public MainViewModel()
        {
            Tasks = new ObservableCollection<MainTask>();
        }

        public MainViewModel(ObservableCollection<list> Lists)
        {
            Tasks = new ObservableCollection<MainTask>();
            int intNumTasks = 0;
            int intDueTasks = 0;
            int intTasksOverdue = 0;
            List<list> temp = new List<list>();
            
            foreach (var list in Lists)
            {
                //LINQ for count of assignments where taskID == list.tasks.taskID
                intNumTasks = list.Tasks.Count();
                intDueTasks = list.Tasks.Where(x => x.Due.Date == DateTime.UtcNow.Date).Count();
                intTasksOverdue = list.Tasks.Where(y => y.Due.Date < DateTime.UtcNow.Date).Count();
                //var x = from a in assignments
                //        from t in list.Tasks
                //        where a.TaskID == t.ID
                //        select a;
                //intDueTasks = (from tsk in x
                //              where tsk.Due.Date == DateTime.UtcNow.Date
                //              select tsk).Count();
                //intTasksOverdue = (from tsk in x
                //               where tsk.Due.Date < DateTime.UtcNow.Date
                //               select tsk).Count();

                Tasks.Add(new MainTask()
                {
                    ListID = list.ID,
                    Name = list.Name,
                    NumTasks = string.Format("Tasks: {0}", intNumTasks),
                    DueTasks = string.Format("Due: {0}", intDueTasks),
                    TasksOverdue = string.Format("Overdue: {0}", intTasksOverdue)
                });
            }
        }
    }

    public class MainTask
    {
        //List ID
        public int ListID { get; set; }

        //List Name
        public string Name { get; set; }

        //# of tasks
        public string NumTasks { get; set; }

        //# of due tasks
        public string DueTasks { get; set; }

        //# of tasks overdue
        public string TasksOverdue { get; set; }
    }
}
