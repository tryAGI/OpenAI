/*
order: 80
title: List Models
slug: list-models

List all available models.
*/

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListModels()
    {
        using var client = GetAuthenticatedClient();

        var models = await client.Models.ListModelsAsync();

        foreach (var model in models.Data)
        {
            Console.WriteLine(model.Id);
        }
    }
}
