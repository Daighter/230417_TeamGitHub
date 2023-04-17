namespace _230417_TeamGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Player player = new Player( "용사", 100, 20, 10, 0);

            player.Attack(Player);
            player.TrueDamage(10);
            player.MagicAttack(10);
        }
    }
}