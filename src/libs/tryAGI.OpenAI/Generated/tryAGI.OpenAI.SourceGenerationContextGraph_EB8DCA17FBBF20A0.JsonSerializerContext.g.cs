
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_EB8DCA17FBBF20A0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_EB8DCA17FBBF20A0 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_EB8DCA17FBBF20A0(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaReasoningModeEnumJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaTextResponseFormatConfigurationJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningContext)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningContext?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificFunctionShellParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificFunctionShellParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificApplyPatchParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificApplyPatchParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificProgrammaticToolCallingParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificProgrammaticToolCallingParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceCustomTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceCustomTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceMCPTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceMCPTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceTypesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceTypesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceAllowedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceAllowedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceAllowedModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceAllowedModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceOptionsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceOptionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningContext))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningContextJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningContext?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningContextNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningGenerateSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningGenerateSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningEffortEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningModeEnumEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningModeEnumEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaVerbosityEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaVerbosityEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTextResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTextResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatTextTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3C7D8BEF5867F4EF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoning))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoning(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningContext))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningContext2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningEffortEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningGenerateSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningModeEnumEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningSummary))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFormatJsonObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonSchemaSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFormatJsonSchemaSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFormatText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFormatTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseTextParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseTextParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSpecificApplyPatchParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSpecificApplyPatchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSpecificFunctionShellParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSpecificFunctionShellParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSpecificProgrammaticToolCallingParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSpecificProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTextResponseFormatConfiguration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTextResponseFormatJsonSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTextResponseFormatJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowed))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceAllowed(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceAllowedMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceAllowedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustom))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceCustom(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceCustomType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCP))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceMCP(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceMCPType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceOptions2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypes))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceTypes(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceTypesType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaVerbosityEnum2(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningContext?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaReasoningContext2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaReasoningEffortEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaReasoningGenerateSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaReasoningModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaReasoningModeEnumEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningSummary?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaReasoningSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseFormatTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaSpecificApplyPatchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaSpecificFunctionShellParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaSpecificProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaTextResponseFormatConfiguration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaTextResponseFormatJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceAllowedMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceAllowedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceCustomType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceMCPType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceOptions2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceTypesType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaVerbosityEnum2(options);
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