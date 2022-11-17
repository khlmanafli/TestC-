using System;
using System.Collections.Generic;

namespace C51.Models
{
    public partial class Personal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? BirthPlace { get; set; }
        public DateTime? BirthDate { get; set; }
        public decimal? MobileNo { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
    }
}
