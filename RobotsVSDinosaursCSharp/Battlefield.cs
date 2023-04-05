using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaursCSharp
{
    internal class Battlefield
    {
        public Fleet robotFleet;
        public Herd dinoHerd;

        public Battlefield()
        {
            robotFleet = new Fleet();
            dinoHerd= new Herd();
        }

        public void runGame()
        {
            robotFleet.displayFleet();
            dinoHerd.displayHerd();
        }
        

    }
}
