namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateModeration()
    {
        var api = GetAuthorizedApi();
        var response = await api.CreateModerationAsync(new CreateModerationRequest
        {
            Input = "Hello, world",
            Model = ModerationModelIds.Latest,
        });
        response.Results.First().Flagged.Should().BeFalse();
    }
    
    [TestMethod]
    public async Task CreateModeration_Flagged()
    {
        var api = GetAuthorizedApi();
        var response = await api.CreateModerationAsync(new CreateModerationRequest
        {
            Input = "Fuck you",
            Model = ModerationModelIds.Latest,
        });
        response.Results.First().Flagged.Should().BeTrue();
    }
}
