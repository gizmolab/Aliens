using GizmoLab.Gameplay.Armor;
using GizmoLab.Gameplay.Weapons;
using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class AliensGameCore
    {
        private Player _player;

        private Alien _alien;

        private IWeapon _currentWeapon;

        private IArmor _armor;
        
        public AliensGameCore()
        {
            _currentWeapon = new SMG(20);
            _player = new Player(_currentWeapon);

            _armor = new LightArmor(2);
            _alien = new Alien(_armor);
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _player.ShootAt(_alien);
            }
        }
    }
}