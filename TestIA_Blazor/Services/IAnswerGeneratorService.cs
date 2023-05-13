namespace TestIA_Blazor.Services
{
    public interface IAnswerGeneratorService
    {
        Task<string> GenerateAnswer(string answer);

    }
}
