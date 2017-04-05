using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Household_Chores.Models
{
    public class task
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Due { get; set; }
        public bool IsAssigned { get; set; }
        public int AssignedMemberID { get; set; }
        public bool IsCompleted { get; set; }
    }

    public enum frequency
    {
        Daily,
        EveryOtherDay,
        Weekly,
        BiWeekly,
        Monthly,
        BiMonthly,
        Quarterly,
        Yearly
    }
}
