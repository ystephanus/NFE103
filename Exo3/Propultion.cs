using System;
using System.Collections.Generic;
using System.Text;

namespace Exo3
{
    class Propultion : VoitureDecortor
    {
        public Propultion(Voiture voiture) : base(voiture, voiture.type)
        {

        }

        public override void rouler()
        {
            base.rouler();
            Console.WriteLine("Je dispose de putain de propultion");
        }
    }
}
