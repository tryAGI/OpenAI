namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [DataRow(CustomProvider.OpenAi)]
    //[DataRow(CustomProvider.Fireworks)]
    [DataRow(CustomProvider.DeepInfra)]
    [DataRow(CustomProvider.DeepSeek)]
    //[DataRow(CustomProvider.OpenRouter)]
    [DataRow(CustomProvider.Together)]
    [DataRow(CustomProvider.GitHub)]
    //[DataRow(CustomProvider.Perplexity)]
    [DataRow(CustomProvider.SambaNova)]
    [DataRow(CustomProvider.Ollama)]
    [DataRow(CustomProvider.LmStudio)]
    [DataRow(CustomProvider.Groq)]
    [DataRow(CustomProvider.XAi)]
    [DataRow(CustomProvider.Mistral)]
    [DataRow(CustomProvider.Codestral)]
    [DataRow(CustomProvider.Hyperbolic)]
    public async Task GenerateFiveRandomWords(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider);
        using var api = pair.Api;
        
        string response = await api.Chat.CreateChatCompletionAsync(
            new CreateChatCompletionRequest
            {
                Value2 = new CreateChatCompletionRequestVariant2
                {
                    Messages = ["Generate five random words."],
                    Model = pair.Model,
                }
            });
        response.Should().NotBeEmpty();

        Console.WriteLine(response);
    }
    
    [TestMethod]
    [DataRow(CustomProvider.OpenAi)]
    //[DataRow(CustomProvider.Fireworks)]
    [DataRow(CustomProvider.DeepInfra)]
    [DataRow(CustomProvider.DeepSeek)]
    //[DataRow(CustomProvider.OpenRouter)]
    [DataRow(CustomProvider.Together)]
    [DataRow(CustomProvider.GitHub)]
    [DataRow(CustomProvider.SambaNova)]
    [DataRow(CustomProvider.Ollama)]
    [DataRow(CustomProvider.LmStudio)]
    [DataRow(CustomProvider.Groq)]
    //[DataRow(CustomProvider.XAi)]
    [DataRow(CustomProvider.Mistral)]
    //[DataRow(CustomProvider.Codestral)]
    [DataRow(CustomProvider.Hyperbolic)]
    public async Task GenerateFiveRandomWordsAsStream(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider);
        using var api = pair.Api;
        
        var enumerable = api.Chat.CreateChatCompletionAsStreamAsync(
            new CreateChatCompletionRequest
            {
                Value2 = new CreateChatCompletionRequestVariant2
                {
                    Messages = ["Generate five random words."],
                    Model = pair.Model,
                }
            });
        
        await foreach (string response in enumerable)
        {
            Console.WriteLine(response);
        }
    }
    
    [TestMethod]
    [DataRow(CustomProvider.OpenAi)]
    //[DataRow(CustomProvider.Fireworks)]
    [DataRow(CustomProvider.DeepInfra)]
    [DataRow(CustomProvider.DeepSeek)]
    //[DataRow(CustomProvider.OpenRouter)]
    //[DataRow(CustomProvider.Together)]
    [DataRow(CustomProvider.GitHub)]
    [DataRow(CustomProvider.Ollama)]
    [DataRow(CustomProvider.LmStudio)]
    [DataRow(CustomProvider.Groq)]
    //[DataRow(CustomProvider.XAi)]
    [DataRow(CustomProvider.Hyperbolic)]
    public async Task GenerateFiveRandomWordsAsJsonObject(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider);
        using var api = pair.Api;
        
        string response = await api.Chat.CreateChatCompletionAsync(
            new CreateChatCompletionRequest
            {
                Value2 = new CreateChatCompletionRequestVariant2
                {
                    Messages = ["Generate five random words as json."],
                    Model = pair.Model,
                    ResponseFormat = new ResponseFormatJsonObject
                    {
                        Type = ResponseFormatJsonObjectType.JsonObject,
                    },
                }
            });
            // messages: ["Generate five random words as json."],
            // model: pair.Model,
            // responseFormat: new ResponseFormatJsonObject
            // {
            //     Type = ResponseFormatJsonObjectType.JsonObject,
            // },
            // user: "tryAGI.OpenAI.IntegrationTests.Tests.GenerateSomeJson");
        response.Should().NotBeEmpty();

        Console.WriteLine(response);
    }
    
    [TestMethod]
    [DataRow(CustomProvider.OpenAi)]
    [DataRow(CustomProvider.Ollama)]
    [DataRow(CustomProvider.Groq)]
    //[DataRow(CustomProvider.XAi)]
    //[DataRow(CustomProvider.Together)]
    //[DataRow(CustomProvider.Hyperbolic)]
    public async Task ChatWithVision(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider, model: customProvider switch
        {
            CustomProvider.Together => "meta-llama/Llama-Vision-Free",
            CustomProvider.Groq => Environment.GetEnvironmentVariable("GROQ_VISION_MODEL") ??
                                   "meta-llama/llama-4-scout-17b-16e-instruct",
            _ => null,
        });
        using var api = pair.Api;
        
        CreateChatCompletionResponse response = await api.Chat.CreateChatCompletionAsync(
            new CreateChatCompletionRequest
            {
                Value2 = new CreateChatCompletionRequestVariant2
                {
                    Messages = [
                        "Please describe the following image.",
                        H.Resources.images_dog_and_cat_png.AsBytes().AsUserMessage(mimeType: "image/png"),
                    ],
                    Model = pair.Model,
                }
            });
            // messages: [
            //     "Please describe the following image.",
            //     H.Resources.images_dog_and_cat_png.AsBytes().AsUserMessage(mimeType: "image/png"),
            // ],
            // model: pair.Model);

        Console.WriteLine("[ASSISTANT]:");
        Console.WriteLine($"{response.Choices[0].Message.Content}");
    }
}
