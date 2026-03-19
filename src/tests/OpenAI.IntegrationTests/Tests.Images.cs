using System.Diagnostics;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateImage_Png()
    {
        var api = GetAuthorizedApi();
        var response = await api.Images.CreateImageAsync(
            prompt: "a white siamese cat",
            model: CreateImageRequestModel.GptImage1Mini,
            n: 1,
            quality: CreateImageRequestQuality.Low,
            size: CreateImageRequestSize.x1024x1024,
            outputFormat: CreateImageRequestOutputFormat.Png,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.CreateImage_Png");
        var base64 = response.Data?.ElementAt(0).B64Json;
        base64.Should().NotBeEmpty();
        response.OutputFormat.Should().Be(ImagesResponseOutputFormat.Png);

        var bytes = Convert.FromBase64String(base64);
        var path = Path.Combine(Path.GetTempPath(), "cat.png");
        await File.WriteAllBytesAsync(path, bytes);

        Process.Start(new ProcessStartInfo(path)
        {
            UseShellExecute = true,
        });
    }
    
    [TestMethod]
    public async Task CreateImage_Jpeg()
    {
        var api = GetAuthorizedApi();
        var response = await api.Images.CreateImageAsync(
            prompt: "a white siamese cat",
            model: CreateImageRequestModel.GptImage1Mini,
            n: 1,
            quality: CreateImageRequestQuality.Low,
            size: CreateImageRequestSize.x1024x1024,
            outputFormat: CreateImageRequestOutputFormat.Jpeg,
            outputCompression: 80,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.CreateImage_Jpeg");
        var base64 = response.Data?.ElementAt(0).B64Json;
        base64.Should().NotBeEmpty();
        response.OutputFormat.Should().Be(ImagesResponseOutputFormat.Jpeg);

        var bytes = Convert.FromBase64String(base64);
        var path = Path.Combine(Path.GetTempPath(), "cat.jpg");
        await File.WriteAllBytesAsync(path, bytes);
        
        Process.Start(new ProcessStartInfo(path)
        {
            UseShellExecute = true,
        });
    }
}
