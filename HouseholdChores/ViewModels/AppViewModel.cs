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
using Household_Chores.Models;
using System.Collections.ObjectModel;

namespace Household_Chores.ViewModels
{
    public class AppViewModel: ViewModelBase
    {
        public AppViewModel()
        {
            _lists = new ObservableCollection<list>();
            _tasks = new ObservableCollection<task>();
            //_assignments = new ObservableCollection<assignment>();
            //_completed = new ObservableCollection<completed>();
            _achievements = new ObservableCollection<achievement>();
            _members = new ObservableCollection<member>();
            _categories = new ObservableCollection<category>();

            Load();
        }
        //public List<task> Tasks { get; set; }
        //public List<assignment> Assignments { get; set; }
        //public List<completed> CompletedAssignments { get; set; }
        //public List<achievement> Achievements { get; set; }
        //public List<member> Members { get; set; }

        public bool blnAppLoaded = false;

        private bool _blnListsLoaded = false;
        private ObservableCollection<list> _lists;
        public ObservableCollection<list> Lists
        {
            get
            {
                return _lists;
            }
        }

        private bool _blnTasksLoaded = false;
        private ObservableCollection<task> _tasks;
        public ObservableCollection<task> Tasks
        {
            get
            {
                return _tasks;
            }
        }

        private bool _blnCategoriesLoaded = false;
        private ObservableCollection<category> _categories;
        public ObservableCollection<category> Categories
        {
            get
            {
                return _categories;
            }
        }

        //private bool _blnAssignmentsLoaded = false;
        //private ObservableCollection<assignment> _assignments;
        //public ObservableCollection<assignment> Assignments
        //{
        //    get
        //    {
        //        return _assignments;
        //    }
        //}

        //private bool _blnCompletedLoaded = false;
        //private ObservableCollection<completed> _completed;
        //public ObservableCollection<completed> Completed
        //{
        //    get
        //    {
        //        return _completed;
        //    }
        //}

        private bool _blnAchievementsLoaded = false;
        private ObservableCollection<achievement> _achievements;
        public ObservableCollection<achievement> Achievements
        {
            get
            {
                return _achievements;
            }
        }

        private bool _blnMembersLoaded;
        private ObservableCollection<member> _members;
        public ObservableCollection<member> Members
        {
            get
            {
                return _members;
            }
        }

        public void Load()
        {
            LoadLists();
            LoadTasks();
            //LoadAssignments();
            //LoadCompleted();
            LoadAchievements();
            LoadMembers();
            LoadCategories();

            blnAppLoaded = true;
        }

        private void LoadLists()
        {
            if (!_blnListsLoaded)
            {
                if (!_blnTasksLoaded)
                    LoadTasks();

                this.Lists.Add(new list() { ID = 1, Name = "Housekeeping", Tasks = this.Tasks });

                _blnListsLoaded = true;
            }
        }

        private void LoadCategories()
        {
            if (!_blnCategoriesLoaded)
            {
                this.Categories.Add(new category() { ID = 1, Name = "Kitchen" });
                this.Categories.Add(new category() { ID = 2, Name = "Bedrooms" });
                this.Categories.Add(new category() { ID = 3, Name = "Bathrooms" });
                this.Categories.Add(new category() { ID = 4, Name = "Family Area" });
                this.Categories.Add(new category() { ID = 5, Name = "Laundry" });
                this.Categories.Add(new category() { ID = 6, Name = "All around the house" });
                this.Categories.Add(new category() { ID = 7, Name = "Outside" });
                this.Categories.Add(new category() { ID = 8, Name = "Pets" });
                this.Categories.Add(new category() { ID = 9, Name = "Safety" });
                this.Categories.Add(new category() { ID = 10, Name = "Finance/Paperwork" });

                _blnCategoriesLoaded = true;
            }
        }

        private void LoadMembers()
        {
            if (!_blnMembersLoaded)
            {
                this.Members.Add(new member() { ID = 1, Email="pjbeaton@hotmail.com", Name="Paul"});
                this.Members.Add(new member() { ID = 2, Email = "pjbeaton@hotmail.com", Name = "Teresa" });
                this.Members.Add(new member() { ID = 3, Email = "pjbeaton@hotmail.com", Name = "Anthony" });
                this.Members.Add(new member() { ID = 4, Email = "pjbeaton@hotmail.com", Name = "Alison" });

                _blnMembersLoaded = true;
            }
        }

        private void LoadAchievements()
        {
            if (!_blnAchievementsLoaded)
            {
                
            }
        }

        //private void LoadCompleted()
        //{
        //    if (!_blnCompletedLoaded)
        //    {

        //    }
        //}

        //private void LoadAssignments()
        //{
        //    if (!_blnAssignmentsLoaded)
        //    {

        //    }
        //}

        private void LoadTasks()
        {
            if (!_blnTasksLoaded)
            {
                //Kitchen
                this.Tasks.Add(new task() { ID = 1, CategoryID = 1, Name = "Plan / Prepare meals", Value = 1 });
                this.Tasks.Add(new task() { ID = 2, CategoryID = 1, Name = "Prepare grocery list", Value = 1 });
                this.Tasks.Add(new task() { ID = 3, CategoryID = 1, Name = "Do grocery shopping", Value = 1 });
                this.Tasks.Add(new task() { ID = 4, CategoryID = 1, Name = "Clear the table", Value = 1 });
                this.Tasks.Add(new task() { ID = 5, CategoryID = 1, Name = "Set the table", Value = 1 });
                this.Tasks.Add(new task() { ID = 6, CategoryID = 1, Name = "Wash dishes", Value = 1 });
                this.Tasks.Add(new task() { ID = 7, CategoryID = 1, Name = "Load dishwasher", Value = 1 });
                this.Tasks.Add(new task() { ID = 8, CategoryID = 1, Name = "Put away clean dishes", Value = 1 });
                this.Tasks.Add(new task() { ID = 9, CategoryID = 1, Name = "Clean stove top", Value = 1 });
                this.Tasks.Add(new task() { ID = 10, CategoryID = 1, Name = "Clean counter top", Value = 1 });
                this.Tasks.Add(new task() { ID = 11, CategoryID = 1, Name = "Clean out fridge / freezer", Value = 1 });
                this.Tasks.Add(new task() { ID = 12, CategoryID = 1, Name = "Clean fridge / freezer", Value = 1 });
                this.Tasks.Add(new task() { ID = 13, CategoryID = 1, Name = "Clean / disinfect sink", Value = 1 });
                this.Tasks.Add(new task() { ID = 14, CategoryID = 1, Name = "Clean microwave", Value = 1 });
                this.Tasks.Add(new task() { ID = 15, CategoryID = 1, Name = "Clean appliances", Value = 1 });
                this.Tasks.Add(new task() { ID = 16, CategoryID = 1, Name = "Clean pantry", Value = 1 });
                this.Tasks.Add(new task() { ID = 17, CategoryID = 1, Name = "Take out garbage", Value = 1 });
                this.Tasks.Add(new task() { ID = 18, CategoryID = 1, Name = "Recycling", Value = 1 });

                //Bedrooms
                this.Tasks.Add(new task() { ID = 19, CategoryID = 2, Name = "Make beds", Value = 1 });
                this.Tasks.Add(new task() { ID = 20, CategoryID = 2, Name = "Pick up clothes", Value = 1 });
                this.Tasks.Add(new task() { ID = 21, CategoryID = 2, Name = "Put away clothes", Value = 1 });
                this.Tasks.Add(new task() { ID = 22, CategoryID = 2, Name = "Pick up toys", Value = 1 });
                this.Tasks.Add(new task() { ID = 23, CategoryID = 2, Name = "Donate old toys / clothes", Value = 1 });
                this.Tasks.Add(new task() { ID = 24, CategoryID = 2, Name = "Clean dresser / mirror(s)", Value = 1 });
                this.Tasks.Add(new task() { ID = 25, CategoryID = 2, Name = "Organize desk", Value = 1 });
                this.Tasks.Add(new task() { ID = 26, CategoryID = 2, Name = "Wash bedding", Value = 1 });
                this.Tasks.Add(new task() { ID = 27, CategoryID = 2, Name = "Change bedding", Value = 1 });
                this.Tasks.Add(new task() { ID = 28, CategoryID = 2, Name = "Organize closet", Value = 1 });

                //Bathrooms
                this.Tasks.Add(new task() { ID = 29, CategoryID = 3, Name = "Clean shower", Value = 1 });
                this.Tasks.Add(new task() { ID = 30, CategoryID = 3, Name = "Clean bathtub", Value = 1 });
                this.Tasks.Add(new task() { ID = 31, CategoryID = 3, Name = "Clean toilets", Value = 1 });
                this.Tasks.Add(new task() { ID = 32, CategoryID = 3, Name = "Clean sinks", Value = 1 });
                this.Tasks.Add(new task() { ID = 33, CategoryID = 3, Name = "Clean / organize countertop", Value = 1 });
                this.Tasks.Add(new task() { ID = 34, CategoryID = 3, Name = "Clean mirrors", Value = 1 });
                this.Tasks.Add(new task() { ID = 35, CategoryID = 3, Name = "Organize cupboards / drawers", Value = 1 });
                this.Tasks.Add(new task() { ID = 36, CategoryID = 3, Name = "Sweep / mop floor", Value = 1 });
                this.Tasks.Add(new task() { ID = 37, CategoryID = 3, Name = "Change towels", Value = 1 });
                this.Tasks.Add(new task() { ID = 38, CategoryID = 3, Name = "Wash rugs", Value = 1 });

                //Family / Living area
                this.Tasks.Add(new task() { ID = 39, CategoryID = 4, Name = "Pick up books", Value = 1 });
                this.Tasks.Add(new task() { ID = 40, CategoryID = 4, Name = "Put away toys", Value = 1 });
                this.Tasks.Add(new task() { ID = 41, CategoryID = 4, Name = "Organize bookshelves", Value = 1 });
                this.Tasks.Add(new task() { ID = 42, CategoryID = 4, Name = "Dust", Value = 1 });
                this.Tasks.Add(new task() { ID = 43, CategoryID = 4, Name = "Vacuum", Value = 1 });
                this.Tasks.Add(new task() { ID = 44, CategoryID = 4, Name = "Organize movies", Value = 1 });
                this.Tasks.Add(new task() { ID = 45, CategoryID = 4, Name = "Organize magazines", Value = 1 });

                //Laundry
                this.Tasks.Add(new task() { ID = 46, CategoryID = 5, Name = "Sort into loads", Value = 1 });
                this.Tasks.Add(new task() { ID = 47, CategoryID = 5, Name = "Wash clothes", Value = 1 });
                this.Tasks.Add(new task() { ID = 48, CategoryID = 5, Name = "Iron clothes", Value = 1 });
                this.Tasks.Add(new task() { ID = 49, CategoryID = 5, Name = "Fold clothes", Value = 1 });
                this.Tasks.Add(new task() { ID = 50, CategoryID = 5, Name = "Put away clothes", Value = 1 });
                this.Tasks.Add(new task() { ID = 51, CategoryID = 5, Name = "Remove lint", Value = 1 });
                this.Tasks.Add(new task() { ID = 52, CategoryID = 5, Name = "Dry cleaning", Value = 1 });
                this.Tasks.Add(new task() { ID = 53, CategoryID = 5, Name = "Clean washing machine", Value = 1 });

                //Around the house
                this.Tasks.Add(new task() { ID = 54, CategoryID = 6, Name = "Sweep / mop floors", Value = 1 });
                this.Tasks.Add(new task() { ID = 55, CategoryID = 6, Name = "Scrub floors", Value = 1 });
                this.Tasks.Add(new task() { ID = 56, CategoryID = 6, Name = "Vacuum carpets", Value = 1 });
                this.Tasks.Add(new task() { ID = 57, CategoryID = 6, Name = "Spot clean carpets", Value = 1 });
                this.Tasks.Add(new task() { ID = 58, CategoryID = 6, Name = "Shampoo carpets", Value = 1 });
                this.Tasks.Add(new task() { ID = 59, CategoryID = 6, Name = "Take out trash", Value = 1 });
                this.Tasks.Add(new task() { ID = 60, CategoryID = 6, Name = "Dust / clean blinds", Value = 1 });
                this.Tasks.Add(new task() { ID = 61, CategoryID = 6, Name = "Dust ceiling fans", Value = 1 });
                this.Tasks.Add(new task() { ID = 62, CategoryID = 6, Name = "Dust furniture", Value = 1 });
                this.Tasks.Add(new task() { ID = 63, CategoryID = 6, Name = "Vacuum / dust A/C vents", Value = 1 });
                this.Tasks.Add(new task() { ID = 64, CategoryID = 6, Name = "Change A/C filters", Value = 1 });
                this.Tasks.Add(new task() { ID = 65, CategoryID = 6, Name = "Remove cobwebs", Value = 1 });
                this.Tasks.Add(new task() { ID = 66, CategoryID = 6, Name = "Clean windows", Value = 1 });
                this.Tasks.Add(new task() { ID = 67, CategoryID = 6, Name = "Clean walls / doors", Value = 1 });
                this.Tasks.Add(new task() { ID = 68, CategoryID = 6, Name = "Wash curtains", Value = 1 });
                this.Tasks.Add(new task() { ID = 69, CategoryID = 6, Name = "Wash rugs / throws", Value = 1 });
                
                //Outside
                this.Tasks.Add(new task() { ID = 70, CategoryID = 7, Name = "Clean doormats", Value = 1 });
                this.Tasks.Add(new task() { ID = 71, CategoryID = 7, Name = "Clean patio furniture", Value = 1 });
                this.Tasks.Add(new task() { ID = 72, CategoryID = 7, Name = "Sweep / clean patio", Value = 1 });
                this.Tasks.Add(new task() { ID = 73, CategoryID = 7, Name = "Clean BBQ grill", Value = 1 });
                this.Tasks.Add(new task() { ID = 74, CategoryID = 7, Name = "Clean pool", Value = 1 });
                this.Tasks.Add(new task() { ID = 75, CategoryID = 7, Name = "Clean / organize garage", Value = 1 });
                this.Tasks.Add(new task() { ID = 76, CategoryID = 7, Name = "Vacuum vehicles", Value = 1 });
                this.Tasks.Add(new task() { ID = 77, CategoryID = 7, Name = "Wash vehicles", Value = 1 });
                this.Tasks.Add(new task() { ID = 78, CategoryID = 7, Name = "Pull weeds", Value = 1 });
                this.Tasks.Add(new task() { ID = 79, CategoryID = 7, Name = "Plant garden", Value = 1 });
                this.Tasks.Add(new task() { ID = 80, CategoryID = 7, Name = "Mow lawn", Value = 1 });
                this.Tasks.Add(new task() { ID = 81, CategoryID = 7, Name = "Rake leaves", Value = 1 });
                this.Tasks.Add(new task() { ID = 82, CategoryID = 7, Name = "Fertilize / water lawn", Value = 1 });
                this.Tasks.Add(new task() { ID = 83, CategoryID = 7, Name = "Water plants", Value = 1 });
                this.Tasks.Add(new task() { ID = 84, CategoryID = 7, Name = "Shovel snow", Value = 1 });
                this.Tasks.Add(new task() { ID = 85, CategoryID = 7, Name = "Wash windows", Value = 1 });
                this.Tasks.Add(new task() { ID = 86, CategoryID = 7, Name = "Change oil", Value = 1 });
                this.Tasks.Add(new task() { ID = 87, CategoryID = 7, Name = "Clean gutters", Value = 1 });

                //Pets
                this.Tasks.Add(new task() { ID = 88, CategoryID = 8, Name = "Wash / groom pets", Value = 1 });
                this.Tasks.Add(new task() { ID = 89, CategoryID = 8, Name = "Feed pets", Value = 1 });

                //Safety
                this.Tasks.Add(new task() { ID = 90, CategoryID = 9, Name = "Check / replenish first-aid kit", Value = 1 });
                this.Tasks.Add(new task() { ID = 91, CategoryID = 9, Name = "Check smoke detectors", Value = 1 });

                //Finance / Paperwork
                this.Tasks.Add(new task() { ID = 92, CategoryID = 10, Name = "Manage finances", Value = 1 });
                this.Tasks.Add(new task() { ID = 93, CategoryID = 10, Name = "Set a budget", Value = 1 });
                this.Tasks.Add(new task() { ID = 94, CategoryID = 10, Name = "Pay bills", Value = 1 });
                this.Tasks.Add(new task() { ID = 95, CategoryID = 10, Name = "Track income / expenses", Value = 1 });
                this.Tasks.Add(new task() { ID = 96, CategoryID = 10, Name = "Organize mail", Value = 1 });
                this.Tasks.Add(new task() { ID = 97, CategoryID = 10, Name = "Review insurance policies", Value = 1 });
                this.Tasks.Add(new task() { ID = 98, CategoryID = 10, Name = "Review / rebalance retirement accounts", Value = 1 });
                this.Tasks.Add(new task() { ID = 99, CategoryID = 10, Name = "Review college funds", Value = 1 });

                _blnTasksLoaded = true;
            }
        }
    }
}
