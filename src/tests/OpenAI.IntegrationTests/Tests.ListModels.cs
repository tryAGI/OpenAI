namespace OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListModels()
    {
        var api = GetAuthorizedApi();
        var models = await api.Models.ListModelsAsync();
        models.Data.Should().NotBeEmpty();

        foreach (var model in models.Data)
        {
            Console.WriteLine($"{model.Id}");
        }
    }
}
