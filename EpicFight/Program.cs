using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villain = PickVillain();
            Console.WriteLine($"{hero} will fight {villain}.");

            string heroWeapon = PickWeapon();
            string villianWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}. {villian} picked {villianWeapon}");
        }

        private static string PickHero()
        {
            string[] superHeroes = { "OsamaBinLaden", "Batman", "Spiderman", "SpongeBobCrackPants", "OptimusBlyatuimus" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeroes.Length);

            return superHeroes[randomIndex];
        }

        private static string PickVillain()
        {
            string[] superVillians = { "Joker", "JohnnySins", "PiiderMan", "BarrackOsama", "MiaKhalifa" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superVillians.Length);

            return superVillians[randomIndex];



        }
        private static string pickWeapon()
        {
            string[] Weapon = { "OsamaBinLaden", "Batman", "Spiderman", "SpongeBobCrackPants", "OptimusBlyatuimus" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Weapon.Length);

            return Weapon[randomIndex];
        }
            

    }
}
