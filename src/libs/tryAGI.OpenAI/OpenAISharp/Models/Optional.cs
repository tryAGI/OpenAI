using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace tryAGI.OpenAI.OpenAISharp;

[JsonConverter(typeof(OptionalJsonConverterFactory))]
public readonly struct Optional<T> : IEquatable<Optional<T>>
{
    public bool HasValue { get; }
    public T? Value { get; }

    public Optional(T? value)
    {
        HasValue = true;
        Value = value;
    }

    public static Optional<T> From(T? value) => new(value);
    public static Optional<T> FromT(T? value) => new(value);

    public static implicit operator Optional<T>(T? value) => new(value);

    public bool Equals(Optional<T> other)
        => HasValue == other.HasValue && EqualityComparer<T?>.Default.Equals(Value, other.Value);

    public override bool Equals(object? obj)
        => obj is Optional<T> other && Equals(other);

    public override int GetHashCode()
        => HashCode.Combine(HasValue, Value);

    public static bool operator ==(Optional<T> left, Optional<T> right)
        => left.Equals(right);

    public static bool operator !=(Optional<T> left, Optional<T> right)
        => !left.Equals(right);
}

internal sealed class OptionalJsonConverterFactory : JsonConverterFactory
{
    private static readonly Dictionary<Type, JsonConverter> Converters = new()
    {
        { typeof(Optional<string?>), new OptionalJsonConverter<string?>() },
        { typeof(Optional<string[]?>), new OptionalJsonConverter<string[]?>() },
        { typeof(Optional<double?>), new OptionalJsonConverter<double?>() },
        { typeof(Optional<int?>), new OptionalJsonConverter<int?>() },
        { typeof(Optional<OpenAIRealtimeInputAudioTranscription?>), new OptionalJsonConverter<OpenAIRealtimeInputAudioTranscription?>() },
        { typeof(Optional<OpenAIRealtimeTurnDetection?>), new OptionalJsonConverter<OpenAIRealtimeTurnDetection?>() },
        { typeof(Optional<OpenAIRealtimeNoiseReduction?>), new OptionalJsonConverter<OpenAIRealtimeNoiseReduction?>() },
        { typeof(Optional<OpenAIRealtimeTool[]?>), new OptionalJsonConverter<OpenAIRealtimeTool[]?>() },
    };

    public override bool CanConvert(Type typeToConvert) => Converters.ContainsKey(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        => Converters[typeToConvert];

    private sealed class OptionalJsonConverter<TValue> : JsonConverter<Optional<TValue>>
    {
        public override Optional<TValue> Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return new Optional<TValue>(default);
            }

            var typeInfo = options.GetTypeInfo(typeof(TValue)) as JsonTypeInfo<TValue>;
            if (typeInfo is null)
            {
                throw new NotSupportedException($"Missing JsonTypeInfo for {typeof(TValue).Name}.");
            }

            var value = JsonSerializer.Deserialize(ref reader, typeInfo);
            return new Optional<TValue>(value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            Optional<TValue> value,
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
