using System;

namespace GizmoLab.Gameplay.Armor
{
    public class LightArmor : IArmor
    {
        private int _damageReduction = 2;

        public int AbsorbDamage(int initalDamage)
        {
            return Math.Max(0, initalDamage - _damageReduction);
        }
    }
}