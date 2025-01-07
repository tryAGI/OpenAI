namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateModeration()
    {
        var api = GetAuthorizedApi();
        var response = await api.Moderations.CreateModerationAsync(
            input: "Hello, world",
            model: CreateModerationRequestModel.OmniModerationLatest);
        
        response.Results.First().Flagged.Should().BeFalse();
    }
    
    [TestMethod]
    public async Task CreateModeration_Flagged()
    {
        var api = GetAuthorizedApi();
        var response = await api.Moderations.CreateModerationAsync(
            input: "Fuck you",
            model: CreateModerationRequestModel.OmniModerationLatest);
        response.Results.First().Flagged.Should().BeTrue();
    }
}
