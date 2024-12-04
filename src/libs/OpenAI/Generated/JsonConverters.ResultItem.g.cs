#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ResultItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.ResultItem>
    {
        /// <inheritdoc />
        public override global::OpenAI.ResultItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageTimeBucketResultItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageTimeBucketResultItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.UsageTimeBucketResultItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.UsageCompletionsResult? organizationUsageCompletionsResult = default;
            if (discriminator?.Object == global::OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageCompletionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageCompletionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageCompletionsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.UsageCompletionsResult)}");
                organizationUsageCompletionsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.UsageEmbeddingsResult? organizationUsageEmbeddingsResult = default;
            if (discriminator?.Object == global::OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageEmbeddingsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageEmbeddingsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageEmbeddingsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.UsageEmbeddingsResult)}");
                organizationUsageEmbeddingsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.UsageModerationsResult? organizationUsageModerationsResult = default;
            if (discriminator?.Object == global::OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageModerationsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageModerationsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageModerationsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.UsageModerationsResult)}");
                organizationUsageModerationsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.UsageImagesResult? organizationUsageImagesResult = default;
            if (discriminator?.Object == global::OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageImagesResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageImagesResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageImagesResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.UsageImagesResult)}");
                organizationUsageImagesResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.UsageAudioSpeechesResult? organizationUsageAudioSpeechesResult = default;
            if (discriminator?.Object == global::OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageAudioSpeechesResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageAudioSpeechesResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageAudioSpeechesResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.UsageAudioSpeechesResult)}");
                organizationUsageAudioSpeechesResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.UsageAudioTranscriptionsResult? organizationUsageAudioTranscriptionsResult = default;
            if (discriminator?.Object == global::OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageAudioTranscriptionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageAudioTranscriptionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageAudioTranscriptionsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.UsageAudioTranscriptionsResult)}");
                organizationUsageAudioTranscriptionsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.UsageVectorStoresResult? organizationUsageVectorStoresResult = default;
            if (discriminator?.Object == global::OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageVectorStoresResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageVectorStoresResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageVectorStoresResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.UsageVectorStoresResult)}");
                organizationUsageVectorStoresResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.UsageCodeInterpreterSessionsResult? organizationUsageCodeInterpreterSessionsResult = default;
            if (discriminator?.Object == global::OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageCodeInterpreterSessionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageCodeInterpreterSessionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageCodeInterpreterSessionsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.UsageCodeInterpreterSessionsResult)}");
                organizationUsageCodeInterpreterSessionsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.CostsResult? organizationCostsResult = default;
            if (discriminator?.Object == global::OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationCostsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CostsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CostsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CostsResult)}");
                organizationCostsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.ResultItem(
                discriminator?.Object,
                organizationUsageCompletionsResult,
                organizationUsageEmbeddingsResult,
                organizationUsageModerationsResult,
                organizationUsageImagesResult,
                organizationUsageAudioSpeechesResult,
                organizationUsageAudioTranscriptionsResult,
                organizationUsageVectorStoresResult,
                organizationUsageCodeInterpreterSessionsResult,
                organizationCostsResult
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.ResultItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOrganizationUsageCompletionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageCompletionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageCompletionsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.UsageCompletionsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageCompletionsResult, typeInfo);
            }
            else if (value.IsOrganizationUsageEmbeddingsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageEmbeddingsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageEmbeddingsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.UsageEmbeddingsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageEmbeddingsResult, typeInfo);
            }
            else if (value.IsOrganizationUsageModerationsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageModerationsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageModerationsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.UsageModerationsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageModerationsResult, typeInfo);
            }
            else if (value.IsOrganizationUsageImagesResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageImagesResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageImagesResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.UsageImagesResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageImagesResult, typeInfo);
            }
            else if (value.IsOrganizationUsageAudioSpeechesResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageAudioSpeechesResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageAudioSpeechesResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.UsageAudioSpeechesResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageAudioSpeechesResult, typeInfo);
            }
            else if (value.IsOrganizationUsageAudioTranscriptionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageAudioTranscriptionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageAudioTranscriptionsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.UsageAudioTranscriptionsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageAudioTranscriptionsResult, typeInfo);
            }
            else if (value.IsOrganizationUsageVectorStoresResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageVectorStoresResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageVectorStoresResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.UsageVectorStoresResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageVectorStoresResult, typeInfo);
            }
            else if (value.IsOrganizationUsageCodeInterpreterSessionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.UsageCodeInterpreterSessionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.UsageCodeInterpreterSessionsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.UsageCodeInterpreterSessionsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageCodeInterpreterSessionsResult, typeInfo);
            }
            else if (value.IsOrganizationCostsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CostsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CostsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.CostsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationCostsResult, typeInfo);
            }
        }
    }
}