using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab4._2Ternavsky
{
    internal class Computer : IConnectable
    {
        public string Ip { get; protected set; }
        public int Power { get; protected set; }
        public string OsVersion { get; protected set; }



        public Computer(string ip, int power, string osVersion)
        { 
            this.Ip = ip;
            this.Power = power; 
            this.OsVersion = osVersion;
        }

        public void Connect(Computer targetComputer)
        {
        }

        public void Disconnect(Computer targetComputer)
        {
        }

        public void SendData(Computer targetComputer)
        {
        }
    }
}
