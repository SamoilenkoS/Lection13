using System;
using System.Collections.Generic;
using System.Text;

namespace MMOLibrary
{
    public class Archer : Unit
    {
        private const double _damageGotCoefficient = 1.2;
        private const double _dodgeCoefficient = 0.3;
        private const double _criticalStrikeChance = 0.42;
        private const double _criticalStrikeDamage = 2;
        private static Random _random;

        static Archer()
        {
            _random = new Random();
        }

        public Archer() : base(120, 35)
        {
        }

        protected override int CurrentAttackPower
        {
            get
            {
                double attackModifier = (_random.NextDouble() <= _criticalStrikeChance)
                    ? _criticalStrikeDamage
                    : 1;

                return (int)(_attackPower * attackModifier);
            }
        }

        public override bool TryDefence(int targetDamage, out int takenDamage)
        {
            takenDamage = 0;

            if (_random.NextDouble() <= _dodgeCoefficient)
            {
                return false;
            }

            takenDamage = (int)(targetDamage * _damageGotCoefficient);

            return true;
        }
    }
}
