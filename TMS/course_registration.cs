//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class course_registration
    {
        public int registration_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> class_id { get; set; }
        public Nullable<int> manager_id { get; set; }
        public string status { get; set; }
        public string is_manager_approved { get; set; }
        public string is_admin_approved { get; set; }
    
        public virtual class_management class_management { get; set; }
        public virtual company_employee company_employee { get; set; }
        public virtual manager manager { get; set; }
    }
}
