﻿namespace GizmoLab.Gameplay.Weapons
{
    public class M16 : IWeapon
    {
        public int DamageAmount { get; } = 25;

        public M16(int damageAmount)
        {
            DamageAmount = damageAmount;
        }

        public void MakeDamage(Alien alien)
        {
            alien.TakeDamage(DamageAmount);
        }
    }
}