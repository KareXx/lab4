using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2Ternavsky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Network network = new Network();

            Router router1 = new Router("116.34.162.1", 3, "ubuntu 18.01", 8);
            Router router2 = new Router("117.34.234.1", 3, "ubuntu 18.01", 8);
            network.AddComputer(router1);
            network.AddComputer(router2);
            network.AddComputer(new Workstation("118.34.234.7", 2, "ubuntu 20.04", 2048, router1));
            network.AddComputer(new Server("118.34.234.7", 2, "ubuntu 20.04", router2, 5));


            Console.WriteLine($"{network.ConnectedComputers.Count} кількість пристроїв");

            for (int i = 0; i < 5; i++)
            {
                network.SimulateDay();
            }

            Console.WriteLine("Симуляція закінчена");

            Console.ReadLine();
        }
    }
}