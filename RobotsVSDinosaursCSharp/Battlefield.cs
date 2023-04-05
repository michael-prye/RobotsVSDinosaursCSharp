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
            displayWelcome();
            battle();
            winner();

        }

        public void displayWelcome()
        {
            Console.WriteLine("Welcome to Robots Versus Dinosaurs!\nLet the Battle Begin");
            Console.WriteLine("--------");
        }

        public void battle()
        {
            bool winner = false;
            int round = 1;

            string coinToss = CoinToss();
            if (coinToss == "Head")
            {
                Console.WriteLine("It's Heads. Robots will go first");
            }
            else
            {
                Console.WriteLine("It's Tails. Dinosaurs will go first");
            }

            while(winner == false)
            {
                Console.WriteLine("Round: " + round);

                if(coinToss == "Head")
                {
                    robotTurn();
                    if(dinoHerd.dinosaurs.Count== 0)
                    {
                        return;
                    }
                    dinoTurn();
                    if(robotFleet.robots.Count== 0)
                    {
                        return;
                    }
                }
                else
                {
                    dinoTurn();
                    if(robotFleet.robots.Count == 0)
                    {
                        return;
                    }
                    robotTurn();
                    if(dinoHerd.dinosaurs.Count == 0)
                    {
                        return;
                    }
                }
                round += 1;


            }


        }

        public void winner()
        {
            if(robotFleet.robots.Count == 0)
            {
                Console.WriteLine("Dinosaurs win!");
            }
            else
            {
                Console.WriteLine("Robots Win");
            }
        }

        public string CoinToss()
        {
            Console.WriteLine("Lets Flip a coin:\n Heads robots will go first, Tails Dinosaurs will go first!");
            var coin = new List<string> {"Head","Tail"};
            var random = new Random();
            int flip = random.Next(coin.Count);
            return coin[flip];
        }

        public void robotTurn()
        {

            // user input to select attacker and defender
            robotFleet.displayFleet();
            Console.WriteLine("Select attacker: ");
            int attacker = int.Parse(Console.ReadLine());
            dinoHerd.displayHerd();
            Console.WriteLine("Select defender: ");
            int defender = int.Parse(Console.ReadLine());


            // remove health from attack power
            dinoHerd.dinosaurs[defender].health -= robotFleet.robots[attacker].robotWeapon.attackPower;


            // check if defender died
            if(dinoHerd.dinosaurs[defender].health <= 0)
            {
                Console.WriteLine(dinoHerd.dinosaurs[defender].name + " Has fainted");
                dinoHerd.dinosaurs.RemoveAt(defender);

            }
        }

        public void dinoTurn()
        {
            dinoHerd.displayHerd();
            Console.WriteLine("Select attacker: ");
            int attacker = int.Parse(Console.ReadLine());
            robotFleet.displayFleet();
            Console.WriteLine("Select defender: ");
            int defender = int.Parse(Console.ReadLine());

            robotFleet.robots[defender].health -= dinoHerd.dinosaurs[attacker].attackPower;

            if (robotFleet.robots[defender].health <= 0)
            {
                Console.WriteLine(robotFleet.robots[defender].name + " Has Fainted");
                robotFleet.robots.RemoveAt(defender);
            }

        }
        

    }
}
