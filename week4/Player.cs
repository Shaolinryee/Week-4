namespace Week4.Week4
{
    // Player class to represent a game player
    public class Player
    {
        // Instance field: Player's name
        public string? playerName;

        // Instance field: Player's level
        public int level;

        // Instance field: Player's health
        public int health;

        // Default constructor - prints a message when called
        public Player()
        {
            Console.WriteLine("Default constructor has been called");
        }

        // Parameterized constructor - initializes all three fields
        public Player(string playerName, int level, int health)
        {
            this.playerName = playerName;
            this.level = level;
            this.health = health;
        }
    }
}
