using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight2
{
    internal class Hero
    {
        private int _health;
        private string _name;
        private int _strength;
        private int _stamina;

        public Hero(int Health, string Name, int Strength, int Stamina)
        {
            _health = Health;
            _name = Name;
            _strength = Strength;
            _stamina = Stamina;

        }
        public int gethealth()
        {
            return _health;
        }

        public int getstamina()
        {
            return _stamina;
        }
        public string getname()
        {
            return _name;
        }
        public int getstrength()
        {
            return _strength;
        }

        public void damage(int damage)
        {
            _health = _health - damage;
        }
        
        public void Fight(Boss boss)
        {
            
            boss.damage(_strength);
            _stamina = _stamina - 10;

            Console.WriteLine($"{_name} hit {boss.getname()} for {_strength} damage. " +
                              $"{boss.getname()} has {boss.gethealth()} hp left");
            
        }
        public void Recharge()
        {
            
            _stamina = 40;
            Console.WriteLine($"{_name} needs to recharge");
        }
    }
}
