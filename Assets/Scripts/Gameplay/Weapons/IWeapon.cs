namespace GizmoLab.Gameplay.Weapons
{
    public interface IWeapon
    {
        int DamageAmount { get; }

        void MakeDamage(Alien alien);
    }
}