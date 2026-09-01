using System.Net;

namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public sealed class Tests_Images_Bytes
{
    [TestMethod]
    public async Task GetBytesAsync_DecodesInlineBase64WithoutHttp()
    {
        var expected = new byte[] { 1, 2, 3, 4 };
        var image = new Image2 { B64Json = Convert.ToBase64String(expected) };

        var actual = await image.GetBytesAsync();

        actual.Should().Equal(expected);
    }

    [TestMethod]
    public async Task GetBytesAsync_DownloadsUrlWithCallerHttpClient()
    {
        var expected = new byte[] { 5, 6, 7, 8 };
        using var httpClient = new HttpClient(new StubHandler(request =>
        {
            request.RequestUri.Should().Be(new Uri("https://images.example.test/result.png"));
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(expected),
            };
        }));
        var image = new Image2 { Url = "https://images.example.test/result.png" };

        var actual = await image.GetBytesAsync(httpClient);

        actual.Should().Equal(expected);
    }

    private sealed class StubHandler(Func<HttpRequestMessage, HttpResponseMessage> handler) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken) => Task.FromResult(handler(request));
    }
}
