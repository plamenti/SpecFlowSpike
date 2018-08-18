namespace GameCore
{
    public class PlayerCharacter
    {
        public int Health { get; set; } = 100;
        public bool IsDead { get; set; }

        public void Hit(int damage)
        {
            Health -= damage;

            if (Health <= 0)
            {
                IsDead = true;
            }
        }
    }
}
