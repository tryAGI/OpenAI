using Meai = Microsoft.Extensions.AI;
using Retry = Microsoft.VisualStudio.TestTools.UnitTesting.RetryAttribute;

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
    [Retry(2)]
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
    [Retry(2)]
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
    [Retry(2)]
    public Task ChatClient_Azure_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Azure);

    // ═══════════════════════════════════════════════════════════════
    //  DeepInfra
    // ═══════════════════════════════════════════════════════════════

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_DeepInfra_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.DeepInfra);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_DeepInfra_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.DeepInfra);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_DeepInfra_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.DeepInfra);

    // --- Groq ---

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Groq_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Groq);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Groq_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Groq);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Groq_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Groq);

    // --- OpenRouter (disabled — free tier rate-limits and doesn't support tools) ---

    // [TestMethod]
    // [Retry(2)]
    // public Task ChatClient_OpenRouter_GetResponse() =>
    //     ChatClient_CustomProvider_GetResponseAsync(CustomProvider.OpenRouter);

    // [TestMethod]
    // [Retry(2)]
    // public Task ChatClient_OpenRouter_Streaming() =>
    //     ChatClient_CustomProvider_StreamingAsync(CustomProvider.OpenRouter);

    // --- Fireworks ---

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Fireworks_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Fireworks);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Fireworks_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Fireworks);

    // Fireworks llama-v3p3-70b-instruct does not reliably support tool calling

    // --- Together ---

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Together_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Together);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Together_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Together);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Together_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Together);

    // --- DeepSeek ---

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_DeepSeek_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.DeepSeek);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_DeepSeek_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.DeepSeek);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_DeepSeek_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.DeepSeek);

    // --- XAi (Grok) ---

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_XAi_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.XAi);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_XAi_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.XAi);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_XAi_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.XAi);

    // --- Perplexity (no tool calling support) ---

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Perplexity_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Perplexity);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Perplexity_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Perplexity);

    // --- SambaNova (disabled — free tier rate-limits) ---

    // [TestMethod]
    // [Retry(2)]
    // public Task ChatClient_SambaNova_GetResponse() =>
    //     ChatClient_CustomProvider_GetResponseAsync(CustomProvider.SambaNova);

    // [TestMethod]
    // [Retry(2)]
    // public Task ChatClient_SambaNova_Streaming() =>
    //     ChatClient_CustomProvider_StreamingAsync(CustomProvider.SambaNova);

    // [TestMethod]
    // [Retry(2)]
    // public Task ChatClient_SambaNova_ToolCalling() =>
    //     ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.SambaNova);

    // --- Mistral ---

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Mistral_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Mistral);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Mistral_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Mistral);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Mistral_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Mistral);

    // --- Cerebras ---

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Cerebras_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Cerebras);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Cerebras_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Cerebras);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Cerebras_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Cerebras);

    // --- Cohere ---

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Cohere_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Cohere);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Cohere_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Cohere);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Cohere_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Cohere);

    // --- Nebius ---

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Nebius_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Nebius);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Nebius_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Nebius);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Nebius_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Nebius);

    // --- Nvidia ---

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Nvidia_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Nvidia);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Nvidia_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Nvidia);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_Nvidia_ToolCalling() =>
        ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.Nvidia);

    // --- Ollama Cloud ---

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_OllamaCloud_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.OllamaCloud);

    [TestMethod]
    [Retry(2)]
    public Task ChatClient_OllamaCloud_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.OllamaCloud);

    // --- GitHub Models ---

    //[TestMethod]
    //[Retry(2)]
    //public Task ChatClient_GitHub_GetResponse() =>
    //    ChatClient_CustomProvider_GetResponseAsync(CustomProvider.GitHub);

    //[TestMethod]
    //[Retry(2)]
    //public Task ChatClient_GitHub_Streaming() =>
    //    ChatClient_CustomProvider_StreamingAsync(CustomProvider.GitHub);

    //[TestMethod]
    //[Retry(2)]
    //public Task ChatClient_GitHub_ToolCalling() =>
    //    ChatClient_CustomProvider_ToolCallingAsync(CustomProvider.GitHub);
}
