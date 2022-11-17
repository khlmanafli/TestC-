using System;
using System.Collections.Generic;

namespace C51.Models
{
    public partial class Department
    {
        public Department()
        {
            Personals = new HashSet<Personal>();
        }

        public int Id { get; set; }
        public string? DepartmentName { get; set; }

        public virtual ICollection<Personal> Personals { get; set; }
    }
}
