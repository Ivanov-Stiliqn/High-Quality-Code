namespace InheritanceAndPolymorphism.Models
{
    using System.Collections.Generic;
    using System.Text;
    using InheritanceAndPolymorphism.Cotracts;

    public abstract class Course : ICourse
    {
        private readonly List<string> students; 

        protected Course(string name)
        {
            this.Name = name;
            this.students = new List<string>();
        }

        protected Course(string courseName, string teacherName)
            : this(courseName)
        {
            this.TeacherName = teacherName;
        }

        protected Course(string courseName, string teacherName, IEnumerable<string> students)
            : this(courseName, teacherName)
        {
            this.AddStudents(students);
        }

        public string Name { get; set; }

        public IEnumerable<string> Students
        {
            get
            {
                return this.students;
            }
        }

        public string TeacherName { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name + " { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            return result.ToString();
        }

        public void AddStudents(params string[] inputStudents)
        {
            foreach (var student in inputStudents)
            {
                this.students.Add(student);
            }
        }

        public void AddStudents(IEnumerable<string> inputStudents)
        {
            foreach (var student in inputStudents)
            {
                this.students.Add(student);
            }    
        }

        private string GetStudentsAsString()
        {
            if (this.students == null || this.students.Count == 0)
            {
                return "{ }";
            }

            return "{ " + string.Join(", ", this.Students) + " }";
        }
    }
}
