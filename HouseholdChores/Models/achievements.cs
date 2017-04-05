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
    public class achievement
    {
        public int MemberID { get; set; }
        public int RewardID { get; set; }
        public DateTime DateEarned { get; set; }
    }
}
