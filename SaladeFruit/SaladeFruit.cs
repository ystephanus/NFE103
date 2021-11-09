using System;
using System.Collections.Generic;
using System.Text;

namespace Exo1
{
    class SaladeFruit : Fruit
    {
        public List<Fruit> saladefruit { get; set; } = null;
        public SaladeFruit()
        {
            saladefruit = new List<Fruit>();
        }

        public void add(Fruit f)
        {
            saladefruit.Add(f);
        }

        public void remove(Fruit f)
        {
            saladefruit.Remove(f);
        }

        
    }
}
