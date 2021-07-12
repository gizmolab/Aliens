namespace GizmoLab.Gameplay.Weapons
{
    public class AK47 : IWeapon
    {
        public int DamageAmount { get; } = 25;

        public AK47(int damageAmount)
        {
            DamageAmount = damageAmount;
        }

        public void MakeDamage(Alien alien)
        {
            alien.TakeDamage(DamageAmount);
        }
    }
}