namespace tryAGI.OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    public static OpenAiClient GetAuthenticatedClient()
    {
        return new OpenAiClient(apiKey:
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") is { Length: > 0 } apiKeyValue
            ? apiKeyValue
            : throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found."));
    }
}
