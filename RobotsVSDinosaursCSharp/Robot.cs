using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaursCSharp
{
    internal class Robot
    {
        public string name;
        public int health;
        public Weapon robotWeapon;

        public Robot()
        {
            Console.WriteLine("Let add a robot: ");
            Console.WriteLine("Enter Robot name: ");
            string robotNameInput = Console.ReadLine();
            name = robotNameInput;
            Console.WriteLine("Enter health: ");
            string healthInput = Console.ReadLine();
            health = int.Parse(healthInput);
            Weapon tempWeapon= new Weapon();
            robotWeapon= tempWeapon;
        }


    }
}
