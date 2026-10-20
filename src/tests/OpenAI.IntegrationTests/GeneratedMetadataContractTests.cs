using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace OpenAI.IntegrationTests;

[TestClass]
public sealed class GeneratedMetadataContractTests
{
    [TestMethod]
    public void AllGeneratedClrTypesLoad()
    {
        Assert.IsTrue(typeof(global::tryAGI.OpenAI.OpenAiClient).Assembly.GetTypes().Length > 1000);
    }

    [TestMethod]
    public void ChatRequestMetadataRoundTripPreservesFalseAndMessageContent()
    {
        var request = global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2.FromJson(
            """{"model":"gpt-4.1-mini","messages":[{"role":"user","content":"offline audit"}],"stream":false}""")
            ?? throw new InvalidOperationException("Request JSON did not deserialize.");
        using var document = JsonDocument.Parse(request.ToJson());
        Assert.IsFalse(document.RootElement.GetProperty("stream").GetBoolean());
        Assert.AreEqual("offline audit", document.RootElement.GetProperty("messages")[0].GetProperty("content").GetString());
    }
}
