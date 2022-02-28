// See https://aka.ms/new-console-template for more information
using WcfServiceLibrary.Models;
using WcfServiceLibrary.Services;

CalculationService calculationService = new CalculationService();
var result = calculationService.Add(1, 2);
StudentService studentService = new StudentService();
IEnumerable<Student> students = studentService.GetAll();
Console.WriteLine("haha");