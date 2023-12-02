using System.Reflection;
using System.Text.RegularExpressions;

namespace AOC_2023.Day2
{
    public class Day2
    {
        string[] puzzleInputs = File.ReadAllLines($"{MethodBase.GetCurrentMethod().DeclaringType.Name}\\input.txt");
        public void ChapterOne()
        {
            int result = 0;
            int gameNumber = 1;

            List<Game> validGames = [];

            foreach (string currInput in puzzleInputs)
            {
                int gameTitleIndex = currInput.IndexOf(':') + 1;
                string[] setOfCubes = currInput[gameTitleIndex..].Split(';');

                Game currentGame = new()
                {
                    GameNumber = gameNumber,
                    ShownSets = []
                };

                foreach (string currentSetOfCubes in setOfCubes)
                {
                    string[] shownCubes = currentSetOfCubes.Split(',');
                    Set currentSet = new();

                    foreach (string shownCube in shownCubes)
                    {
                        if (shownCube.Contains("red")) currentSet.Red = int.Parse(Regex.Match(shownCube, @"\d+").ToString());
                        if (shownCube.Contains("blue")) currentSet.Blue = int.Parse(Regex.Match(shownCube, @"\d+").ToString());
                        if (shownCube.Contains("green")) currentSet.Green = int.Parse(Regex.Match(shownCube, @"\d+").ToString());
                    }

                    currentGame.ShownSets.Add(currentSet);
                }

                foreach (var currentSet in currentGame.ShownSets)
                {
                    if (currentSet.Red > 12 | currentSet.Green > 13 | currentSet.Blue > 14)
                    {
                        currentGame.IsValide = false;
                    }
                }

                if (currentGame.IsValide)
                {
                    validGames.Add(currentGame);
                }

                gameNumber++;
            }

            foreach (var currentValidGame in validGames)
            {
                result += currentValidGame.GameNumber;
            }

            Console.WriteLine(result);
        }

        public void ChapterTwo()
        {
            int result = 0;
            int gameNumber = 1;

            List<Game> games = [];

            foreach (string currInput in puzzleInputs)
            {
                int gameTitleIndex = currInput.IndexOf(':') + 1;
                string[] setOfCubes = currInput[gameTitleIndex..].Split(';');

                Game currentGame = new()
                {
                    GameNumber = gameNumber,
                    MinimumCubesToPlay = new Set(),
                    ShownSets = []
                };

                foreach (string currentSetOfCubes in setOfCubes)
                {
                    string[] shownCubes = currentSetOfCubes.Split(',');
                    Set currentSet = new();

                    foreach (string shownCube in shownCubes)
                    {
                        if (shownCube.Contains("red")) currentSet.Red = int.Parse(Regex.Match(shownCube, @"\d+").ToString());
                        if (shownCube.Contains("blue")) currentSet.Blue = int.Parse(Regex.Match(shownCube, @"\d+").ToString());
                        if (shownCube.Contains("green")) currentSet.Green = int.Parse(Regex.Match(shownCube, @"\d+").ToString());
                    }

                    currentGame.ShownSets.Add(currentSet);
                }

                foreach (var currentSet in currentGame.ShownSets)
                {
                    currentGame.MinimumCubesToPlay.Red = currentSet.Red > currentGame.MinimumCubesToPlay.Red ? currentSet.Red : currentGame.MinimumCubesToPlay.Red;
                    currentGame.MinimumCubesToPlay.Green = currentSet.Green > currentGame.MinimumCubesToPlay.Green ? currentSet.Green : currentGame.MinimumCubesToPlay.Green;
                    currentGame.MinimumCubesToPlay.Blue = currentSet.Blue > currentGame.MinimumCubesToPlay.Blue ? currentSet.Blue : currentGame.MinimumCubesToPlay.Blue;
                }

                result += currentGame.MinimumCubesToPlay.Red * currentGame.MinimumCubesToPlay.Green * currentGame.MinimumCubesToPlay.Blue; 

                games.Add(currentGame);

                gameNumber++;
            }

            Console.WriteLine(result);
        }
    }


    public class Game
    {
        public int GameNumber { get; set; }
        public List<Set> ShownSets { get; set; }

        public Set MinimumCubesToPlay { get; set; }

        public bool IsValide { get; set; } = true;
    }

    public class Set
    {
        public int Blue { get; set; }
        public int Green { get; set; }
        public int Red { get; set; }
    }
}
