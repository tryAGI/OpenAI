/*
order: 60
title: Image Generation
slug: image-generation

Generate an image from a text prompt.
*/

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ImageGeneration()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Images.CreateImageAsync(
            prompt: "a white siamese cat",
            model: CreateImageRequestModel.GptImage1Mini,
            n: 1,
            quality: CreateImageRequestQuality.Low,
            size: CreateImageRequestSize.x1024x1024,
            outputFormat: CreateImageRequestOutputFormat.Png);

        var base64 = response.Data?.ElementAt(0).B64Json;

        Console.WriteLine($"Generated image ({base64?.Length} base64 chars)");
    }
}
