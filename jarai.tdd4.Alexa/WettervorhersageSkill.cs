using System;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public class WettervorhersageSkill :  IAlexaSkill
    {
        public  bool CanHandleRequest(string request)
        {
            return request.Contains("wetter");
        }

        public  string HandleRequest(string request)
        {
            return $"Morgen, am {DateTime.Today + new TimeSpan(1, 0, 0, 0):dd.MM.yy} scheint die Sonne.";
        }
    }
}