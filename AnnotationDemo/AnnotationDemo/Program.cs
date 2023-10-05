using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    //Data Annotation Is Used To COnigure A Model class .
    //Annotation Atributes Are Used To apply to Classes OR Class member to Specify.
    //The Realtion Between Classess Describe How The Data Is Display In The UI,and Specify Validation both..    
    internal class Program
    {
        static void Main(string[] args)
        {
            AnnotationTest annotationTest = new AnnotationTest();
            annotationTest.EmployeeObjects();
            Console.ReadLine();
        }
    }
}
