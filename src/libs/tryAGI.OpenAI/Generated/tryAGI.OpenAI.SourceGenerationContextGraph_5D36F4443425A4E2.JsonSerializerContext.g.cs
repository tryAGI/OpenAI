
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_5D36F4443425A4E2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_5D36F4443425A4E2 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_5D36F4443425A4E2(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ImageGenStreamEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenCompletedEventSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenPartialImageEventSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenStreamEventDiscriminatorTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FC0ACBA26C044EC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_92E1ACA86984772C(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_NullableJsonElement(options);
                }
                if (type == typeof(global::System.Collections.Generic.IDictionary<string, object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7024F6984ED20EB8(options);
                }
                if (type == typeof(string))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_String(options);
                }
                if (type == typeof(object))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Object(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_JsonElement(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenCompletedEventSize?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5334403F269ABF41(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenPartialImageEventSize?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_368AC0C9F40F64A1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenCompletedEventBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenCompletedEventOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenCompletedEventQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenCompletedEventSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenPartialImageEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenPartialImageEventBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenPartialImageEventOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenPartialImageEventQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenPartialImageEventSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenPartialImageEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenStreamEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenStreamEventDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenStreamEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImagesUsage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImagesUsage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImagesUsageInputTokensDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImagesUsageInputTokensDetails(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenCompletedEventSize?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_F2B6C321BE824E6B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenPartialImageEventSize?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_A9C5BBECF837B100(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventBackground?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenCompletedEventBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenCompletedEventOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventQuality?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenCompletedEventQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenCompletedEventSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventBackground?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenPartialImageEventBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenPartialImageEventOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventQuality?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenPartialImageEventQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenPartialImageEventSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenPartialImageEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenPartialImageEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenStreamEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenStreamEventDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenStreamEventDiscriminatorType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }


        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SharedMetadataResolver(),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}