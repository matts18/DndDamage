using System;
namespace DndDamage
{
    class SwordDamage : WeaponDamage
    {

        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public SwordDamage(int roll):base(roll) { }

        protected override void CalculateDamage()
        {
            double magicMultiplier = 1;

            if (Magic) magicMultiplier = 1.75;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;

        }   


    }
}
