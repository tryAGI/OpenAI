/*
order: 90
title: Moderation
slug: moderation

Check text for policy violations using the moderation endpoint.
*/

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Moderation()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Moderations.CreateModerationAsync(
            input: "Hello, world",
            model: CreateModerationRequestModel.OmniModerationLatest);

        Console.WriteLine($"Flagged: {response.Results.First().Flagged}");
    }
}
