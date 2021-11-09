using System;
using System.Collections.Generic;
using System.Text;

namespace Exo3
{
    class Navigation : VoitureDecortor
    {
        public Navigation(Voiture voiture) : base(voiture, voiture.type)
        {

        }

        public override void rouler()
        {
            base.rouler();
            Console.WriteLine("Je possède un bon putain de système de navigation");
        }
    }
}
