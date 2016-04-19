using System;

using Exceptions_Homework.Exceptions;

public class CSharpExam : Exam
{
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The score must be positive number.");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score > 100)
        {
            throw new InvalidScoreExcepiton("Score must be between 0 and 100.");
        }

        var result = new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        return result;
    }
}