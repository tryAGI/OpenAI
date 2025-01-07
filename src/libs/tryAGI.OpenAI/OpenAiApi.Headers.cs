using System.Net.Http;

namespace tryAGI.OpenAI;

public partial class OpenAiClient
{
    partial void Initialized(HttpClient client)
    {
        client.DefaultRequestHeaders.Add("OpenAI-Beta", "assistants=v2");
    }
}