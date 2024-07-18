using System.Diagnostics;

namespace OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateImage_Url()
    {
        var api = GetAuthorizedApi();
        var response = await api.Images.CreateImageAsync(
            prompt: "a white siamese cat",
            n: 1,
            size: CreateImageRequestSize.x256x256,
            responseFormat: CreateImageRequestResponseFormat.Url,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.CreateImage_Url");
        response.Data.ElementAt(0).Url.Should().NotBeNullOrEmpty();

        Process.Start(new ProcessStartInfo(response.Data.ElementAt(0).Url!)
        {
            UseShellExecute = true,
        });
    }
    
    [TestMethod]
    public async Task CreateImage_Base64()
    {
        var api = GetAuthorizedApi();
        var response = await api.Images.CreateImageAsync(
            prompt: "a white siamese cat",
            n: 1,
            size: CreateImageRequestSize.x256x256,
            responseFormat: CreateImageRequestResponseFormat.B64Json,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.CreateImage_Base64");
        var base64 = response.Data.ElementAt(0).B64Json;
        base64.Should().NotBeEmpty();

        var bytes = Convert.FromBase64String(base64!);
        var path = Path.Combine(Path.GetTempPath(), "cat.png");
        await File.WriteAllBytesAsync(path, bytes);
        
        Process.Start(new ProcessStartInfo(path)
        {
            UseShellExecute = true,
        });
    }
}
