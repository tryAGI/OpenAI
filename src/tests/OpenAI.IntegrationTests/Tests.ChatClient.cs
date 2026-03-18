using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ChatClient_CanGetAsInterface()
    {
        using var client = GetAuthorizedApi();

        Meai.IChatClient chatClient = client;

        chatClient.Should().NotBeNull();
    }

    [TestMethod]
    public async Task ChatClient_GetResponseAsync()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "Say hello in exactly 3 words."),
        };

        var response = await chatClient.GetResponseAsync(
            messages,
            new Meai.ChatOptions { ModelId = "gpt-4o-mini" });

        response.Should().NotBeNull();
        response.Messages.Should().NotBeEmpty();

        var text = response.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();
        Console.WriteLine(text);
    }

    [TestMethod]
    public async Task ChatClient_GetStreamingResponseAsync()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "Count from 1 to 5."),
        };

        var updates = new List<Meai.ChatResponseUpdate>();
        await foreach (var update in chatClient.GetStreamingResponseAsync(
            messages,
            new Meai.ChatOptions { ModelId = "gpt-4o-mini" }))
        {
            updates.Add(update);
            var text = string.Concat(update.Contents.OfType<Meai.TextContent>().Select(c => c.Text));
            if (!string.IsNullOrEmpty(text))
            {
                Console.Write(text);
            }
        }
        Console.WriteLine();

        updates.Should().NotBeEmpty();
    }

    [TestMethod]
    public async Task ChatClient_WithSystemMessage()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.System, "You are a pirate. Always respond with 'Arrr!'."),
            new(Meai.ChatRole.User, "Hello!"),
        };

        var response = await chatClient.GetResponseAsync(
            messages,
            new Meai.ChatOptions { ModelId = "gpt-4o-mini" });

        response.Should().NotBeNull();
        var text = response.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();
        Console.WriteLine(text);
    }

    [TestMethod]
    public async Task ChatClient_ReturnsUsage()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "Say 'hi'."),
        };

        var response = await chatClient.GetResponseAsync(
            messages,
            new Meai.ChatOptions { ModelId = "gpt-4o-mini" });

        response.Usage.Should().NotBeNull();
        response.Usage!.InputTokenCount.Should().BeGreaterThan(0);
        response.Usage.OutputTokenCount.Should().BeGreaterThan(0);
        response.Usage.TotalTokenCount.Should().BeGreaterThan(0);
        Console.WriteLine($"Input: {response.Usage.InputTokenCount}, Output: {response.Usage.OutputTokenCount}, Total: {response.Usage.TotalTokenCount}");
    }

    [TestMethod]
    public async Task ChatClient_WithTemperatureAndTopP()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "What is 2+2? Answer with just the number."),
        };

        var response = await chatClient.GetResponseAsync(
            messages,
            new Meai.ChatOptions
            {
                ModelId = "gpt-4o-mini",
                Temperature = 0f,
                TopP = 1f,
            });

        response.Should().NotBeNull();
        var text = response.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();
        text.Should().Contain("4");
        Console.WriteLine($"Temperature=0 response: {text}");
    }

    [TestMethod]
    public async Task ChatClient_StreamingWithTemperatureAndTopP()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "What is 2+2? Answer with just the number."),
        };

        var textBuilder = new System.Text.StringBuilder();
        await foreach (var update in chatClient.GetStreamingResponseAsync(
            messages,
            new Meai.ChatOptions
            {
                ModelId = "gpt-4o-mini",
                Temperature = 0f,
                TopP = 1f,
            }))
        {
            foreach (var content in update.Contents.OfType<Meai.TextContent>())
            {
                textBuilder.Append(content.Text);
            }
        }

        var text = textBuilder.ToString();
        text.Should().NotBeNullOrWhiteSpace();
        text.Should().Contain("4");
        Console.WriteLine($"Streaming Temperature=0 response: {text}");
    }

    [TestMethod]
    public async Task ChatClient_JsonResponseFormat()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "Return a JSON object with a single field 'answer' set to 42. Only output JSON."),
        };

        var response = await chatClient.GetResponseAsync(
            messages,
            new Meai.ChatOptions
            {
                ModelId = "gpt-4o-mini",
                ResponseFormat = new Meai.ChatResponseFormatJson(schema: null),
            });

        response.Should().NotBeNull();
        var text = response.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();
        text.Should().Contain("42");

        // Verify it's valid JSON
        var doc = System.Text.Json.JsonDocument.Parse(text!);
        doc.RootElement.GetProperty("answer").GetInt32().Should().Be(42);
        Console.WriteLine($"JSON response: {text}");
    }

    private static OpenAiClient CreateTestClient() => new(apiKey: "test-key");
}
