using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2Ternavsky
{
    internal class Network
    {
        internal List<Computer> ConnectedComputers { get; private set; } = new List<Computer>();

        public void AddComputer(Computer computer)
        {
            ConnectedComputers.Add(computer);
            Console.WriteLine($"Пристрій {computer.Ip} доданий до мережі");
        }

        public void RemoveComputer(Computer computer)
        {
            ConnectedComputers.Remove(computer);
            Console.WriteLine($"Пристрій {computer.Ip} був видалений з мережі");
        }


        public void SimulateDay()
        {

            foreach (var sender in ConnectedComputers)
            {
                foreach (var receiver in ConnectedComputers)
                {
                    if (sender != receiver)
                    {
                
                        sender.Connect(receiver);
                        sender.SendData(receiver);

                    }
                }
            }
        }
    }
}
