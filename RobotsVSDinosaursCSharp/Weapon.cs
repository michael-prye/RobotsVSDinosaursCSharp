using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaursCSharp
{
    internal class Weapon
    {
        public string name;
        public int attackPower;
        
     public Weapon()
        {
            Console.WriteLine("Lets add a weapon:");
            Console.WriteLine("Enter name of weapon: ");
            string weaponInput = Console.ReadLine();
            name = weaponInput;
            Console.WriteLine("Enter attack power: ");
            string attackPowerInput = Console.ReadLine();
            attackPower = int.Parse(attackPowerInput);
        }



      
    }
}
