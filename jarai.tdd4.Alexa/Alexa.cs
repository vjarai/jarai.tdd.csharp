using System;
using System.Collections.Generic;
using System.Linq;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public class Alexa
    {
        private List<IAlexaSkill> _installedSkills = new List<IAlexaSkill>();

        public void InstallSkills()
        {
            // Erstellt Instanzen von allen Klassen, die von AlexaSkill abgeleitet sind.
            _installedSkills = (from type in GetType().Assembly.GetTypes()
                where !type.IsAbstract && typeof(IAlexaSkill).IsAssignableFrom(type)
                select (IAlexaSkill)Activator.CreateInstance(type)).ToList();
        }

        public void InstallSkill(IAlexaSkill newSkill)
        {
            _installedSkills.Add(newSkill);
        }


        public void HandleRequest(string request)
        {
            var requestHandler = _installedSkills.FirstOrDefault(skill => skill.CanHandleRequest(request.ToLower()));

            if (requestHandler == null)
                Console.WriteLine($"Entschuldigung, '{request}' habe ich leider nicht verstanden (Fehlt ein Skill?).");
            else
            {
                var response = requestHandler.HandleRequest(request);
                Console.WriteLine(response);
            }
        }
    }
}