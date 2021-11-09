using System;
using System.Collections.Generic;
using System.Text;

namespace Exo3
{
    class VoitureVolante : Voiture
    {
        public VoitureVolante(string test) : base(test)
        {
        }   

        public override void rouler()
        {
            Console.WriteLine("VVVVRRRROOOM ..... je suis une voiture volante");
        }
    }
}
