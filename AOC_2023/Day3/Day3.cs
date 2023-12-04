using System.Reflection;

namespace AOC_2023.Day3
{
    public class Day3
    {
        string[] puzzleInputs = File.ReadAllLines($"{MethodBase.GetCurrentMethod().DeclaringType.Name}\\input.txt");


        public void ChapterOne()
        {
            int result = 0;

            foreach (string currInput in puzzleInputs)
            {
                var currentPuzzleInput = 0;


                char[] charArray =  currInput.ToCharArray();
                var partPositionIndex = 0;

                foreach (char currChar in charArray)
                {
                    if (currChar == '#' || currChar == '@' || currChar == '*' || currChar == '/' || currChar == '&' || currChar == '=' || currChar == '+' || currChar == '-' || currChar == '$' || currChar == '%') 
                    {
                        var previousInput = puzzleInputs[currentPuzzleInput - 1].ToCharArray();
                        var nextInput = puzzleInputs[currentPuzzleInput + 1].ToCharArray();
                    }

                    partPositionIndex++;
                }
                currentPuzzleInput++;
            }

            Console.WriteLine(result);
        }
    }
}
