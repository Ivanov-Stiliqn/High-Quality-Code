using System;
using Methods.Exceptions;

namespace Methods
{
    public class Student
    {
        public Student(string firstName, string lastName, DateTime birthday, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
            this.OtherInfo = otherInfo;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string OtherInfo { get; set; }

        /// <summary>
        /// Compares the ages of two students by their birthdays.
        /// </summary>
        /// <param name="comparingStudent"></param>
        /// <returns></returns>
        /// <exception cref="NoneExistingStudentException">Comparing student cannot be null</exception>
        public bool IsOlderThan(Student comparingStudent)
        {
            if (comparingStudent == null)
            {
                throw new NoneExistingStudentException("Cannot compare. Comparing student not found.");
            }

            bool isOlder = this.Birthday < comparingStudent.Birthday;
            return isOlder;
        }
    }
}
