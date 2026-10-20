
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_91EC8B2B8625E903 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_91EC8B2B8625E903 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_91EC8B2B8625E903(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.TextResponseFormatConfigurationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolChoiceParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ReasoningModeEnumJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningContext)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningContext?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningContext))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningContextJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningContext?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningContextNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningGenerateSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningGenerateSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceCustomTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceCustomTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceMCPTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceMCPTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceOptionsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceOptionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceTypesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificProgrammaticToolCallingParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificProgrammaticToolCallingParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificApplyPatchParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificApplyPatchParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificFunctionShellParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificFunctionShellParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningModeEnumEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningModeEnumEnumNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3C7D8BEF5867F4EF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Reasoning))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Reasoning(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningContext))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningContext2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ReasoningEffortEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningGenerateSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningModeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningModeEnumEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningSummary))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseFormatJsonObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatJsonSchemaSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseFormatText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseTextParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseTextParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SpecificApplyPatchParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SpecificApplyPatchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SpecificFunctionShellParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SpecificFunctionShellParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SpecificProgrammaticToolCallingParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SpecificProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextResponseFormatConfiguration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TextResponseFormatConfiguration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TextResponseFormatJsonSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TextResponseFormatJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceAllowed))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceAllowed(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceAllowedMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceAllowedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceCustom))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceCustom(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceCustomType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolChoiceFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceMCP))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolChoiceMCP(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceMCPType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolChoiceOptions2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceTypes))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceTypes(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceTypesType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VerbosityEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_VerbosityEnum2(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningContext?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningContext2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableReasoningEffortEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningGenerateSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningModeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningModeEnumEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningSummary?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFormatTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSpecificApplyPatchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSpecificFunctionShellParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSpecificProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextResponseFormatConfiguration?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableTextResponseFormatConfiguration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTextResponseFormatJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceAllowedMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceAllowedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceCustomType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceMCPType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceOptions?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceOptions2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceTypesType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VerbosityEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableVerbosityEnum2(options);
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