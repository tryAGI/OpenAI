using Meai = Microsoft.Extensions.AI;
using Retry = Microsoft.VisualStudio.TestTools.UnitTesting.RetryAttribute;

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
    [Retry(2)]
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
    [Retry(2)]
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
    [Retry(2)]
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
    [Retry(2)]
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
    [Retry(2)]
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
    [Retry(2)]
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
    [Retry(2)]
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

    [TestMethod]
    [Retry(2)]
    public async Task ChatClient_JsonSchemaResponseFormat()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var schema = System.Text.Json.JsonDocument.Parse("""
        {
            "type": "object",
            "properties": {
                "name": { "type": "string" },
                "age": { "type": "integer" }
            },
            "required": ["name", "age"],
            "additionalProperties": false
        }
        """).RootElement;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "Return info about a fictional person named Alice who is 30 years old."),
        };

        var response = await chatClient.GetResponseAsync(
            messages,
            new Meai.ChatOptions
            {
                ModelId = "gpt-4o-mini",
                ResponseFormat = new Meai.ChatResponseFormatJson(schema, "person", "A person object"),
            });

        response.Should().NotBeNull();
        var text = response.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();

        var doc = System.Text.Json.JsonDocument.Parse(text!);
        doc.RootElement.GetProperty("name").GetString().Should().Be("Alice");
        doc.RootElement.GetProperty("age").GetInt32().Should().Be(30);
        Console.WriteLine($"Structured output: {text}");
    }

    [TestMethod]
    [Retry(2)]
    public async Task ChatClient_WithAdditionalProperties()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "What is 2+2? Answer with just the number."),
        };

        var options = new Meai.ChatOptions
        {
            ModelId = "gpt-4o-mini",
            Temperature = 0f,
        };
        options.AdditionalProperties ??= new Meai.AdditionalPropertiesDictionary();
        options.AdditionalProperties["seed"] = 42;

        var response = await chatClient.GetResponseAsync(messages, options);

        response.Should().NotBeNull();
        var text = response.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();
        text.Should().Contain("4");
        Console.WriteLine($"AdditionalProperties response: {text}");
    }

    [TestMethod]
    [Retry(2)]
    public async Task ChatClient_StreamingJsonSchemaResponseFormat()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var schema = System.Text.Json.JsonDocument.Parse("""
        {
            "type": "object",
            "properties": {
                "city": { "type": "string" },
                "population": { "type": "integer" }
            },
            "required": ["city", "population"],
            "additionalProperties": false
        }
        """).RootElement;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "Return info about Paris with a population of 2161000."),
        };

        var textBuilder = new System.Text.StringBuilder();
        await foreach (var update in chatClient.GetStreamingResponseAsync(
            messages,
            new Meai.ChatOptions
            {
                ModelId = "gpt-4o-mini",
                ResponseFormat = new Meai.ChatResponseFormatJson(schema, "city_info", "A city info object"),
            }))
        {
            foreach (var content in update.Contents.OfType<Meai.TextContent>())
            {
                textBuilder.Append(content.Text);
            }
        }

        var text = textBuilder.ToString();
        text.Should().NotBeNullOrWhiteSpace();

        var doc = System.Text.Json.JsonDocument.Parse(text);
        doc.RootElement.GetProperty("city").GetString().Should().Be("Paris");
        doc.RootElement.GetProperty("population").GetInt32().Should().Be(2161000);
        Console.WriteLine($"Streaming structured output: {text}");
    }

    [TestMethod]
    [Retry(2)]
    public async Task ChatClient_TextResponseFormat()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "Say 'hello world'."),
        };

        var response = await chatClient.GetResponseAsync(
            messages,
            new Meai.ChatOptions
            {
                ModelId = "gpt-4o-mini",
                ResponseFormat = Meai.ChatResponseFormat.Text,
            });

        response.Should().NotBeNull();
        var text = response.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();
        Console.WriteLine($"Text format response: {text}");
    }

    [TestMethod]
    [Retry(2)]
    public async Task ChatClient_WithImageContent()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var message = new Meai.ChatMessage(Meai.ChatRole.User, []);
        message.Contents.Add(new Meai.TextContent("What is in this image? Answer in one word."));
        message.Contents.Add(new Meai.UriContent(
            new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/PNG_transparency_demonstration_1.png/280px-PNG_transparency_demonstration_1.png"),
            mediaType: "image/png"));

        var messages = new List<Meai.ChatMessage> { message };

        var response = await chatClient.GetResponseAsync(
            messages,
            new Meai.ChatOptions { ModelId = "gpt-4o-mini" });

        response.Should().NotBeNull();
        var text = response.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();
        Console.WriteLine($"Image content response: {text}");
    }

    [TestMethod]
    [Retry(2)]
    public async Task ChatClient_WithStopSequences()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "Count from 1 to 10, separating each number with a comma."),
        };

        var response = await chatClient.GetResponseAsync(
            messages,
            new Meai.ChatOptions
            {
                ModelId = "gpt-4o-mini",
                StopSequences = ["5"],
            });

        response.Should().NotBeNull();
        var text = response.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();
        text.Should().NotContain("6");
        Console.WriteLine($"StopSequences response: {text}");
    }

    private static OpenAiClient CreateTestClient() => new(apiKey: "test-key");
}
