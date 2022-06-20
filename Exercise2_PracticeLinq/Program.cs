using LinqExercise;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2_PracticeLinq
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of numbers: ");
            var sumNumbers = numbers.Sum();
            Console.WriteLine(sumNumbers);

            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.WriteLine("Average of numbers: ");
            var averageNumbers = numbers.Average();
            Console.WriteLine(averageNumbers);

            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending numbers: ");
            var orderedNumbers = numbers.OrderBy(x => x);

            //foreach (var number in orderedNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            orderedNumbers.ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            //TODO: Order numbers in decsending order adn print to the console
            Console.WriteLine("Numbers in descending order: ");
            var orderedNumbersByDescending = numbers.OrderByDescending(x => x);
            orderedNumbersByDescending.ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greater than 6: ");
            var greaterThanSix = numbers.Where(x => x > 6);
            greaterThanSix.ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Printing only 4 numbers from array: ");
            foreach (var number in numbers.Take(4))
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("Change index 4 to number 18: ");
            numbers[4] = 18;
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            Console.WriteLine("Employee First Names that starts with C or S, ordered by First name");
            var cOrS= employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName);
            cOrS.ToList().ForEach(x => Console.WriteLine(x.FullName)) ;


            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employees over 26 years old ordered by Age and then by First Name");
            var over26 = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            //over26.ToList().ForEach(x => Console.WriteLine(x.FullName));
            foreach (var person in over26)
            {
                Console.WriteLine($"Employee: {person.FullName} Age: {person.Age}");
            }

            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35

            var custom = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            Console.WriteLine("Sum of years of experience where YOE is less than or equal to 10 and Age is greater than 35");
            Console.WriteLine(custom.Sum(x => x.YearsOfExperience));
            Console.WriteLine("Average of years of experience where YOE is less than or equal to 10 and Age is greater than 35");
            Console.WriteLine(custom.Average(x => x.YearsOfExperience));

            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Adding a new employee to the list: ");
            employees.Append(new Employee { FirstName = "John", LastName = "Smith"});
            employees.ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}