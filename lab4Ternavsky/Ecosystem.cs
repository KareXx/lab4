using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Ternavsky
{
    internal class Ecosystem
    {
        internal List<LivingOrganism> Organism { get; private set; } = new List<LivingOrganism>();

        public void AddOrganism(LivingOrganism organism)
        { 
            Organism.Add(organism);
        }

        public void SimulateDay() 
        {

            List<LivingOrganism> babies = new List<LivingOrganism>();

            foreach (var organism in Organism) 
            {
                organism.Live();

                if (organism is IReproducible reproducible)
                {
                    var baby = reproducible.Reproduction();
                    if (babies != null) babies.Add(baby);
                }

                if (organism is IPredator predator)
                {
                    var prey = Organism.FirstOrDefault(o => o != organism);

                    if (prey != null) 
                    {
                        predator.Hunt(prey);
                    }
                }
            }

            Organism.AddRange(babies);
            Organism.RemoveAll(o => o.Energy <= 0);
        }
    }
}
