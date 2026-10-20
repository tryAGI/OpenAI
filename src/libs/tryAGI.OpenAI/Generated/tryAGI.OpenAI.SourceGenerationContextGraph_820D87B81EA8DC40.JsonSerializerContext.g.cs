
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_820D87B81EA8DC40 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_820D87B81EA8DC40 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_820D87B81EA8DC40(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageRequestModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageRequestSize?>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModeration)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModeration?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestStyle)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestStyle?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModeration))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestModerationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestModeration?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestModerationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestStyle))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageRequestStyle?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageRequestStyleNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
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
                if (type == typeof(bool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3E4A874400188133(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestSize?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F5796F0CC62868C7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestBackground))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageRequestBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestModeration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageRequestModeration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageRequestOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestQuality))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageRequestQuality2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageRequestResponseFormat2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageRequestSize2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestStyle))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageRequestStyle2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_6661E6E93E1D9893(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestSize?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_E206C96CC1B92FE9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestBackground?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateImageRequestBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateImageRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestModeration?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateImageRequestModeration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestOutputFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateImageRequestOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestQuality?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateImageRequestQuality2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestResponseFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateImageRequestResponseFormat2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateImageRequestSize2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateImageRequestStyle?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateImageRequestStyle2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                return null;
            }
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