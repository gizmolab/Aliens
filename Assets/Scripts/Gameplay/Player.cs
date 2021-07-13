using GizmoLab.Gameplay.Weapons;
using Zenject;

namespace GizmoLab.Gameplay
{
    public class Player
    {
        [Inject]
        private IWeapon _shotgun;

        public void ShootAt(Alien alien)
        {
            _shotgun.MakeDamage(alien);
        }
    }
}

