namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListModels()
    {
        var api = GetAuthorizedApi();
        var models = await api.ModelsEndpoint.GetModelsAsync();
        models.Should().NotBeEmpty();

        foreach (var model in models)
        {
            Console.WriteLine($"{model.Id}");
        }
    }
}
