using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    internal class AnnotationTest
    {
        public void EmployeeObjects()
        {
            Employee employee = new Employee();
            employee.Name = "Uday";
            employee.Age = 22;
            employee.EmailId = "9121696212@gmail.com";
            employee.ContactNumber = "+91 9121696212";
            ValidationContext context = new ValidationContext(employee);
            List<ValidationResult> list = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employee, context, list,true);
            if(!valid )
            {
                foreach(ValidationResult result in list )
                {
                    Console.WriteLine(result.MemberNames.First(),Environment.NewLine);
                    Console.WriteLine(result.ErrorMessage,Environment.NewLine);
                }

            }
            else
            {
                Console.WriteLine("Name : {0}",employee.Name);
                Console.WriteLine("age :{0}",employee.Age);
                Console.WriteLine("Email :{0}",employee.EmailId);
                Console.WriteLine("Contact Number :{0}",employee.ContactNumber);
            }
        }
    }
}
