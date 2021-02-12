
using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai
{
    class Wizard : Human
    {
        public Wizard(string name):base(name)
        {
            Intelligence = 25;
           
        }
        public override int Attack( Human target)
        {
            int damages = Intelligence*5;
            target.health = damages;
            health += damages;
            Console.WriteLine($"{Name} attacked {target.Name} for {damages} damage!");
            return target.Health;
        }
        public int Heal( Human target)
        {
            int healWiz = 10*Intelligence;
            target.health+=healWiz;
            Console.WriteLine($"The Human by the {Name} heals the human {target.Name} for {healWiz} HP!");
            return target.Health;
        }
 
    }
}