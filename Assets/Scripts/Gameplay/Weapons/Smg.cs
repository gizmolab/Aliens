namespace GizmoLab.Gameplay.Weapons
{
    public class SMG : IWeapon
    {
        public int DamageAmount { get; } = 25;

        public void MakeDamage(Alien alien)
        {
            alien.TakeDamage(DamageAmount);
        }
    }
}