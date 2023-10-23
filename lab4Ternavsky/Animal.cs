using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab4Ternavsky
{
    public class Animal: LivingOrganism, IPredator, IReproducible
    {
        public int Strangth { get; private set; }

        public Animal(int energy, int age, int size, int strangth) : base(energy, age, size)
        {
            this.Strangth = strangth;
        }

        public override void Live()
        {
            Energy -= 5;
        }


        public void Hunt(LivingOrganism prey) 
        {
            if (Strangth > prey.Size)
            { 
                Energy += 10;
                prey.Energy -= 10;
            }
        }

        public LivingOrganism Reproduction()
        {
            return new Animal(Energy / 2, 0, Size / 2, Strangth);
        }
    }
}
