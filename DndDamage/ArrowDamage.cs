using System;
namespace DndDamage
{
    class ArrowDamage : WeaponDamage
    {
     
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        public ArrowDamage(int roll):base(roll) { }

        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) baseDamage += FLAME_DAMAGE;
            Damage = (int)Math.Ceiling(baseDamage);
            
        }
    }
}
