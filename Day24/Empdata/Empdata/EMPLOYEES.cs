//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Empdata
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLOYEES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYEES()
        {
            this.EMPLOYEES1 = new HashSet<EMPLOYEES>();
        }
    
        public int employee_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int phone_number { get; set; }
        public System.DateTime hire_date { get; set; }
        public int job_id { get; set; }
        public decimal salary { get; set; }
        public decimal commission_pct { get; set; }
        public int manager_id { get; set; }
        public int department_id { get; set; }
    
        public virtual DEPARTMENTS DEPARTMENT { get; set; }
        public virtual JOB JOB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEES> EMPLOYEES1 { get; set; }
        public virtual EMPLOYEES EMPLOYEE1 { get; set; }
    }
}
