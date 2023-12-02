
namespace AOC_2023
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("---------- AOC 2023 ----------");
            #region Day1
            Day1.Day1 day1 = new Day1.Day1();

            Console.WriteLine("---------- Day 1 - Chapter 1 ----------");
            day1.ChapterOne();
            Console.WriteLine("---------- Day 1 - Chapter 2 ----------");
            day1.ChapterTwo();
            #endregion
            #region Day2
            Day2.Day2 day2 = new Day2.Day2();

            Console.WriteLine("---------- Day 2 - Chapter 1 ----------");
            day2.ChapterOne();
            Console.WriteLine("---------- Day 2 - Chapter 2 ----------");
            day2.ChapterTwo();
            #endregion
        }
    }
}