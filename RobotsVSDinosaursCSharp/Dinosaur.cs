using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaursCSharp
{
    internal class Dinosaur
    {
        public string name;
        public int health;
        public int attackPower;

        public Dinosaur()
        {
            Console.WriteLine("Lets add a Dinosaur: ");
            Console.WriteLine("Enter Donosaur name: ");
            string dinoName = Console.ReadLine();
            name = dinoName;
            Console.WriteLine("Enter health ");
            string dinoHealth = Console.ReadLine();
            health = int.Parse(dinoHealth);
            Console.WriteLine("Enter attack power: ");
            string dinoPower = Console.ReadLine();
            attackPower = int.Parse(dinoPower);
        }
    }
}
