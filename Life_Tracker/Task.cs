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
    
    public partial class Task
    {
        public int ListOwnerID { get; set; }
        public int ListID { get; set; }
        public int TaskID { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> DeadLine { get; set; }
        public string FeedBack { get; set; }
    
        public virtual TaskList TaskList { get; set; }
    }
}