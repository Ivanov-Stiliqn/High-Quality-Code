namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    using InheritanceAndPolymorphism.Cotracts;
    using InheritanceAndPolymorphism.Models;

    internal class CoursesExamples
    {
        private static void Main()
        {
            ILocalCourse localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);
            
            localCourse.AddStudents("Peter", "Maria");
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.AddStudents("Milena");
            localCourse.AddStudents("Todor");
            Console.WriteLine(localCourse);

            ICourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development", 
                "Mario Peshev", 
                new List<string> { "Thomas", "Ani", "Steve" });
            Console.WriteLine(offsiteCourse);
        }
    }
}