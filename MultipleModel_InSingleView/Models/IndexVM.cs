using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleModel_InSingleView.Models
{
    public class IndexVM
    {
        public List<Employee> Employees { get; set; }
        public List<Student> Student{ get; set; } 
    }
}