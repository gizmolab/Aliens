using GizmoLab.Gameplay.Weapons;

namespace GizmoLab.Gameplay
{
    public class Player
    {
        private IWeapon _shotgun;

        public Player(IWeapon weapon)
        {
            _shotgun = weapon;
        }

        public void ShootAt(Alien alien)
        {
            _shotgun.MakeDamage(alien);
        }
    }
}