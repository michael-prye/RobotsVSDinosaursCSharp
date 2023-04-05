using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaursCSharp
{
    internal class Herd
    {
        public List<Dinosaur> dinosaurs;

        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            for (int i = 0; i < 3; i++)
            {
                Dinosaur dino = new Dinosaur();
                dinosaurs.Add(dino);

            }
        }

        public void displayHerd()
        {
            Console.WriteLine("Dinosaur Herd\n");
            for(int i = 0; i<dinosaurs.Count; i++)
            {
                Console.WriteLine(i + ":");
                Console.WriteLine("\nName: "+ dinosaurs[i].name);
                Console.WriteLine("Health: " + dinosaurs[i].health );
                Console.WriteLine("Power: " + dinosaurs[i].attackPower);
            } 
        }
    }
}
