using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Ternavsky
{
    public abstract class LivingOrganism
    {

        

        public int Energy { get; internal set; }
        public int Age { get; protected set; }
        public int Size { get; protected set; }

        public LivingOrganism(int energy, int age, int size)
        {
            this.Energy = energy;
            this.Age = age;
            this.Size = size;
        }

        public abstract void Live();

    }
}
