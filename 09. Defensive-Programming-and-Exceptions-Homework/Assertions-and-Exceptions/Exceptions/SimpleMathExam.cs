public class SimpleMathExam : Exam
{
    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }

        private set
        {
            if (value < 0)
            {
                this.problemsSolved = 0;
            }
            else if (value > 4)
            {
                this.problemsSolved = 4;
            }
            else
            {
                this.problemsSolved = value;
            }
        }
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0)
        {
            var result = new ExamResult(2, 2, 6, "Bad result: nothing done.");
            return result;
        }

        if (this.ProblemsSolved == 1)
        {
            var result = new ExamResult(3, 2, 6, "Average result: Not bad, keep trying.");
            return result;
        }

        if (this.ProblemsSolved == 2)
        {
            var result = new ExamResult(4, 2, 6, "Good result. You are on the right path.");
            return result;
        }

        if (this.ProblemsSolved == 3)
        {
            var result = new ExamResult(5, 2, 6, "Very good result. Good job! Almost there!");
            return result;
        }

        return new ExamResult(6, 2, 6, "Great result: Well done.");
    }
}