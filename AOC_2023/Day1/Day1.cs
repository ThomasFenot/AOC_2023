using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace AOC_2023.Day1
{
    public class Day1
    {
        string[] puzzleInputs = File.ReadAllLines(@"Day1\\input.txt");

        public void ChapterOne() {
            int result = 0;

            foreach (string currInput in puzzleInputs)
            {
                List<string> resultString = string.Join(string.Empty, Regex.Matches(currInput, @"\d+").OfType<Match>()).Select(c => c.ToString()).ToList();
                result += int.Parse(resultString.First() + resultString.Last());
            }

            Console.WriteLine(result);
        }
    }
}
