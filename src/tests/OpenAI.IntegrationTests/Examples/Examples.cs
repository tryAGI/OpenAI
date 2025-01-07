namespace tryAGI.OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    public static OpenAiClient GetAuthenticatedClient()
    {
        return new OpenAiClient(apiKey:
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found."));
    }
}
