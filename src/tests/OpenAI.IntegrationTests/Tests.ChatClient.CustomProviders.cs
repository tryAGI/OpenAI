using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI.IntegrationTests;

/// <summary>
/// Tests MEAI IChatClient interface across all OpenAI-compatible CustomProviders.
/// Each provider requires its own API key environment variable.
/// </summary>
public partial class Tests
{
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

    // --- DeepInfra ---

    [TestMethod]
    public Task ChatClient_DeepInfra_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.DeepInfra);

    [TestMethod]
    public Task ChatClient_DeepInfra_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.DeepInfra);

    // --- Groq ---

    [TestMethod]
    public Task ChatClient_Groq_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Groq);

    [TestMethod]
    public Task ChatClient_Groq_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Groq);

    // --- OpenRouter ---

    [TestMethod]
    public Task ChatClient_OpenRouter_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.OpenRouter);

    [TestMethod]
    public Task ChatClient_OpenRouter_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.OpenRouter);

    // --- Fireworks ---

    [TestMethod]
    public Task ChatClient_Fireworks_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Fireworks);

    [TestMethod]
    public Task ChatClient_Fireworks_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Fireworks);

    // --- Together ---

    [TestMethod]
    public Task ChatClient_Together_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Together);

    [TestMethod]
    public Task ChatClient_Together_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Together);

    // --- DeepSeek ---

    [TestMethod]
    public Task ChatClient_DeepSeek_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.DeepSeek);

    [TestMethod]
    public Task ChatClient_DeepSeek_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.DeepSeek);

    // --- XAi (Grok) ---

    [TestMethod]
    public Task ChatClient_XAi_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.XAi);

    [TestMethod]
    public Task ChatClient_XAi_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.XAi);

    // --- Perplexity ---

    [TestMethod]
    public Task ChatClient_Perplexity_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Perplexity);

    [TestMethod]
    public Task ChatClient_Perplexity_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Perplexity);

    // --- SambaNova ---

    [TestMethod]
    public Task ChatClient_SambaNova_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.SambaNova);

    [TestMethod]
    public Task ChatClient_SambaNova_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.SambaNova);

    // --- Mistral ---

    [TestMethod]
    public Task ChatClient_Mistral_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Mistral);

    [TestMethod]
    public Task ChatClient_Mistral_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Mistral);

    // --- Cerebras ---

    [TestMethod]
    public Task ChatClient_Cerebras_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Cerebras);

    [TestMethod]
    public Task ChatClient_Cerebras_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Cerebras);

    // --- Cohere ---

    [TestMethod]
    public Task ChatClient_Cohere_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Cohere);

    [TestMethod]
    public Task ChatClient_Cohere_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Cohere);

    // --- Nebius ---

    [TestMethod]
    public Task ChatClient_Nebius_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.Nebius);

    [TestMethod]
    public Task ChatClient_Nebius_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.Nebius);

    // --- GitHub Models ---

    [TestMethod]
    public Task ChatClient_GitHub_GetResponse() =>
        ChatClient_CustomProvider_GetResponseAsync(CustomProvider.GitHub);

    [TestMethod]
    public Task ChatClient_GitHub_Streaming() =>
        ChatClient_CustomProvider_StreamingAsync(CustomProvider.GitHub);
}
