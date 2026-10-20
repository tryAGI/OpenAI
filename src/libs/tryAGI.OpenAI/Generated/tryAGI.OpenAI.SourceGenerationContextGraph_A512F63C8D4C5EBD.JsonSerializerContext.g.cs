
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_A512F63C8D4C5EBD : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_A512F63C8D4C5EBD Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_A512F63C8D4C5EBD(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.StopConfigurationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateCompletionRequestModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateCompletionRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateCompletionRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateCompletionResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateCompletionResponseObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateCompletionRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateCompletionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateCompletionRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateCompletionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateCompletionResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateCompletionResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateCompletionResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter();
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
                if (type == typeof(bool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(double))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, double>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3D6C2C32ACF6EA76(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, int>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_1780DE272E50FA7E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<double>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_887498FFA805A692(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8D86EE3C00644128(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B0F45F161D53AA61(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateCompletionResponseChoice>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F34661F92815A735(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<int>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_827998FE1115C670(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateCompletionRequestModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5658A15BFBE41EE9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionStreamOptionsVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionStreamOptionsVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompletionUsage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompletionUsage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompletionUsageCompletionTokensDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompletionUsageCompletionTokensDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompletionUsagePromptTokensDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompletionUsagePromptTokensDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateCompletionRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateCompletionRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateCompletionRequestModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateCompletionRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateCompletionResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateCompletionResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateCompletionResponseChoice))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateCompletionResponseChoice(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateCompletionResponseChoiceFinishReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateCompletionResponseChoiceLogprobs))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateCompletionResponseChoiceLogprobs(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateCompletionResponseObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateCompletionResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E70C08C67DF458A0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.StopConfiguration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_StopConfiguration2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(long))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateCompletionRequestModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_50854B53E082B023(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateCompletionRequestModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateCompletionRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateCompletionResponseChoiceFinishReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateCompletionResponseObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateCompletionResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_AEF33595C98D6EA8(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.StopConfiguration?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableStopConfiguration2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(long?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<double>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D64E05E278D4AE77(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0BC72C14C990D189(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_822B1E82EA9C2DEF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateCompletionResponseChoice>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_52BBD1A99631FB22(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<int>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2058AC0D316B5916(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_96DDE306D2775F6D(options);
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