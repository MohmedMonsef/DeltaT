//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Life_Tracker
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonHabit
    {
        public int PersonID { get; set; }
        public string HabitName { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
    
        public virtual Habit Habit { get; set; }
        public virtual Person Person { get; set; }
    }
}
