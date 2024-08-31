namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    public static OpenAiApi GetAuthenticatedClient()
    {
        return new OpenAiApi(apiKey:
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found."));
    }
}
