using System;
using System.Collections.Generic;


namespace WizardNinjaSamurai
{
    class Ninja : Human
    {
        public Ninja (string name) :base(name)
        {
            Dexterity=175;
        }


        public override int Attack(Human target)
        {
            int critHit =0;
            Random rand = new Random();
            int damages = 5 * Dexterity;//multiply the dex nd assign it to dammages
            if (rand.Next(1,6)==1)//creates the 20% chance
            {
                critHit = 10;
                target.health -= damages;/// if we had meet 20% we get random number

            }

            else if(critHit == 0)
            {
                target.health -= damages;// this is where we take out damages out 
                System.Console.WriteLine($"Ninja !!! {Name} stealth attacked {target.Name}"); 

            }
            return target.Health;
        }



        public void Steal(Human target)
        {
        if (target.health>5)
        {
            target.health-=5;
            health+=5;
            Console.WriteLine($"{Name} steals 5 health from {target.Name}");
        }


    }

    }
}