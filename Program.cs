using System;
using System.Collections.Generic;
namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard joe= new Wizard("joe");
            Ninja sassypants =new Ninja("sassy pants");
            Samurai dopey = new Samurai("dopey");
            joe.Attack(dopey);
            joe.Attack(sassypants);
            joe.Attack(joe);
            joe.Heal(joe);

            
        }
    }
}
