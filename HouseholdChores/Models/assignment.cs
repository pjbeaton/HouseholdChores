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

namespace Household_Chores.Models
{
    public class assignment
    {
        public int TaskID { get; set; }
        public int MemberID { get; set; }
        public DateTime Due { get; set; }
//        public frequency Frequency { get; set; }
        public bool IsCompleted { get; set; }
    }
}
