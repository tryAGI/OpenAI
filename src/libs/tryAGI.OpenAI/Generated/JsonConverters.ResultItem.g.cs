#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ResultItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ResultItem>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ResultItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.UsageCompletionsResult? organizationUsageCompletionsResult = default;
            if (discriminator?.Object == global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageCompletionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageCompletionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageCompletionsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.UsageCompletionsResult)}");
                organizationUsageCompletionsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.UsageEmbeddingsResult? organizationUsageEmbeddingsResult = default;
            if (discriminator?.Object == global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageEmbeddingsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageEmbeddingsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageEmbeddingsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.UsageEmbeddingsResult)}");
                organizationUsageEmbeddingsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.UsageModerationsResult? organizationUsageModerationsResult = default;
            if (discriminator?.Object == global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageModerationsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageModerationsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageModerationsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.UsageModerationsResult)}");
                organizationUsageModerationsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.UsageImagesResult? organizationUsageImagesResult = default;
            if (discriminator?.Object == global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageImagesResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageImagesResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageImagesResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.UsageImagesResult)}");
                organizationUsageImagesResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.UsageAudioSpeechesResult? organizationUsageAudioSpeechesResult = default;
            if (discriminator?.Object == global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageAudioSpeechesResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageAudioSpeechesResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.UsageAudioSpeechesResult)}");
                organizationUsageAudioSpeechesResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? organizationUsageAudioTranscriptionsResult = default;
            if (discriminator?.Object == global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageAudioTranscriptionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageAudioTranscriptionsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult)}");
                organizationUsageAudioTranscriptionsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.UsageVectorStoresResult? organizationUsageVectorStoresResult = default;
            if (discriminator?.Object == global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageVectorStoresResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageVectorStoresResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageVectorStoresResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.UsageVectorStoresResult)}");
                organizationUsageVectorStoresResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? organizationUsageCodeInterpreterSessionsResult = default;
            if (discriminator?.Object == global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationUsageCodeInterpreterSessionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult)}");
                organizationUsageCodeInterpreterSessionsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.CostsResult? organizationCostsResult = default;
            if (discriminator?.Object == global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminatorObject.OrganizationCostsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CostsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CostsResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CostsResult)}");
                organizationCostsResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::tryAGI.OpenAI.ResultItem(
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
            global::tryAGI.OpenAI.ResultItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOrganizationUsageCompletionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageCompletionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageCompletionsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UsageCompletionsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageCompletionsResult, typeInfo);
            }
            else if (value.IsOrganizationUsageEmbeddingsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageEmbeddingsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageEmbeddingsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UsageEmbeddingsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageEmbeddingsResult, typeInfo);
            }
            else if (value.IsOrganizationUsageModerationsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageModerationsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageModerationsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UsageModerationsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageModerationsResult, typeInfo);
            }
            else if (value.IsOrganizationUsageImagesResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageImagesResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageImagesResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UsageImagesResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageImagesResult, typeInfo);
            }
            else if (value.IsOrganizationUsageAudioSpeechesResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageAudioSpeechesResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageAudioSpeechesResult, typeInfo);
            }
            else if (value.IsOrganizationUsageAudioTranscriptionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageAudioTranscriptionsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageAudioTranscriptionsResult, typeInfo);
            }
            else if (value.IsOrganizationUsageVectorStoresResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageVectorStoresResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageVectorStoresResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UsageVectorStoresResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageVectorStoresResult, typeInfo);
            }
            else if (value.IsOrganizationUsageCodeInterpreterSessionsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationUsageCodeInterpreterSessionsResult, typeInfo);
            }
            else if (value.IsOrganizationCostsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CostsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CostsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CostsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationCostsResult, typeInfo);
            }
        }
    }
}