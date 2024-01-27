using OpenAI.Constants;
using OpenAI.Moderations;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateModeration()
    {
        var api = GetAuthorizedApi();
        var response = await api.ModerationsEndpoint.CreateModerationAsync(new ModerationsRequest(
            input: "Hello, world",
            model: ModerationModels.Latest));
        
        response.Results.First().Flagged.Should().BeFalse();
    }
    
    [TestMethod]
    public async Task CreateModeration_Flagged()
    {
        var api = GetAuthorizedApi();
        var response = await api.ModerationsEndpoint.CreateModerationAsync(new ModerationsRequest(
            input: "Fuck you",
            model: ModerationModels.Latest));
        response.Results.First().Flagged.Should().BeTrue();
    }
}
