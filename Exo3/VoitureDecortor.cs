using System;
using System.Collections.Generic;
using System.Text;

namespace Exo3
{
    abstract class VoitureDecortor : Voiture
    {
        private Voiture voiture { get; set; } = null;
        public VoitureDecortor(Voiture voiture, string state) : base(state)
        {
            this.voiture = voiture;
        }
        public override void rouler()
        {
            this.voiture.rouler();
        }
    }
}
