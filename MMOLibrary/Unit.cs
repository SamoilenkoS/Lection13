using System;

namespace MMOLibrary
{
    public abstract class Unit
    {
        private int _health;
        protected int _attackPower;
        protected abstract int CurrentAttackPower { get; }

        public bool IsAlive
        {
            get
            {
                return _health > 0;
            }
        }

        public Unit(int health, int attackPower)
        {
            _health = health;
            _attackPower = attackPower;
        }

        public int Attack(Unit target)
        {
            //Console.WriteLine($"{GetType()} trying to attack:");
            bool successfull =
               target.TryDefence(CurrentAttackPower,
                   out int targetTakenDamage);
            if (successfull)
            {
                target.TakeDamage(targetTakenDamage);
                //Console.WriteLine($"Attacked {target.GetType()} with damage {targetTakenDamage}!");
                //Console.WriteLine($"Current target health {target._health}");
            }
            else
            {
                //Console.WriteLine("Missed!");
            }

           // Console.WriteLine();

            return targetTakenDamage;
        }

        public abstract bool TryDefence(int targetDamage, out int takenDamage);

        protected void TakeDamage(int damage)
        {
            _health -= damage;
        }
    }
}
