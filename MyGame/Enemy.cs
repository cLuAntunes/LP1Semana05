namespace MyGame
{
    public class Enemy
    {
        private static int totalPowerUp;
        private string name;
        private float health;
        private float shield; 

        static Enemy()
        {
            totalPowerUp = 0;
        }

        public Enemy (string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {       
            return name;
        }

        public void SetName(string newName)
        {
            if (newName.Length > 8)
                name = newName.Substring(0, 8);
            else
                name = newName;
        }


        public void TakeDamage(float damage)
        {   
            shield -= damage;

            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void PickupPowerUp(PowerUp powerUp, float value)
        {
            totalPowerUp++;
            
            if (powerUp == PowerUp.Health)
            {
                health += value;
                if (health > 100) health = 100;
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += value;
                if (shield > 100) shield = 100;
            }
        }

        public static int GetTotalPowerUps()
        {
            return totalPowerUp;
        }
    }
}
