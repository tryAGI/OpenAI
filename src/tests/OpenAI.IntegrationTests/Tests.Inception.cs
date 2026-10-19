using System.Net;
using System.Text;
using System.Text.Json;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void InceptionProvider_UsesDocumentedEndpoint()
    {
        using var api = CustomProviders.Inception("test-key");
        api.BaseUri.Should().Be(new Uri("https://api.inceptionlabs.ai/v1"));
    }

    [TestMethod]
    public async Task InceptionProvider_StreamsBlocksWithInstantReasoning()
    {
        string? requestBody = null;
        var handler = new FakeChatHandler(request =>
        {
            requestBody = request.Content!.ReadAsStringAsync().GetAwaiter().GetResult();
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(
                    "data: {\"id\":\"test\",\"object\":\"chat.completion.chunk\",\"created\":0,\"model\":\"mercury-3\",\"choices\":[{\"index\":0,\"delta\":{\"role\":\"assistant\",\"content\":\"\"}}]}\n\n" +
                    "data: {\"id\":\"test\",\"object\":\"chat.completion.chunk\",\"created\":0,\"model\":\"mercury-3\",\"choices\":[{\"index\":0,\"delta\":{\"content\":\"Hello Dubai.\"},\"finish_reason\":\"stop\"}]}\n\n" +
                    "data: [DONE]\n\n", Encoding.UTF8, "text/event-stream"),
            };
        });
        using var api = CreateFakeApi(handler);
        var request = new CreateChatCompletionRequestVariant2
        {
            Model = "mercury-3",
            Messages = ["Say hello."],
            MaxCompletionTokens = 128,
            Stream = true,
            AdditionalProperties = { ["reasoning_effort"] = "instant" },
        };
        var answer = new StringBuilder();
        await foreach (string block in api.Chat.CreateChatCompletionAsStreamAsync(
            new CreateChatCompletionRequest { CreateChatCompletionRequestVariant2 = request }))
        {
            answer.Append(block);
        }

        answer.ToString().Should().Be("Hello Dubai.");
        using var body = JsonDocument.Parse(requestBody!);
        body.RootElement.GetProperty("model").GetString().Should().Be("mercury-3");
        body.RootElement.GetProperty("reasoning_effort").GetString().Should().Be("instant");
        body.RootElement.GetProperty("stream").GetBoolean().Should().BeTrue();
        body.RootElement.EnumerateObject().Count(property => property.Name == "reasoning_effort").Should().Be(1);
    }
}
