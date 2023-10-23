using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab4Ternavsky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ecosystem ecosystem = new Ecosystem();

            ecosystem.AddOrganism(new Animal(150, 6, 12, 8));
            ecosystem.AddOrganism(new Plant(60, 3, 4, 5));
            ecosystem.AddOrganism(new Microorganism(15, 1, 1, 5));


            Console.WriteLine($"{ecosystem.Organism.Count} initial quantity of organism");

            for (int i = 0; i < 20; i++)
            {
                ecosystem.SimulateDay();
                Console.WriteLine($"{ecosystem.Organism.Count} organism alive after {i+1} days");
            }

            Console.WriteLine("Simulation finished");

            Console.ReadLine(); 
        }
    }
}