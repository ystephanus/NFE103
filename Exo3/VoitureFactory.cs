using System;
using System.Collections.Generic;
using System.Text;

namespace Exo3
{
    class VoitureFactory
    {
        public static Voiture createVoiture(String type)
        {
            if(type == "Voiture Volante")
            {
                return new VoitureVolante("Voiture volante");
            }else if(type == "Voiture flottante")
            {
                return new VoitureVolante("Voiture flottante");
            }
            return null;

        }
    }
}
