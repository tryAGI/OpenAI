#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class PromptCacheDiagnosticsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.PromptCacheDiagnostics>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.PromptCacheDiagnostics Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody? cacheMiss = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType.CacheMiss)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody)}");
                cacheMiss = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody? cacheHit = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType.CacheHit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody)}");
                cacheHit = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody? comparisonResponseNotFound = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType.ComparisonResponseNotFound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody)}");
                comparisonResponseNotFound = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody? unavailable = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType.Unavailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody)}");
                unavailable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.PromptCacheDiagnostics(
                discriminator?.Type,
                cacheMiss,

                cacheHit,

                comparisonResponseNotFound,

                unavailable
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.PromptCacheDiagnostics value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCacheMiss)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CacheMiss!, typeInfo);
            }
            else if (value.IsCacheHit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CacheHit!, typeInfo);
            }
            else if (value.IsComparisonResponseNotFound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComparisonResponseNotFound!, typeInfo);
            }
            else if (value.IsUnavailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unavailable!, typeInfo);
            }
        }
    }
}