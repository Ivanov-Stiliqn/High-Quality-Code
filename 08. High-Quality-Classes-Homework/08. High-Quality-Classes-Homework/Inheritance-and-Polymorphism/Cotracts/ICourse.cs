namespace InheritanceAndPolymorphism.Cotracts
{
    using System.Collections.Generic;

    public interface ICourse
    {
        string Name { get; set; }

        IEnumerable<string> Students { get; }

        string TeacherName { get; set; }

        void AddStudents(params string[] students);

        void AddStudents(IEnumerable<string> students);

        string ToString();
    }
}
