using System.Text.Json;
using WireContext = tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContext;
using CoreRequest = tryAGI.OpenAI.RealtimeSessionCreateRequestGA;
using RealtimeRequest = tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGA;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [DataRow("null", 0)]
    [DataRow("\"auto\"", 1)]
    [DataRow("{\"workflow_name\":\"local-regression\"}", 2)]
    public void NullableTracing_PreservesCoreAndRealtimeBranches(string tracing, int expectedVariant)
    {
        var json = "{\"type\":\"realtime\",\"tracing\":" + tracing + "}";
        var core = CoreRequest.FromJson(json, SourceGenerationContext.Default)!;
        var realtime = RealtimeRequest.FromJson(json, WireContext.Default)!;

        (core.Tracing?.IsValue1 == true).Should().Be(expectedVariant == 1);
        (core.Tracing?.IsValue2 == true).Should().Be(expectedVariant == 2);
        (realtime.Tracing?.IsValue1 == true).Should().Be(expectedVariant == 1);
        (realtime.Tracing?.IsValue2 == true).Should().Be(expectedVariant == 2);
        if (expectedVariant == 0)
        {
            core.Tracing.Should().BeNull();
            realtime.Tracing.Should().BeNull();
            return;
        }
        using var coreJson = JsonDocument.Parse(core.ToJson(SourceGenerationContext.Default));
        using var realtimeJson = JsonDocument.Parse(realtime.ToJson(WireContext.Default));
        coreJson.RootElement.GetProperty("tracing").GetRawText().Should().Be(tracing);
        realtimeJson.RootElement.GetProperty("tracing").GetRawText().Should().Be(tracing);
    }

    [TestMethod]
    public void NullableTracing_UnknownStringDoesNotSelectAnObjectAlternative()
    {
        const string json = """{"type":"realtime","tracing":"unexpected"}""";
        var core = CoreRequest.FromJson(json, SourceGenerationContext.Default)!;
        var realtime = RealtimeRequest.FromJson(json, WireContext.Default)!;
        // Existing non-validating converters can yield an empty union. No concrete variant is selected.
        core.Tracing?.IsValue1.Should().BeFalse();
        core.Tracing?.IsValue2.Should().BeFalse();
        realtime.Tracing?.IsValue1.Should().BeFalse();
        realtime.Tracing?.IsValue2.Should().BeFalse();
    }
}
