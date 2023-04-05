using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaursCSharp
{
    internal class Fleet
    {
        public List<Robot> robots;

        public Fleet()
        {
            robots = new List<Robot>();

            for(int i = 0; i< 3; i++)
            {
                Robot robot= new Robot();
                robots.Add(robot);
            }
        }

        public void displayFleet()
        {
            Console.WriteLine("Robot Fleet:");
            for(int i = 0; i<robots.Count; i++)
            {
                Console.WriteLine(i + ":");
                Console.WriteLine("Name: " + robots[i].name);
                Console.WriteLine("Health: " + robots[i].health);
                Console.WriteLine("Weapon: " + robots[i].robotWeapon.name + " Power: " + robots[i].robotWeapon.attackPower + "\n");

            }

        }

    }
}
