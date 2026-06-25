using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace tryAGI.OpenAI.OpenAISharp;

/// <inheritdoc />
[JsonConverter(typeof(OpenAIOptionalJsonConverterFactory))]
public readonly struct OpenAIOptional<T> : IEquatable<OpenAIOptional<T>>
{
    /// <inheritdoc />
    public bool HasValue { get; }
    /// <inheritdoc />
    public T? Value { get; }

    /// <inheritdoc />
    public OpenAIOptional(T? value)
    {
        HasValue = true;
        Value = value;
    }

    /// <inheritdoc />
    public bool Equals(OpenAIOptional<T> other)
        => HasValue == other.HasValue && EqualityComparer<T?>.Default.Equals(Value, other.Value);

    /// <inheritdoc />
    public override bool Equals(object? obj)
        => obj is OpenAIOptional<T> other && Equals(other);

    /// <inheritdoc />
    public override int GetHashCode()
        => HashCode.Combine(HasValue, Value);

    /// <inheritdoc />
    public static bool operator ==(OpenAIOptional<T> left, OpenAIOptional<T> right)
        => left.Equals(right);

    /// <inheritdoc />
    public static bool operator !=(OpenAIOptional<T> left, OpenAIOptional<T> right)
        => !left.Equals(right);
}

/// <inheritdoc />
public static class OpenAIOptional
{
    /// <inheritdoc />
    public static OpenAIOptional<T> From<T>(T? value) => new(value);
}

internal sealed class OpenAIOptionalJsonConverterFactory : JsonConverterFactory
{
    private static readonly Dictionary<Type, JsonConverter> Converters = new()
    {
        { typeof(OpenAIOptional<string?>), new OpenAIOptionalJsonConverter<string?>() },
        { typeof(OpenAIOptional<string[]?>), new OpenAIOptionalJsonConverter<string[]?>() },
        { typeof(OpenAIOptional<double?>), new OpenAIOptionalJsonConverter<double?>() },
        { typeof(OpenAIOptional<int?>), new OpenAIOptionalJsonConverter<int?>() },
        { typeof(OpenAIOptional<OpenAIRealtimeInputAudioTranscription?>), new OpenAIOptionalJsonConverter<OpenAIRealtimeInputAudioTranscription?>() },
        { typeof(OpenAIOptional<OpenAIRealtimeTurnDetection?>), new OpenAIOptionalJsonConverter<OpenAIRealtimeTurnDetection?>() },
        { typeof(OpenAIOptional<OpenAIRealtimeNoiseReduction?>), new OpenAIOptionalJsonConverter<OpenAIRealtimeNoiseReduction?>() },
        { typeof(OpenAIOptional<OpenAIRealtimeTool[]?>), new OpenAIOptionalJsonConverter<OpenAIRealtimeTool[]?>() },
    };

    /// <inheritdoc />
    public override bool CanConvert(Type typeToConvert) => Converters.ContainsKey(typeToConvert);

    /// <inheritdoc />
    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        => Converters[typeToConvert];

    private sealed class OpenAIOptionalJsonConverter<TValue> : JsonConverter<OpenAIOptional<TValue>>
    {
        /// <inheritdoc />
        public override OpenAIOptional<TValue> Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return new OpenAIOptional<TValue>(default);
            }

            var typeInfo = options.GetTypeInfo(typeof(TValue)) as JsonTypeInfo<TValue>;
            if (typeInfo is null)
            {
                throw new NotSupportedException($"Missing JsonTypeInfo for {typeof(TValue).Name}.");
            }

            var value = JsonSerializer.Deserialize(ref reader, typeInfo);
            return new OpenAIOptional<TValue>(value);
        }

        /// <inheritdoc />
        public override void Write(
            Utf8JsonWriter writer,
            OpenAIOptional<TValue> value,
            JsonSerializerOptions options)
        {
            if (!value.HasValue || value.Value is null)
            {
                writer.WriteNullValue();
                return;
            }

            var typeInfo = options.GetTypeInfo(typeof(TValue)) as JsonTypeInfo<TValue>;
            if (typeInfo is null)
            {
                throw new NotSupportedException($"Missing JsonTypeInfo for {typeof(TValue).Name}.");
            }

            JsonSerializer.Serialize(writer, value.Value, typeInfo);
        }
    }
}
