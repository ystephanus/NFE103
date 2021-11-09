using System;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat monChat = new Chat("mathieuLeGrosChien");
            Console.WriteLine(monChat.name);
            Chat chatclonner = (Chat)monChat.Clone();
            chatclonner.name = "AymericLeGrosBranleur";
            Console.WriteLine(chatclonner.name);
            Console.WriteLine(monChat.name);

        }
    }
}
