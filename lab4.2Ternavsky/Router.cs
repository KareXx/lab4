using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace lab4._2Ternavsky
{
    internal class Router:Computer, IConnectable
    {
        public int PortsQuantity { get; protected set; }
        private List<Computer> connectedComputers = new List<Computer>();

        private System.Timers.Timer aTimer;


        public Router(string ip, int power, string osVersion, int portsQuantity) : base(ip, power, osVersion)
        {
            PortsQuantity = portsQuantity;
        }

        public List<Computer> ConnectedComputers
        {
            get { return connectedComputers; }
        }

        public void Connect(Computer targetComputer)
        {
            if (connectedComputers.Contains(targetComputer))
            {
                Console.WriteLine($"пристрій {targetComputer.Ip} вже приєднаний");
            }
            else if (connectedComputers.Count < PortsQuantity)
            {
                connectedComputers.Add(targetComputer);
                Console.WriteLine($"Ви приєдналися до {targetComputer.Ip}");
            }
            else
            {
                Console.WriteLine("Ви не можете приєднатися");
            }
        }
        public void Disconnect(Computer targetComputer)
        {
            if (connectedComputers.Contains(targetComputer))
            {
                Console.WriteLine($"Звязок із пристрєм {targetComputer.Ip} {targetComputer.OsVersion} був перерваний");
                connectedComputers.Remove(targetComputer);
            }
        }
        public void SendData(Computer targetComputer)
        {
            aTimer = new System.Timers.Timer(2000 / Power);

            aTimer.Elapsed += (sender, e) =>
            {
                Console.WriteLine($"Дані відправлені за ip адресою: {targetComputer.Ip}");
                Disconnect(targetComputer);
                aTimer.Dispose();
            };

            aTimer.AutoReset = false;
            aTimer.Enabled = true;

        }
    }
    
}
