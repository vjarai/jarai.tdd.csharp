namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    public interface IAlexaSkill
    {
        bool CanHandleRequest(string request);
        string HandleRequest(string request);
    }
}