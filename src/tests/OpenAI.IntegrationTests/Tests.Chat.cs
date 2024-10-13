namespace OpenAI.IntegrationTests;

public partial class Tests
{
    [DataTestMethod]
    [DataRow(CustomProvider.OpenAi)]
    [DataRow(CustomProvider.Fireworks)]
    [DataRow(CustomProvider.DeepInfra)]
    [DataRow(CustomProvider.DeepSeek)]
    [DataRow(CustomProvider.OpenRouter)]
    [DataRow(CustomProvider.Together)]
    [DataRow(CustomProvider.GitHub)]
    [DataRow(CustomProvider.Perplexity)]
    [DataRow(CustomProvider.SambaNova)]
    [DataRow(CustomProvider.Ollama)]
    [DataRow(CustomProvider.LmStudio)]
    [DataRow(CustomProvider.Groq)]
    [DataRow(CustomProvider.Mistral)]
    [DataRow(CustomProvider.Codestral)]
    [DataRow(CustomProvider.Hyperbolic)]
    public async Task GenerateFiveRandomWords(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider);
        using var api = pair.Api;
        
        string response = await api.Chat.CreateChatCompletionAsync(
            messages: ["Generate five random words."],
            model: pair.Model,
            user: customProvider switch
            {
                CustomProvider.Mistral or CustomProvider.Codestral => null,
                _ => "tryAGI.OpenAI.Tests.GenerateFiveRandomWords",
            },
            frequencyPenalty: customProvider switch
            {
                CustomProvider.Perplexity => 0.5,
                _ => null,
            },
            presencePenalty: null,
            logprobs: null);
        response.Should().NotBeEmpty();

        Console.WriteLine(response);
    }
    
    [DataTestMethod]
    [DataRow(CustomProvider.OpenAi)]
    [DataRow(CustomProvider.Fireworks)]
    [DataRow(CustomProvider.DeepInfra)]
    [DataRow(CustomProvider.DeepSeek)]
    [DataRow(CustomProvider.OpenRouter)]
    [DataRow(CustomProvider.Together)]
    [DataRow(CustomProvider.GitHub)]
    [DataRow(CustomProvider.SambaNova)]
    [DataRow(CustomProvider.Ollama)]
    [DataRow(CustomProvider.LmStudio)]
    [DataRow(CustomProvider.Groq)]
    [DataRow(CustomProvider.Mistral)]
    //[DataRow(CustomProvider.Codestral)]
    [DataRow(CustomProvider.Hyperbolic)]
    public async Task GenerateFiveRandomWordsAsStream(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider);
        using var api = pair.Api;
        
        var enumerable = api.Chat.CreateChatCompletionAsStreamAsync(
            messages: ["Generate five random words."],
            model: pair.Model,
            presencePenalty: null,
            user: customProvider switch
            {
                CustomProvider.Mistral or CustomProvider.Codestral => null,
                _ => "tryAGI.OpenAI.Tests.GenerateFiveRandomWordsAsStream",
            });
        
        await foreach (string response in enumerable)
        {
            Console.WriteLine(response);
        }
    }
    
    [DataTestMethod]
    [DataRow(CustomProvider.OpenAi)]
    [DataRow(CustomProvider.Fireworks)]
    [DataRow(CustomProvider.DeepInfra)]
    [DataRow(CustomProvider.DeepSeek)]
    [DataRow(CustomProvider.OpenRouter)]
    //[DataRow(CustomProvider.Together)]
    [DataRow(CustomProvider.GitHub)]
    [DataRow(CustomProvider.Ollama)]
    [DataRow(CustomProvider.LmStudio)]
    [DataRow(CustomProvider.Groq)]
    [DataRow(CustomProvider.Hyperbolic)]
    public async Task GenerateFiveRandomWordsAsJsonObject(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider);
        using var api = pair.Api;
        
        string response = await api.Chat.CreateChatCompletionAsync(
            messages: ["Generate five random words as json."],
            model: pair.Model,
            responseFormat: new ResponseFormatJsonObject
            {
                Type = ResponseFormatJsonObjectType.JsonObject,
            },
            user: "tryAGI.OpenAI.IntegrationTests.Tests.GenerateSomeJson");
        response.Should().NotBeEmpty();

        Console.WriteLine(response);
    }
    
    [DataTestMethod]
    [DataRow(CustomProvider.OpenAi)]
    [DataRow(CustomProvider.Ollama)]
    [DataRow(CustomProvider.Groq)]
    //[DataRow(CustomProvider.Together)]
    [DataRow(CustomProvider.Hyperbolic)]
    public async Task ChatWithVision(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider, model: customProvider switch
        {
            CustomProvider.Together => "meta-llama/Llama-Vision-Free",
            CustomProvider.Groq => "llama-3.2-11b-vision-preview",
            _ => null,
        });
        using var api = pair.Api;
        
        CreateChatCompletionResponse response = await api.Chat.CreateChatCompletionAsync(
            messages: [
                "Please describe the following image.",
                H.Resources.images_dog_and_cat_png.AsBytes().AsUserMessage(mimeType: "image/png"),
            ],
            model: pair.Model);

        Console.WriteLine("[ASSISTANT]:");
        Console.WriteLine($"{response.Choices[0].Message.Content}");
    }
}
