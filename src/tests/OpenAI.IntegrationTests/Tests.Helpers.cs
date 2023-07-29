namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static OpenAiApi GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var client = new HttpClient();
        return new OpenAiApi(apiKey, client);
    }
}
