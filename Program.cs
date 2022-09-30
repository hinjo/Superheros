using ArvTest;
using System;
using System.Collections;
using System.Collections.Generic;
using ExtensionMethods;
using System.Runtime.CompilerServices;
using System.Reflection.Metadata;

namespace ArvTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            //switched from using interface to using abstract class of Superman
            //SupermanI supermanI = new SupermanI("Clark Kent", 3000, 1500);
            //Console.WriteLine("Hello " + supermanI.Name + ", " + supermanI.FlightHeight + ", " + supermanI.LifeLengthYears);

            Superman superman = new Superman("Clark Kent", 3000, 1500);
            Spiderman spiderman = new Spiderman("Peter Parker", 2000, 30);

            Console.WriteLine("Hello " + superman.Name + ", " + superman.FlightHeight + ", " + superman.LifeLengthYears);

            IList<AHero> heroes = new List<AHero>();
            heroes.Add(superman);
            heroes.Add(spiderman);

            superman.UseSuperPower();

            //......


            //Alt 1.
            //foreach (AHero hero in heroes)
            //{
            //    //hero.HealSuperHero();
            //    bool isHealed = hero.HealMe();
            //    if (isHealed == false)
            //    {
            //        //1. HealSuperHero(hero); //We rebuilt the static HealSuperHero method to an Extension Method

            //        //2. hospital.HealSuperHero(ref hero);   //Cannot use 'hero' as a ref or out value because it is a 'foreach iteration variable'


            //        //3. AHero heroInNeed = hero;      //this will not update our hero's health in heroes list, look in heroes a see that Spider Man is still called Peter Parked (without 2 at the end)
            //        //hospital.HealSuperHero(ref heroInNeed);

            //        //4. Try fix problem in 3.
            //        AHero heroInNeed = hero;
            //        hospital.HealSuperHero(ref heroInNeed);
            //        heroes.Add(heroInNeed);             //System.InvalidOperationException: 'Collection was modified; enumeration operation may not execute.'
            //        heroes.Remove(hero);                //System.InvalidOperationException: 'Collection was modified; enumeration operation may not execute.'
            //    }
            //}

            //Alt 2. Does Step 4. i foreach above without throwing an exception
            for (int i = 0; i < heroes.Count; i++)
            {
                bool isHealed = heroes[i].HealMe();
                if (isHealed == false)
                {
                    //2. hospital.HealSuperHero(ref heroes[i]); //if we just send in heroes[i] without ref our hero will not be healed in this array

                    //3. hospital.HealSuperHero(ref heroes[i]);  //A property or indexer may not be passed as an out or ref parameter

                    AHero heroInNeed = heroes[i];
                    hospital.HealSuperHero(ref heroInNeed); 
                    heroes[i] = heroInNeed;
                }
            }            
        }

        //static HealSuperHero method replaced by the extension method below
        //private static void HealSuperHero(AHero hero)
        //{
        //    hero.HealMe();
        //}
    }

    
}

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        //We got "Error	CS0051	Inconsistent accessibility: parameter type 'AHero' is less accessible than method
        //'MyExtensions.HealSuperHero(AHero)'"
        //Solution: set Public a access modifier on AHero abstract class
        public static void HealSuperHero(this Hospital hospital, ref AHero hero)   //extension method
        {
            //We destroy current Spiderman and create a new one
            if(hero is Spiderman)
            {
                hero = null;
                hero = new Spiderman("Peter Parker 2", 2000, 30);
            }
        }
    }
}