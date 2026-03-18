using Meai = Microsoft.Extensions.AI;
using Retry = Microsoft.VisualStudio.TestTools.UnitTesting.RetryAttribute;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Retry(2)]
    public async Task ChatClient_ToolCalling_SingleTurn()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var tool = Meai.AIFunctionFactory.Create(
            (string city) => city switch
            {
                "Paris" => "22°C, sunny",
                "London" => "15°C, cloudy",
                _ => "Unknown",
            },
            name: "GetWeather",
            description: "Gets the current weather for a city");

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "What's the weather in Paris?"),
        };

        var response = await chatClient.GetResponseAsync(
            messages,
            new Meai.ChatOptions
            {
                ModelId = "gpt-4o-mini",
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
        Console.WriteLine($"Tool call: {functionCall.Name}({string.Join(", ", functionCall.Arguments?.Select(kv => $"{kv.Key}={kv.Value}") ?? [])})");
    }

    [TestMethod]
    [Retry(2)]
    public async Task ChatClient_ToolCalling_Streaming()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var tool = Meai.AIFunctionFactory.Create(
            (string city) => city switch
            {
                "Paris" => "22°C, sunny",
                "London" => "15°C, cloudy",
                _ => "Unknown",
            },
            name: "GetWeather",
            description: "Gets the current weather for a city");

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "What's the weather in Paris?"),
        };

        var toolCallName = string.Empty;
        Meai.ChatFinishReason? finishReason = null;

        await foreach (var update in chatClient.GetStreamingResponseAsync(
            (IEnumerable<Meai.ChatMessage>)messages,
            new Meai.ChatOptions
            {
                ModelId = "gpt-4o-mini",
                Tools = [tool],
            }))
        {
            foreach (var content in update.Contents.OfType<Meai.FunctionCallContent>())
            {
                if (!string.IsNullOrEmpty(content.Name))
                {
                    toolCallName = content.Name;
                }
            }

            if (update.FinishReason is { } fr)
            {
                finishReason = fr;
            }
        }

        toolCallName.Should().Be("GetWeather");
        finishReason.Should().Be(Meai.ChatFinishReason.ToolCalls);
        Console.WriteLine($"Streaming tool call: {toolCallName}, finish: {finishReason}");
    }

    [TestMethod]
    [Retry(2)]
    public async Task ChatClient_ToolCalling_MultiTurn()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var tool = Meai.AIFunctionFactory.Create(
            (string city) => city switch
            {
                "Paris" => "22°C, sunny",
                "London" => "15°C, cloudy",
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

        // First turn - get tool call
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

        // Second turn - get final response
        var finalResponse = await chatClient.GetResponseAsync(
            (IEnumerable<Meai.ChatMessage>)messages, chatOptions);

        var text = finalResponse.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();
        Console.WriteLine($"Final response: {text}");
    }

    [TestMethod]
    [Retry(2)]
    public async Task ChatClient_ToolCalling_StreamingMultiTurn()
    {
        using var client = GetAuthorizedApi();
        Meai.IChatClient chatClient = client;

        var tool = Meai.AIFunctionFactory.Create(
            (string city) => city switch
            {
                "Paris" => "22°C, sunny",
                "London" => "15°C, cloudy",
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

        // First turn - fully streaming with accumulated tool call arguments
        Meai.FunctionCallContent? functionCall = null;

        await foreach (var update in chatClient.GetStreamingResponseAsync(
            (IEnumerable<Meai.ChatMessage>)messages, chatOptions))
        {
            var fc = update.Contents.OfType<Meai.FunctionCallContent>().FirstOrDefault();
            if (fc is not null)
            {
                functionCall = fc;
            }
        }

        functionCall.Should().NotBeNull();
        functionCall!.Name.Should().Be("GetWeather");
        functionCall.Arguments.Should().NotBeNull();
        Console.WriteLine($"Streaming tool call: {functionCall.Name}({string.Join(", ", functionCall.Arguments?.Select(kv => $"{kv.Key}={kv.Value}") ?? [])})");

        // Execute tool and add result
        var toolResult = await tool.InvokeAsync(
            functionCall.Arguments is { } args
                ? new Meai.AIFunctionArguments(args)
                : null);
        messages.Add(new Meai.ChatMessage(Meai.ChatRole.Assistant,
            new Meai.AIContent[]
            {
                new Meai.FunctionCallContent(functionCall.CallId, functionCall.Name, functionCall.Arguments),
            }));
        messages.Add(new Meai.ChatMessage(Meai.ChatRole.Tool,
            new Meai.AIContent[]
            {
                new Meai.FunctionResultContent(functionCall.CallId, toolResult),
            }));

        // Second turn - streaming to get final text response
        var finalText = new System.Text.StringBuilder();
        await foreach (var update in chatClient.GetStreamingResponseAsync(
            (IEnumerable<Meai.ChatMessage>)messages, chatOptions))
        {
            foreach (var content in update.Contents.OfType<Meai.TextContent>())
            {
                finalText.Append(content.Text);
                Console.Write(content.Text);
            }
        }
        Console.WriteLine();

        var result = finalText.ToString();
        result.Should().NotBeNullOrWhiteSpace();
        Console.WriteLine($"Streaming final response: {result}");
    }
}
