using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;
        public int Health
        {
            get {return health;}
        }
        public Human (string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health =100;
        }
        public Human(string name, int strength, int intelligence, int dexterity, int hp)
        {
            Name=name;
            Strength=strength;
            Intelligence=intelligence;
            Dexterity=dexterity;
            health = hp;
        }
        public virtual int Attack (Human target)
        {
            int dmg = Strength* 3;
            target.health -=dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damge!");
            return target.health;
        }
    }
}