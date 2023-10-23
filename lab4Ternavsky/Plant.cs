using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Ternavsky
{
    internal class Plant : LivingOrganism, IReproducible
    {
        public int PhotosyntesisEfficiency { get; private set; }

        public Plant(int energy, int age, int size, int photosyntesisEfficiency) : base(energy, age, size)
        {
            this.PhotosyntesisEfficiency = photosyntesisEfficiency;
        }

        public override void Live()
        {
            Energy -= 3;
            Energy += PhotosyntesisEfficiency;
        }

        public LivingOrganism Reproduction()
        {
            Energy -= 2;
            return new Plant(Energy / 2, 0, Size / 2, PhotosyntesisEfficiency);
        }

    }
}
