namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videogames = new string[] { "God of War", "Kingdom Hearts 3", "Genshin Impact", "It Takes Two", "Xenoblade", "Super Smash Brothers" };

            videogames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
