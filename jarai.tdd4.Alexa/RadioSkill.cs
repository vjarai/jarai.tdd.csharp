using System;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public class RadioSkill :  IAlexaSkill
    {
        public  bool CanHandleRequest(string request)
        {
            return request.Contains("radio");
        }

        public  string HandleRequest(string request)
        {
            return "Ich spiele den Radiosender 'HR3'.";
        }
    }
}