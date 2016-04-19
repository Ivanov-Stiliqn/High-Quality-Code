namespace InheritanceAndPolymorphism.Models
{
    using System.Collections.Generic;
    using System.Text;
    using InheritanceAndPolymorphism.Cotracts;

    public class LocalCourse : Course, ILocalCourse
    {
        public LocalCourse(string name, string lab = null)
            : base(name)
        {
            this.Lab = lab;
        }

        public LocalCourse(string courseName, string teacherName, string lab = null)
            : base(courseName, teacherName)
        {
            this.Lab = lab;
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab = null)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}