#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class BetaPromptCacheDiagnosticsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.BetaPromptCacheDiagnostics>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.BetaPromptCacheDiagnostics Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody? cacheMiss = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType.CacheMiss)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody)}");
                cacheMiss = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody? cacheHit = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType.CacheHit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody)}");
                cacheHit = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody? comparisonResponseNotFound = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType.ComparisonResponseNotFound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody)}");
                comparisonResponseNotFound = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody? unavailable = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType.Unavailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody)}");
                unavailable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.BetaPromptCacheDiagnostics(
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
            global::tryAGI.OpenAI.BetaPromptCacheDiagnostics value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCacheMiss)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CacheMiss!, typeInfo);
            }
            else if (value.IsCacheHit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CacheHit!, typeInfo);
            }
            else if (value.IsComparisonResponseNotFound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComparisonResponseNotFound!, typeInfo);
            }
            else if (value.IsUnavailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unavailable!, typeInfo);
            }
        }
    }
}