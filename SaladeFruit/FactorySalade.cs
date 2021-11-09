using System;
using System.Collections.Generic;
using System.Text;

namespace Exo1
{
    class FactorySalade
    {
        public FactorySalade() { }
        public static SaladeFruit create(String saison)
        {
            SaladeFruit saladeFruits = new SaladeFruit();
            switch (saison)
            {
                case "ete":
                    for(int i = 0; i < 3; i++)
                    {
                        saladeFruits.add(new Pomme());
                    }
                    break;
                case "hiver":
                    for(int i = 0; i < 3; i++)
                    {
                        saladeFruits.add(new Raisin());
                    }
                    break;
            }
            return saladeFruits;
        }
    }
}
