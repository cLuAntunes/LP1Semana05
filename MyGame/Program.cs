using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int enemies = int.Parse(args[0]);

            Enemy[] allenemies = new Enemy[enemies];

            for (int i = 0; i < enemies; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string name = Console.ReadLine();
                allenemies[i] = new Enemy(name);
            }

            foreach (Enemy enemy in allenemies)
            {
                enemy.TakeDamage(38);
                enemy.PickupPowerUp(PowerUp.Health, 25);
                enemy.PickupPowerUp(PowerUp.Shield, 30);
                enemy.TakeDamage(15);

                Console.WriteLine($"{enemy.GetName()}" +
                    $" {enemy.GetHealth()} " +
                    $"{enemy.GetShield()}");
            }
        

        }
    }
}
