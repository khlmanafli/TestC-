using System;
using System.Collections.Generic;

namespace C51.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public bool? Approved { get; set; }
    }
}
