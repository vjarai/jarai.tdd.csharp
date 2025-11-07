using System;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public class LampenSkill : IAlexaSkill
    {
        public bool CanHandleRequest(string request)
        {
            return request.Contains("licht");
        }

        public string HandleRequest(string request)
        {
            return "Licht ist ein";
        }
    }
}