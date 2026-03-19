# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The `tryAGI.OpenAI` SDK natively implements [Microsoft.Extensions.AI](https://learn.microsoft.com/dotnet/ai/microsoft-extensions-ai/) interfaces, providing a unified abstraction layer for AI services across .NET applications.

## Supported Interfaces

| Interface | Description |
|-----------|-------------|
| `IChatClient` | Chat completions with text, streaming, tool calling, images, and structured output |
| `IEmbeddingGenerator<string, Embedding<float>>` | Text embeddings with custom dimensions |

## IChatClient

### Basic Chat

```csharp
using OpenAI;
using Microsoft.Extensions.AI;

using var client = new OpenAiClient("API_KEY");
IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    "Say hello!",
    new ChatOptions { ModelId = "gpt-4o-mini" });

Console.WriteLine(response.Messages[0].Text);
```

### Streaming

```csharp
await foreach (var update in chatClient.GetStreamingResponseAsync(
    "Count from 1 to 10.",
    new ChatOptions { ModelId = "gpt-4o-mini" }))
{
    Console.Write(string.Concat(update.Contents.OfType<TextContent>().Select(c => c.Text)));
}
```

### System Messages

```csharp
var messages = new List<ChatMessage>
{
    new(ChatRole.System, "You are a pirate. Always respond with 'Arrr!'."),
    new(ChatRole.User, "Hello!"),
};

var response = await chatClient.GetResponseAsync(
    messages,
    new ChatOptions { ModelId = "gpt-4o-mini" });
```

### Tool Calling

```csharp
var weatherTool = AIFunctionFactory.Create(
    (string city) => city switch
    {
        "Paris" => "22C, sunny",
        "London" => "15C, cloudy",
        _ => "Unknown",
    },
    name: "GetWeather",
    description: "Gets the current weather for a city");

var response = await chatClient.GetResponseAsync(
    "What's the weather in Paris?",
    new ChatOptions
    {
        ModelId = "gpt-4o-mini",
        Tools = [weatherTool],
    });
```

### Structured Output (JSON Schema)

```csharp
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

var response = await chatClient.GetResponseAsync(
    "Return info about Alice who is 30.",
    new ChatOptions
    {
        ModelId = "gpt-4o-mini",
        ResponseFormat = new ChatResponseFormatJson(schema, "person", "A person object"),
    });
```

### Image Content

```csharp
var message = new ChatMessage(ChatRole.User, []);
message.Contents.Add(new TextContent("What is in this image?"));
message.Contents.Add(new UriContent(
    new Uri("https://example.com/photo.png"),
    mediaType: "image/png"));

var response = await chatClient.GetResponseAsync(
    [message],
    new ChatOptions { ModelId = "gpt-4o-mini" });
```

### Temperature, TopP, and Stop Sequences

```csharp
var response = await chatClient.GetResponseAsync(
    "What is 2+2?",
    new ChatOptions
    {
        ModelId = "gpt-4o-mini",
        Temperature = 0f,
        TopP = 1f,
        StopSequences = ["5"],
    });
```

### Additional Properties

Pass provider-specific parameters via `AdditionalProperties`:

```csharp
var options = new ChatOptions
{
    ModelId = "gpt-4o-mini",
    Temperature = 0f,
};
options.AdditionalProperties ??= new AdditionalPropertiesDictionary();
options.AdditionalProperties["seed"] = 42;

var response = await chatClient.GetResponseAsync(messages, options);
```

## IEmbeddingGenerator

### Basic Embeddings

```csharp
using OpenAI;
using Microsoft.Extensions.AI;

using var client = new OpenAiClient("API_KEY");
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var result = await generator.GenerateAsync(
    ["Hello, world!"],
    new EmbeddingGenerationOptions { ModelId = "text-embedding-3-small" });

Console.WriteLine($"Dimensions: {result[0].Vector.Length}");
```

### Batch Embeddings

```csharp
var result = await generator.GenerateAsync(
    ["Hello", "How are you?", "Goodbye"],
    new EmbeddingGenerationOptions { ModelId = "text-embedding-3-small" });

Console.WriteLine($"Generated {result.Count} embeddings");
```

### Custom Dimensions

```csharp
var result = await generator.GenerateAsync(
    ["Hello, world!"],
    new EmbeddingGenerationOptions
    {
        ModelId = "text-embedding-3-small",
        Dimensions = 256,
    });

Console.WriteLine($"Dimensions: {result[0].Vector.Length}"); // 256
```

## Custom Providers

All 15+ custom providers support the same MEAI interfaces:

```csharp
using OpenAI;
using Microsoft.Extensions.AI;

// Any CustomProvider works as IChatClient and IEmbeddingGenerator
using var client = CustomProviders.Groq("API_KEY");
// or: CustomProviders.DeepInfra("API_KEY")
// or: CustomProviders.Together("API_KEY")
// or: CustomProviders.Azure("API_KEY", "ENDPOINT")
// or: CustomProviders.DeepSeek("API_KEY")
// or: any other CustomProvider

IChatClient chatClient = client;
var response = await chatClient.GetResponseAsync(
    "Hello!",
    new ChatOptions { ModelId = "llama-3.3-70b-versatile" });
```
