using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "MegaMan X", "Donkey Kong", "Mario Cart", "Goldeneye 007", "Doom" };
            var orderedGames = games.OrderBy(x => x.Length); 
            foreach (var game in orderedGames)
            {
                Console.WriteLine($" {game}");
            }
        }
    }
}
