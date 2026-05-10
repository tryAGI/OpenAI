#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class CreateTranscriptionResponseDiarizedJsonUsageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.TranscriptTextUsageTokens? tokens = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType.Tokens)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokens), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextUsageTokens> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.TranscriptTextUsageTokens)}");
                tokens = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.TranscriptTextUsageDuration? duration = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType.Duration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextUsageDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextUsageDuration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.TranscriptTextUsageDuration)}");
                duration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage(
                discriminator?.Type,
                tokens,

                duration
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTokens)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokens), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextUsageTokens?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokens).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tokens!, typeInfo);
            }
            else if (value.IsDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextUsageDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextUsageDuration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextUsageDuration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Duration!, typeInfo);
            }
        }
    }
}