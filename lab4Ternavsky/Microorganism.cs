using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Ternavsky
{
    public class Microorganism : LivingOrganism, IReproducible
    {

        public int MutationRate {get; private set;} 

        public Microorganism(int energy, int age, int size, int mutationRate) : base(energy, age, size)
        {
            this.MutationRate = mutationRate;
        }

        public override void Live()
        {
            Energy -= 2;
            if (new Random().Next(maxValue: 100) < MutationRate)
            {
                Size += 1;
            }
        }

        public LivingOrganism Reproduction()
        {
            return new Microorganism(Energy / 2, 0, Size, MutationRate);
        }
    }
}
