using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class Alien
    {
        private int Health = 100;

        public bool Alive = true;
        
        public void TakeDamage(int damage)
        {
            if (!Alive)
            {
                Debug.LogError("Can't damage alien. It's dead");
                return;
            }
            
            Health -= damage;
            Alive = Health > 0;
            Debug.Log($"Alien took damage {damage}. Remaining health {Health}");
            if (!Alive)
            {
                Debug.Log("Alien has died!!!");
            }
        }
    }
}