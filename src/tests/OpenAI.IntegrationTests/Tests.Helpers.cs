namespace OpenAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static OpenAiApi GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var client = new OpenAiApi();
        client.AuthorizeUsingBearer(apiKey);

        return client;
    }
}
