using System;
using System.Collections.Generic;
using System.Text;

namespace MMOLibrary
{
    public class Warrior : Unit
    {
        private const double _attackCoefficient = 1.2;
        private const double _defenceCoefficient = 0.75;

        public Warrior() : base(200, 20)
        {

        }

        protected override int CurrentAttackPower
            => (int)(_attackPower * _attackCoefficient);

        public override bool TryDefence(int targetDamage, out int takenDamage)
        {
            takenDamage = (int)(targetDamage * _defenceCoefficient);

            return true;
        }
    }
}
