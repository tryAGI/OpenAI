using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenAI.SnapshotTests;

[TestClass]
public class UnitTests : VerifyBase
{
    [DataTestMethod]
    [DataRow(typeof(WordsResponse))]
    [DataRow(typeof(Weather))]
    public async Task TypeAsJsonSchema(Type type)
    {
        var strictSchema = TypeToSchemaHelpers.AsResponseFormat(type, strict: true);
        var nonStrictSchema = TypeToSchemaHelpers.AsResponseFormat(type, strict: false);

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };
        var strictJson = JsonSerializer.Serialize(strictSchema, options);
        var nonStrictJson = JsonSerializer.Serialize(nonStrictSchema, options);
        
        var typeInfo = SourceGeneratedContext.Default.GetTypeInfo(type);
        typeInfo.Should().NotBeNull();
        var strictSchemaTrimmable = TypeToSchemaHelpers.AsResponseFormat(type, strict: true);
        var nonStrictSchemaTrimmable = TypeToSchemaHelpers.AsResponseFormat(type, strict: false);
        var strictJsonTrimmable = JsonSerializer.Serialize(strictSchemaTrimmable, SourceGeneratedContext.Default.ResponseFormatJsonSchemaJsonSchema);
        var nonStrictJsonTrimmable = JsonSerializer.Serialize(nonStrictSchemaTrimmable, SourceGeneratedContext.Default.ResponseFormatJsonSchemaJsonSchema);

        strictJson.Should().Be(strictJsonTrimmable);
        nonStrictJson.Should().Be(nonStrictJsonTrimmable);
        
        await Task.WhenAll(
            Verify(strictJson)
                .UseDirectory($"Snapshots/Schemas/{type.Name}")
                .UseTextForParameters("Strict_Type"),
            Verify(nonStrictJson)
                .UseDirectory($"Snapshots/Schemas/{type.Name}")
                .UseTextForParameters("NonStrict_Type"),
            Verify(strictJsonTrimmable)
                .UseDirectory($"Snapshots/Schemas/{type.Name}")
                .UseTextForParameters("Strict_JsonTypeInfo"),
            Verify(nonStrictJsonTrimmable)
                .UseDirectory($"Snapshots/Schemas/{type.Name}")
                .UseTextForParameters("NonStrict_JsonTypeInfo"));
    }
}

public class WordsResponse
{
    //[JsonPropertyName("words")]
    public string[] Words { get; set; } = [];
}

[JsonSourceGenerationOptions(
    WriteIndented = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    Converters = [typeof(JsonStringEnumConverter<Unit>)])]
[JsonSerializable(typeof(WordsResponse))]
[JsonSerializable(typeof(Weather))]
[JsonSerializable(typeof(ResponseFormatJsonSchemaJsonSchema))]
public partial class SourceGeneratedContext : JsonSerializerContext;


public enum Unit
{
    Celsius,
    Fahrenheit,
}

public class Weather
{
    public string Location { get; set; } = string.Empty;
    public double Temperature { get; set; }
    public Unit Unit { get; set; }
    public string Description { get; set; } = string.Empty;
}