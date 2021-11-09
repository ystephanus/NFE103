using System;
using System.Collections.Generic;
using System.Text;

namespace Exo3
{
    class VoitureFlotante : Voiture
    {
        public VoitureFlotante(String type) : base(type) { }
        public override void rouler()
        {
            Console.WriteLine("Vrrrrrooooommmm, je suis une voiture Flottante");
        }
    }
}
