using System.Reflection;
using System.Text.RegularExpressions;

namespace AOC_2023.Day1
{
    public class Day1
    {
        string[] puzzleInputs = File.ReadAllLines($"{MethodBase.GetCurrentMethod().DeclaringType.Name}\\input.txt");
        string[] testPuzzleInputs = File.ReadAllLines($"{MethodBase.GetCurrentMethod().DeclaringType.Name}\\testInput.txt");

        public void ChapterOne()
        {
            int result = 0;

            foreach (string currInput in puzzleInputs)
            {
                List<string> matches = string.Join(string.Empty, Regex.Matches(currInput, @"\d").OfType<Match>()).Select(c => c.ToString()).ToList();
                result += int.Parse(matches.First() + matches.Last());
            }

            Console.WriteLine(result);
        }
        public void ChapterTwo()
        {
            int result = 0;

            foreach (string currInput in puzzleInputs)
            {
                var matches = Regex.Matches(currInput, @"(?=(\d|one|two|three|four|five|six|seven|eight|nine))").ToArray().Select(m => m.Groups[1].Value).ToList();
                result += int.Parse(Parser(matches.First()) + Parser(matches.Last()));
            }

            Console.WriteLine(result);
        }

        private string Parser(string value) => value switch
        {
            "one" => "1",
            "two" => "2",
            "three" => "3",
            "four" => "4",
            "five" => "5",
            "six" => "6",
            "seven" => "7",
            "eight" => "8",
            "nine" => "9",
            _ => value,
        };

    }
}
