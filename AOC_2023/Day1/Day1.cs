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
        public void ChapterOne() {
            string[]  puzzleInputs = File.ReadAllLines(@"Day1\\input.txt"); 
            int result = 0;

            foreach (string currInput in puzzleInputs)
            {
                var resultString = string.Join(string.Empty, Regex.Matches(currInput, @"\d+").OfType<Match>().Select(m => m.Value));
                List<string> strings = resultString.Select(c => c.ToString()).ToList();
                string concat = strings.First() + strings.Last();
                result += int.Parse(concat);
            }

            Console.WriteLine(result);
        }
    }
}
