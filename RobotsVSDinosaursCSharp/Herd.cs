using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaursCSharp
{
    internal class Herd
    {
        List<Dinosaur> dinosaurs;

        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            for (int i = 0; i < 3; i++)
            {
                Dinosaur dino = new Dinosaur();
                dinosaurs.Add(dino);

            }
        }
    }
}
