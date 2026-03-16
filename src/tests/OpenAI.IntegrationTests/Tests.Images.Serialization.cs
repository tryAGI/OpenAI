using System.Net;
using System.Text;
using System.Text.Json;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [DataRow(CreateImageRequestQuality.Medium, "medium")]
    [DataRow(CreateImageRequestQuality.High, "high")]
    [DataRow(CreateImageRequestQuality.Auto, "auto")]
    public async Task CreateImage_SerializesGptImageQualityValues(
        CreateImageRequestQuality quality,
        string expectedWireValue)
    {
        string? capturedBody = null;

        using var httpClient = new HttpClient(new ScriptedHttpMessageHandler(async (request, cancellationToken) =>
        {
            request.Method.Should().Be(HttpMethod.Post);
            request.RequestUri.Should().Be(new Uri("https://api.openai.com/v1/images/generations"));
            request.Headers.Authorization?.Scheme.Should().Be("Bearer");
            request.Headers.Authorization?.Parameter.Should().Be("test-api-key");

            capturedBody = await request.Content!.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(
                    """
                    {
                      "created": 1740000000,
                      "data": [
                        {
                          "b64_json": "iVBORw0KGgo="
                        }
                      ],
                      "quality": "medium",
                      "size": "1024x1024",
                      "output_format": "png"
                    }
                    """,
                    Encoding.UTF8,
                    "application/json")
            };
        }))
        {
            BaseAddress = new Uri(OpenAiClient.DefaultBaseUrl)
        };

        using var api = new OpenAiClient(
            "test-api-key",
            httpClient: httpClient,
            disposeHttpClient: false);

        var response = await api.Images.CreateImageAsync(
            prompt: "Generate a test image",
            model: CreateImageRequestModel.GptImage15,
            n: 1,
            quality: quality,
            size: CreateImageRequestSize.x1024x1024,
            outputFormat: CreateImageRequestOutputFormat.Png);

        capturedBody.Should().NotBeNullOrWhiteSpace();
        var requestJson = JsonDocument.Parse(capturedBody!);
        var root = requestJson.RootElement;

        root.GetProperty("model").GetString().Should().Be("gpt-image-1.5");
        root.GetProperty("quality").GetString().Should().Be(expectedWireValue);
        root.GetProperty("size").GetString().Should().Be("1024x1024");
        root.GetProperty("output_format").GetString().Should().Be("png");
        capturedBody.Should().NotContain("\"standard\"");
        capturedBody.Should().NotContain("\"hd\"");

        response.Data.Should().HaveCount(1);
        response.Data![0].B64Json.Should().Be("iVBORw0KGgo=");
    }

    private sealed class ScriptedHttpMessageHandler(
        Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> handler)
        : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            => handler(request, cancellationToken);
    }
}
