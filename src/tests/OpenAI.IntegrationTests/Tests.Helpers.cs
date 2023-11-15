using OpenAI;

namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static OpenAIClient GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        return new OpenAIClient(apiKey);
    }
}
