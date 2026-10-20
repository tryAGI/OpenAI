
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_AEC12289BF9A8901 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_AEC12289BF9A8901 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_AEC12289BF9A8901(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateVoiceRequestJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateVoicePromptRequestModel?>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoiceFromConsentRequestType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoiceFromConsentRequestType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequestType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequestType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoiceRequestDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoiceRequestDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoiceFromConsentRequestType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVoiceFromConsentRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoiceFromConsentRequestType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVoiceFromConsentRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequestType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVoicePromptRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequestType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVoicePromptRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVoicePromptRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVoicePromptRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoiceRequestDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVoiceRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVoiceRequestDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVoiceRequestDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(byte))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_Byte(options);
                }
                if (type == typeof(byte[]))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ByteArray(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateVoicePromptRequestModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E4B97FF88ABF0D03(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoiceFromConsentRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateVoiceFromConsentRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoiceFromConsentRequestType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateVoiceFromConsentRequestType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateVoicePromptRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequestModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateVoicePromptRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequestType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateVoicePromptRequestType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoiceRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateVoiceRequest2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoiceRequestDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateVoiceRequestDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoiceRequestDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateVoiceRequestDiscriminatorType2(options);
                }
                if (type == typeof(byte?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableByte(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateVoicePromptRequestModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_3AFE8D7515E284E3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoiceFromConsentRequestType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateVoiceFromConsentRequestType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequestModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateVoicePromptRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoicePromptRequestType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateVoicePromptRequestType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoiceRequest?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateVoiceRequest2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVoiceRequestDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateVoiceRequestDiscriminatorType2(options);
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