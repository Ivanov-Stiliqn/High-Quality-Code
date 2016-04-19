using System;

using Exceptions_Homework.Exceptions;

public class ExamResult
{
    private string comments;

    private int grade;

    private int maxGrade;

    private int minGrade;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("The comments cannot be null or empty string.");
            }

            this.comments = value;
        }
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }

        private set
        {
            if (value < 0)
            {
                throw new InvalidGradeException("Grade cannot be neggtive number.");
            }

            this.grade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }

        private set
        {
            if (value < 0)
            {
                throw new InvalidGradeException("The maximum grade cannot be neggative");
            }

            if (value <= this.minGrade)
            {
                throw new InvalidMinMaxRangeException("The maximum grade must be greater than the minimum grade.");
            }

            this.maxGrade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            if (value < 0)
            {
                throw new InvalidGradeException("The minimum grade cannot be neggative.");
            }

            this.minGrade = value;
        }
    }
}