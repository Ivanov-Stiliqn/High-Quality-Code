using System;
using System.Collections.Generic;
using System.Linq;

using Exceptions_Homework.Exceptions;

public class Student
{
    private IList<Exam> exams;

    private string firstName;

    private string lastName;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<Exam> Exams
    {
        get
        {
            return this.exams;
        }

        set
        {
            if (value == null)
            {
                this.exams = new List<Exam>();
            }

            this.exams = value;
        }
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            this.CheckNameValidation(value, "First name");
            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            this.CheckNameValidation(value, "Last name");
            this.lastName = value;
        }
    }

    public double CalcAverageExamResultInPercents()
    {
        this.CheckForCurrentExams();

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = this.CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = ((double)examResults[i].Grade - examResults[i].MinGrade)
                           / (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }

    public IList<ExamResult> CheckExams()
    {
        this.CheckForCurrentExams();

        var results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    private void CheckForCurrentExams()
    {
        if (this.Exams.Count == 0)
        {
            throw new NoCurrentExamsExcepiton("The student does not have any exams at the moment.");
        }
    }

    private void CheckNameValidation(string value, string name)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException("{0} cannot be null or empty.", name);
        }
    }
}