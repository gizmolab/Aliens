namespace GizmoLab.Gameplay
{
    public class Player
    {
        private Shotgun _shotgun;

        public Player()
        {
            _shotgun = new Shotgun();
        }

        public void ShootAt(Alien alien)
        {
            alien.TakeDamage(_shotgun.Damage);
        }
    }
}