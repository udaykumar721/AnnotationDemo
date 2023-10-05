using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    internal class Employee
    {
        [Required(ErrorMessage = "Employee {0} is Required")] //Attribute
        [StringLength(100,MinimumLength = 4, ErrorMessage = "Name Should Be Minimum 4 Character Maximum Should Be 100 Character")]
        [DataType(DataType.Text)]
        public string Name {  get; set; }
        [Range(18, 105, ErrorMessage = "Age Should Be Above 18 And Below 105")]
        public int Age { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailId { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string ContactNumber { get; set; }
        
    }
}
