namespace InheritanceAndPolymorphism.Models
{
    using System.Collections.Generic;
    using System.Text;
    using InheritanceAndPolymorphism.Cotracts;

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        public OffsiteCourse(string name, string town = null)
            : base(name)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName, string town = null)
            : base(courseName, teacherName)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town = null)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public string Town { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}