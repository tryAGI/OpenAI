using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI.IntegrationTests;

/// <summary>
/// Tests MEAI IChatClient interface across all OpenAI-compatible CustomProviders.
/// Each provider requires its own API key environment variable.
/// </summary>
public partial class Tests
{
    // ═══════════════════════════════════════════════════════════════
    //  Shared helpers
    // ═══════════════════════════════════════════════════════════════

    private async Task ChatClient_CustomProvider_GetResponseAsync(CustomProvider provider)
    {
        var (api, model) = GetAuthorizedChatApi(provider);
        using var _ = api;
        Meai.IChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "Say hello in exactly 3 words.")],
            new Meai.ChatOptions { ModelId = model });

        response.Should().NotBeNull();
        response.Messages.Should().NotBeEmpty();
        var text = response.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();
        Console.WriteLine($"[{provider}] {text}");
    }

    private async Task ChatClient_CustomProvider_StreamingAsync(CustomProvider provider)
    {
        var (api, model) = GetAuthorizedChatApi(provider);
        using var _ = api;
        Meai.IChatClient chatClient = api;

        var updates = new List<Meai.ChatResponseUpdate>();
        await foreach (var update in chatClient.GetStreamingResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "Count from 1 to 5.")],
            new Meai.ChatOptions { ModelId = model }))
        {
            updates.Add(update);
        }

        updates.Should().NotBeEmpty();
        Console.WriteLine($"[{provider}] Got {updates.Count} streaming updates");
    }

    private async Task ChatClient_CustomProvider_ToolCallingAsync(CustomProvider provider)
    {
        var (api, model) = GetAuthorizedChatApi(provider);
        using var _ = api;
        Meai.IChatClient chatClient = api;

        var tool = Meai.AIFunctionFactory.Create(
            (string city) => city switch
            {
                "Paris" => "22°C, sunny",
                "London" => "15°C, cloudy",
                _ => "Unknown",
            },
            name: "GetWeather",
            description: "Gets the current weather for a city");

        var response = await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "What's the weather in Paris?")],
            new Meai.ChatOptions
            {
                ModelId = model,
                Tools = [tool],
            });

        response.Should().NotBeNull();
        response.FinishReason.Should().Be(Meai.ChatFinishReason.ToolCalls);

        var functionCall = response.Messages
            .SelectMany(m => m.Contents)
            .OfType<Meai.FunctionCallContent>()
            .FirstOrDefault();

        functionCall.Should().NotBeNull();
        functionCall!.Name.Should().Be("GetWeather");
        Console.WriteLine($"[{provider}] Tool call: {functionCall.Name}({string.Join(", ", functionCall.Arguments?.Select(kv => $"{kv.Key}={kv.Value}") ?? [])})");
    }

    // ═══════════════════════════════════════════════════════════════
    //  Azure
    // ═══════════════════════════════════════════════════════════════

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public async Task ChatClient_Azure_GetResponse()
    {
        var (api, model) = GetAuthorizedChatApi(CustomProvider.Azure);
        using var _ = api;
        Meai.IChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "Say hello in exactly 3 words.")],
            new Meai.ChatOptions { ModelId = model });

        response.Should().NotBeNull();
        response.Messages.Should().NotBeEmpty();
        Console.WriteLine($"[Azure] {response.Messages[0].Text}");
    }

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public async Task ChatClient_Azure_Streaming()
    {
        var (api, model) = GetAuthorizedChatApi(CustomProvider.Azure);
        using var _ = api;
        Meai.IChatClient chatClient = api;

        var updates = new List<Meai.ChatResponseUpdate>();
        await foreach (var update in chatClient.GetStreamingResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "Count from 1 to 5.")],
            new Meai.ChatOptions { ModelId = model }))
        {
            updates.Add(update);
        }

        updates.Should().NotBeEmpty();
        Console.WriteLine($"[Azure] Got {updates.Count} streaming updates");
    }

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Azure_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Azure);

    // ═══════════════════════════════════════════════════════════════
    //  DeepInfra
    // ═══════════════════════════════════════════════════════════════

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_DeepInfra_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.DeepInfra);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_DeepInfra_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.DeepInfra);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_DeepInfra_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.DeepInfra);

    // --- Groq ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Groq_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Groq);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Groq_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Groq);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Groq_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Groq);

    // --- OpenRouter ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_OpenRouter_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.OpenRouter);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_OpenRouter_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.OpenRouter);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_OpenRouter_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.OpenRouter);

    // --- Fireworks ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Fireworks_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Fireworks);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Fireworks_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Fireworks);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Fireworks_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Fireworks);

    // --- Together ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Together_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Together);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Together_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Together);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Together_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Together);

    // --- DeepSeek ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_DeepSeek_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.DeepSeek);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_DeepSeek_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.DeepSeek);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_DeepSeek_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.DeepSeek);

    // --- XAi (Grok) ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_XAi_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.XAi);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_XAi_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.XAi);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_XAi_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.XAi);

    // --- Perplexity (no tool calling support) ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Perplexity_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Perplexity);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Perplexity_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Perplexity);

    // --- SambaNova ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_SambaNova_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.SambaNova);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_SambaNova_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.SambaNova);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_SambaNova_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.SambaNova);

    // --- Mistral ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Mistral_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Mistral);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Mistral_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Mistral);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Mistral_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Mistral);

    // --- Cerebras ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Cerebras_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Cerebras);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Cerebras_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Cerebras);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Cerebras_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Cerebras);

    // --- Cohere ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Cohere_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Cohere);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Cohere_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Cohere);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Cohere_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Cohere);

    // --- Nebius ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Nebius_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Nebius);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Nebius_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Nebius);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_Nebius_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Nebius);

    // --- GitHub Models ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_GitHub_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.GitHub);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_GitHub_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.GitHub);

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task ChatClient_GitHub_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.GitHub);
}
