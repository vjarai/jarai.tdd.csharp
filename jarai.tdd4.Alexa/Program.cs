using System;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myAlexa = new Alexa();

            myAlexa.InstallSkill(new RadioSkill());
            myAlexa.InstallSkill(new WettervorhersageSkill());
            myAlexa.InstallSkill(new LampenSkill());

            //myAlexa.InstallSkills();

            myAlexa.HandleRequest("Spiele Radio HR3");
            myAlexa.HandleRequest("Wie wird das Wetter?");
            myAlexa.HandleRequest("Schalte Licht Wohnzimmer ein");
            myAlexa.HandleRequest("Was ist der Sinn des Lebens?");

            Console.ReadLine();
        }
    }
}