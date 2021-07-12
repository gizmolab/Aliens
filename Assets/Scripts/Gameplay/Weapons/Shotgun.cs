﻿namespace GizmoLab.Gameplay.Weapons
{
    public class Shotgun : IWeapon
    {
        public int DamageAmount { get; } = 20;

        public Shotgun(int damageAmount)
        {
            DamageAmount = damageAmount;
        }

        public void MakeDamage(Alien alien)
        {
            alien.TakeDamage(DamageAmount);
        }
    }
}