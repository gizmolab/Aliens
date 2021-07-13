using GizmoLab.Gameplay.Armor;
using UnityEngine;
using Zenject;

namespace GizmoLab.Gameplay
{
    public class Alien
    {
        private int Health = 100;

        private bool _isAlive = true;

        [Inject]
        private IArmor _armor;
        
        public void TakeDamage(int damage)
        {
            if (!_isAlive)
            {
                Debug.LogError("Can't damage alien. It's dead");
                return;
            }
            var damageToTake = _armor.AbsorbDamage(damage);
            Health -= damageToTake;
            _isAlive = Health > 0;
            Debug.Log($"Alien took damage {damageToTake}. Remaining health {Health}");
            if (!_isAlive)
            {
                Debug.Log("Alien has died!!!");
            }
        }
    }
}