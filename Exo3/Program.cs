using System;

namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Voiture vVolante = VoitureFactory.createVoiture("Voiture Volante");
            Navigation vVolanteNavigation = new Navigation(vVolante);
            Propultion VVolanteNavigationPropolution = new Propultion(vVolanteNavigation);
            VVolanteNavigationPropolution.rouler();
        }
    }
}
