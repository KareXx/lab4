using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace lab4._2Ternavsky
{
    internal class Server: Computer, IConnectable
    {

        public int MaxConnections { get; protected set; }
        public Router DefaultGateway { get; protected set; }

        private List<Computer> connectedComputers = new List<Computer>();
        private System.Timers.Timer aTimer;


        public Server(string ip, int power, string osVersion, Router defaultGateway, int maxConnections) : base(ip, power, osVersion)
        {
            MaxConnections = maxConnections;
            DefaultGateway = defaultGateway;
        }
        public List<Computer> ConnectedComputers
        {
            get { return connectedComputers; }
        }

        public void Connect(Computer targetComputer)
        {
            if (ConnectedComputers.Count < MaxConnections)
            {
                DefaultGateway.Connect(this);
                DefaultGateway.Connect(targetComputer);
                if (DefaultGateway.ConnectedComputers.Contains(targetComputer))
                {
                    Console.WriteLine($"Ви приєдналися до {targetComputer.Ip}");
                }
                else
                {
                    Console.WriteLine($"Ви не можете приєднатися до {targetComputer.Ip}");
                }
            }
            else 
            {
                Console.WriteLine("Ви не можете приєднатися");
            }
            
        }

        public void Disconnect(Computer targetComputer)
        {
            Console.WriteLine($"Звязок із пристрєм {targetComputer.Ip} {targetComputer.OsVersion} був перерваний");
        }

        public void SendData(Computer targetComputer)
        {
            DefaultGateway.Connect(targetComputer);

            if (DefaultGateway.ConnectedComputers.Contains(targetComputer))
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
}
