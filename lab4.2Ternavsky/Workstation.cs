using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace lab4._2Ternavsky
{
    internal class Workstation : Computer, IConnectable
    {
        public int DataSize { get; protected set; }
        private System.Timers.Timer aTimer;
        public Router DefaultGateway { get; protected set; }


        public Workstation(string ip, int power, string osVersion, int dataSize, Router defaultGateway) : base (ip, power, osVersion)
        { 
            DataSize = dataSize;
            DefaultGateway = defaultGateway;
        }

        public void Connect(Computer targetComputer)
        {
            DefaultGateway.Connect(this);
            DefaultGateway.Connect(targetComputer);
            if (DefaultGateway.ConnectedComputers.Contains(targetComputer)) {
                Console.WriteLine($"Ви приєдналися до {targetComputer.Ip}");
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
                aTimer = new System.Timers.Timer(2000 + ((double)DataSize / Power));

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
