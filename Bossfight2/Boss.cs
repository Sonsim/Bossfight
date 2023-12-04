using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight2
{
    internal class Boss
    {
        

        private int _health;
        private string _name;
        private int _strength;
        private int _stamina;

        public Boss(int Health, string Name, int Stamina)
        {
            _health = Health;
            _name = Name;
            _stamina = Stamina;
            _strength = getstrength();

        }

        public void damage(int damage)
        {
            _health = _health - damage;
        }

        public int gethealth()
        {
            return _health;
        }
        public int getstamina()
        {
            return _stamina;
        }

        public int getstrength()
        {
            Random rnd = new Random();
            int damage = rnd.Next(0, 31);

            _strength = damage;

            return _strength;
        }
        public string getname()
        {
            return _name;
        }

        public void Fight(Hero hero)
        {
           
                hero.damage(getstrength());
                _stamina = _stamina - 10;

                Console.WriteLine($"{_name} hit {hero.getname()} for {_strength} damage. " +
                                  $"{hero.getname()} has {hero.gethealth()} hp left");
           
        }

        public void Recharge()
        {
            _stamina = 10; 
            Console.WriteLine($"{_name} needs to recharge");
        }
    }
}
