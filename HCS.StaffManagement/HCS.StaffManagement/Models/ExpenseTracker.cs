using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HCS.StaffManagement.Models
{
    public partial class ExpenseTracker
    {
       public int VisaNo { get; set; }
        public string EmployeeName { get; set; }
        public string DateOfBirth { get; set; }
        public List<ExpenseTrackModel> Expense { get; set; }
    }

    public class ExpenseTrackModel
    {
        public string ExpenseName { get; set; }
        public int  Amount { get; set; }
        

    }
}