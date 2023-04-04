using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaursCSharp
{
    internal class Fleet
    {
        List<Robot> robots;

        public Fleet()
        {
            robots = new List<Robot>();

            for(int i = 0; i< 3; i++)
            {
                Robot robot= new Robot();
                robots.Add(robot);
            }
        }
    }
}
