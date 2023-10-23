using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2Ternavsky
{
    internal interface IConnectable
    {
        void Connect(Computer targetComputer);
        void Disconnect(Computer targetComputer);
        void SendData(Computer targetComputer);
    }
}
