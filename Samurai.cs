using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai
{
    class Samurai :Human
    {
    public Samurai(string name) :base(name)
    {
        health = 200;
    }
        public override int Attack(Human target)
        {
            if(target.health<50)
            {
                int damages = target.health;
                target.health -= damages;
                Console.WriteLine($"the samurai {Name} attacked {target.Name} for {damages} damage!");
                Console.WriteLine(target.Name+" is dead" );
            }
             else
            {
                Attack(target);
            }

            return target.health;
        }


        public void Meditate()
        {
            health=100;
            Console.WriteLine($"{Name} meditates and restores health to {health}!");
        }





    }
}