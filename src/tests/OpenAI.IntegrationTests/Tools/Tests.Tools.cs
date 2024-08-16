namespace OpenAI.IntegrationTests;

public partial class Tests
{
    [DataTestMethod]
    [DataRow(CustomProvider.OpenAi)]
    // [DataRow(CustomProvider.GitHub)]
    // [DataRow(CustomProvider.Fireworks)]
    // [DataRow(CustomProvider.DeepInfra)]
    // [DataRow(CustomProvider.DeepSeek)]
    // [DataRow(CustomProvider.OpenRouter)]
    // [DataRow(CustomProvider.Together)]
    public async Task WeatherTools(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider, CreateChatCompletionRequestModel.Gpt4o20240806.ToValueString());
        using var api = pair.Api;
        
        var messages = new List<ChatCompletionRequestMessage>
        {
            "You are a helpful weather assistant.".AsSystemMessage(),
            "What is the current temperature in Dubai, UAE in Celsius?".AsUserMessage(),
        };

        try
        {
            var service = new WeatherService();
            var tools = service.AsTools();
            var result = await api.Chat.CreateChatCompletionAsync(
                messages,
                model: pair.Model,
                tools: tools);
            var resultMessage = result.Choices.First().Message;
            messages.Add(resultMessage.AsRequestMessage());

            if (resultMessage.ToolCalls == null ||
                resultMessage.ToolCalls.Count == 0)
            {
                throw new InvalidOperationException("Expected a function call.");
            }

            foreach (var call in resultMessage.ToolCalls)
            {
                var json = await service.CallAsync(
                    functionName: call.Function.Name,
                    argumentsAsJson: call.Function.Arguments);
                messages.Add(json.AsToolMessage(call.Id));
            }

            result = await api.Chat.CreateChatCompletionAsync(
                messages,
                model: pair.Model,
                tools: tools);
            resultMessage = result.Choices.First().Message;
            messages.Add(resultMessage.AsRequestMessage());
        }
        finally
        {
            PrintMessages(messages);
        }
    }

    private static void PrintMessages(List<ChatCompletionRequestMessage> messages)
    {
        foreach (var message in messages)
        {
            if (message.IsTool)
            {
                Console.WriteLine($"> {message.Tool.Role}({message.Tool.ToolCallId}):");
                Console.WriteLine($"{message.Tool.Content.Value1}");
            }
            else if (message.IsSystem)
            {
                Console.WriteLine($"> {message.System.Role}: {message.System.Name}");
                Console.WriteLine($"{message.System.Content.Value1}");
            }
            else if (message.IsUser)
            {
                Console.WriteLine($"> {message.User.Role}: {message.User.Name}");
                Console.WriteLine($"{message.User.Content.Object}");
            }
            else if (message.IsAssistant)
            {
                Console.WriteLine($"> {message.Assistant.Role}: {message.Assistant.Name}");
                foreach (var call in message.Assistant.ToolCalls ?? Enumerable.Empty<ChatCompletionMessageToolCall>())
                {
                    Console.WriteLine($"{call.Id}:");
                    Console.WriteLine($"{call.Function.Name}({call.Function.Arguments})");
                }
                if (!string.IsNullOrWhiteSpace(message.Assistant.Content))
                {
                    Console.WriteLine($"{message.Assistant.Content.Value.Value1}");
                }
            }
        }
    }

    [TestMethod]
    public async Task Call()
    {
        var json = /* lang=json */ """
                                   {
                                       "location": "Dubai, UAE"
                                   }
                                   """;
        var result = new WeatherService().CallGetCurrentWeather(json);

        result.Should().Be( /* lang=json */ """
                                            {"location":"Dubai, UAE","temperature":22,"unit":"celsius","description":"Sunny"}
                                            """);

        var result2 = await new WeatherService().CallAsync("GetCurrentWeather", json);
        result2.Should().Be( /* lang=json */ """
                                             {"location":"Dubai, UAE","temperature":22,"unit":"celsius","description":"Sunny"}
                                             """);
    }
}