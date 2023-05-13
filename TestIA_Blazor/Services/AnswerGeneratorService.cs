using OpenAI_API;
using OpenAI_API.Completions;

namespace TestIA_Blazor.Services
{
    public class AnswerGeneratorService: IAnswerGeneratorService
    {
        public async Task<string> GenerateAnswer(string Prompt)
        {
            string apiKey = "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";
            string answer = string.Empty;

            var openai = new OpenAIAPI(apiKey);
            CompletionRequest completion = new CompletionRequest();
            completion.Prompt = Prompt;
            completion.MaxTokens= 4000;
            var result = await openai.Completions.CreateCompletionAsync(completion);

            if(result != null)
            {
                foreach(var item in result.Completions)
                {
                    answer = item.Text;
                }
            }

            return answer;
        }

    }
}
