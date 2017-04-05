using System;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Household_Chores.Models;

namespace Household_Chores.ViewModels
{
    public class ListViewModel: ViewModelBase
    {
        public ObservableCollection<TaskDetails> Tasks { get; set; }

        public ListViewModel()
        {
            Tasks = new ObservableCollection<TaskDetails>();
        }

        public ListViewModel(list SelectedList)
        {
            var Tasks = new ObservableCollection<TaskDetails>();

            foreach (var task in SelectedList.Tasks)
            {
                var assignedToName = App.MyAppViewModel.Members.Where(x => x.ID == task.AssignedMemberID).Select(x=>x.Name).ToString();
                var categoryName = App.MyAppViewModel.Categories.Where(y => y.ID == task.CategoryID).Select(y=>y.Name).ToString();

                Tasks.Add(new TaskDetails()
                {
                    TaskID = task.ID,
                    Name = task.Name,
                    CategoryID = task.CategoryID,
                    CategoryName = categoryName, 
                    Value = task.Value,
                    IsAssigned = task.IsAssigned,
                    DueDate = task.Due,
                    AssignedToID = task.AssignedMemberID,
                    AssignedToName = assignedToName,
                    IsCompleted = task.IsCompleted
                });
            }
        }
    }

    public class TaskDetails
    {
        public int TaskID { get; set; }

        public string Name { get; set; }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public int Value { get; set; }

        public bool IsAssigned { get; set; }

        public DateTime DueDate { get; set; }

        public int AssignedToID { get; set; }

        public string AssignedToName { get; set; }

        public bool IsCompleted { get; set; }
    }
}
