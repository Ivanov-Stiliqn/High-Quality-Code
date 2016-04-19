using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class MainApplication
    {
        private static void Main()
        {
            Console.WriteLine(Methods.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.ShowDigitAsLetters(5));

            Console.WriteLine(Methods.FindMax(-1, 3, 2, 14, 2, 3));

            Methods.PrintNumberFormat(1.3, "f");
            Methods.PrintNumberFormat(0.75, "%");
            Methods.PrintNumberFormat(2.30, "r");

            Console.WriteLine(Methods.CalcDistance(3, -1, 3, 2.5));

            bool horizontal, vertical;
            Methods.CheckLinesPosition(3, -1, 3, 2.5, out horizontal, out vertical);
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 03, 17), "From Sofia");
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 03), "From Vidin, gamer, high results"); 

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
