using System;
using System.Collections.Generic;
using System.Text;

namespace Exo3
{
    public abstract class Voiture
    {
        public string type  { get; set; } = null;

        public Voiture(String type)
        {
            this.type = type;
        }

        abstract public void rouler();
    }
}
