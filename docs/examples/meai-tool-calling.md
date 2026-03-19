# MEAI Tool Calling

Use function/tool calling via the Microsoft.Extensions.AI IChatClient interface.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

// using Meai = Microsoft.Extensions.AI;
Meai.IChatClient chatClient = client;

var tool = Meai.AIFunctionFactory.Create(
    (string city) => city switch
    {
        "Paris" => "22C, sunny",
        "London" => "15C, cloudy",
        _ => "Unknown",
    },
    name: "GetWeather",
    description: "Gets the current weather for a city");

var chatOptions = new Meai.ChatOptions
{
    ModelId = "gpt-4o-mini",
    Tools = [tool],
};

var messages = new List<Meai.ChatMessage>
{
    new(Meai.ChatRole.User, "What's the weather in Paris? Respond with the temperature only."),
};

// First turn: get tool call
var response = await chatClient.GetResponseAsync(
    (IEnumerable<Meai.ChatMessage>)messages, chatOptions);

var functionCall = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<Meai.FunctionCallContent>()
    .First();

// Execute tool and add result
var toolResult = await tool.InvokeAsync(
    functionCall.Arguments is { } args
        ? new Meai.AIFunctionArguments(args)
        : null);
messages.AddRange(response.Messages);
messages.Add(new Meai.ChatMessage(Meai.ChatRole.Tool,
    new Meai.AIContent[]
    {
        new Meai.FunctionResultContent(functionCall.CallId, toolResult),
    }));

// Second turn: get final response
var finalResponse = await chatClient.GetResponseAsync(
    (IEnumerable<Meai.ChatMessage>)messages, chatOptions);

Console.WriteLine(finalResponse.Messages[0].Text);
```