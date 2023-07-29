using System.Diagnostics;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateImage_Url()
    {
        var api = GetAuthorizedApi();
        var response = await api.CreateImageAsync(new CreateImageRequest
        {
            Prompt = "a white siamese cat",
            N = 1,
            Size = CreateImageRequestSize._256x256,
            Response_format = CreateImageRequestResponse_format.Url,
            User = "tryAGI.OpenAI.IntegrationTests.Tests.CreateImage_Url",
        });
        response.Data.ElementAt(0).Url.Should().NotBeEmpty();

        Process.Start(new ProcessStartInfo(response.Data.ElementAt(0).Url!)
        {
            UseShellExecute = true,
        });
    }
    
    [TestMethod]
    public async Task CreateImage_Base64()
    {
        var api = GetAuthorizedApi();
        var response = await api.CreateImageAsync(new CreateImageRequest
        {
            Prompt = "a white siamese cat",
            N = 1,
            Size = CreateImageRequestSize._256x256,
            Response_format = CreateImageRequestResponse_format.B64_json,
            User = "tryAGI.OpenAI.IntegrationTests.Tests.CreateImage_Base64",
        });
        var base64 = response.Data.ElementAt(0).B64_json;
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
