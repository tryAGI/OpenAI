
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_02D6DC37890BD8C9 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_02D6DC37890BD8C9 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_02D6DC37890BD8C9(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallsItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageContentPartJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestSystemMessageContentPartJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestToolMessageContentPartJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestUserMessageContentPartJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateModelResponsePropertiesJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.StopConfigurationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?, global::tryAGI.OpenAI.ChatCompletionFunctionCallOption>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat, global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PredictionContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PredictionContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionAllowedToolsChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageCustomToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageCustomToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceCustomTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceCustomTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageContentPartDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageContentPartDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestDeveloperMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioInputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartAudioInputAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartFileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartFileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2AudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2AudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2FunctionCallJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionRequestVariant2FunctionCallNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatTextFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatTextFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntaxNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelResponsePropertiesPromptCacheRetentionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelResponsePropertiesPromptCacheRetentionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PredictionContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PredictionContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PredictionContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PredictionContentTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseModalitiesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseModalitiesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheTTLEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheTTLEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheModeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheModeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationModeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, int>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_1780DE272E50FA7E(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionFunctions>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F9B81E2A923EC473(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_ADC375474415018E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessage>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C059841E343F7FAA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A8EB9117C7118F90(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_11E81CB35F94AE8C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7AE1FD33EC9431C1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_92A12F73E594FE1B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_353FA6D05FD47ECD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseModalitiesVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_95DEAAAFB40E6491(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3C7D8BEF5867F4EF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedTools))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionAllowedTools(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionAllowedToolsChoice(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionAllowedToolsChoiceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionAllowedToolsMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionFunctionCallOption))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionFunctionCallOption(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionFunctions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionFunctions(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageCustomToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallCustom))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageCustomToolCallCustom(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageCustomToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageToolCallDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageToolCallDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageToolCallFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageToolCallsItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionNamedToolChoice(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionNamedToolChoiceCustom(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomCustom))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionNamedToolChoiceCustomCustom(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionNamedToolChoiceCustomType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionNamedToolChoiceFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionNamedToolChoiceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessageAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessageContentPart2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessageContentPartDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessageContentPartDiscriminatorType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageFunctionCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessageFunctionCall(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestDeveloperMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestDeveloperMessageRole2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestFunctionMessage(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestFunctionMessageRole2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartAudioInputAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartAudioInputAudioFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartAudioType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartFile(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileFile))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartFileFile(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartFileType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrl))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartImageImageUrl(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartImageImageUrlDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartRefusal(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartRefusalType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageDiscriminatorRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestSystemMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestSystemMessageContentPart2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestSystemMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestToolMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestToolMessageContentPart2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestToolMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestUserMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestUserMessageContentPart2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestUserMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionStreamOptionsVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionStreamOptionsVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOption))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionToolChoiceOption2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionToolChoiceOptionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionRequest2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionRequestVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2Audio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionRequestVariant2Audio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionRequestVariant2AudioFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionRequestVariant2FunctionCall2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionRequestVariant2ResponseFormatDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionRequestVariant2WebSearchOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModelResponseProperties))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModelResponseProperties2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModelResponsePropertiesVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolChatCompletions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustom))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolChatCompletionsCustom(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolChatCompletionsCustomFormatGrammarFormat(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammar))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolChatCompletionsCustomFormatGrammarFormatGrammar(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolChatCompletionsCustomFormatGrammarFormatType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolChatCompletionsCustomFormatTextFormat(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolChatCompletionsCustomFormatTextFormatType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolChatCompletionsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionParameters))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionParameters(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelIdsShared))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModelIdsShared2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModelIdsSharedEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelResponseProperties))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModelResponseProperties(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModelResponsePropertiesPromptCacheRetention2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.ModerationConfigParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationConfigParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModerationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationPolicyParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationPolicyParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_0042BA96772562E1(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?, global::tryAGI.OpenAI.ChatCompletionFunctionCallOption>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_DF86D56617EF93DF(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat, global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_15761F2F83B46146(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_76DED36913040C6C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_740C121516D46D32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_659973D5DFD47FEB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9E7B0D419F228898(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3D4A0CEDC48615CD(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PredictionContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_PredictionContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PredictionContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_PredictionContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_PromptCacheBreakpointParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheBreakpointParamMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheOptionsParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_PromptCacheOptionsParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheTTLEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ReasoningEffortEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseFormatJsonObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseFormatJsonSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatJsonSchemaJsonSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatJsonSchemaSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseFormatText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseModalitiesVariant1Item2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ServiceTierEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ServiceTierEnum2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.StopConfiguration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_StopConfiguration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VerbosityEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_VerbosityEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoice))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_VoiceIdsOrCustomVoice2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoiceVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VoiceIdsOrCustomVoiceVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsShared))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_VoiceIdsShared2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VoiceIdsSharedEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchContextSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_WebSearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchLocation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_WebSearchLocation(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoiceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionAllowedToolsChoiceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionAllowedToolsMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionMessageCustomToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionMessageToolCallDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionMessageToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionMessageToolCallsItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionNamedToolChoiceCustomType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionNamedToolChoiceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestAssistantMessageContentPart2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestAssistantMessageContentPartDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestAssistantMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestDeveloperMessageRole2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestFunctionMessageRole2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessage?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestMessage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioInputAudioFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestMessageContentPartAudioInputAudioFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudioType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestMessageContentPartAudioType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFileType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestMessageContentPartFileType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrlDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestMessageContentPartImageImageUrlDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestMessageContentPartImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestMessageContentPartRefusalType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestMessageContentPartTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestMessageDiscriminatorRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestSystemMessageContentPart2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestSystemMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestToolMessageContentPart2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestToolMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestUserMessageContentPart2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestUserMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOption?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionToolChoiceOption2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionToolChoiceOptionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequest?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateChatCompletionRequest2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2AudioFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateChatCompletionRequestVariant2AudioFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateChatCompletionRequestVariant2FunctionCall2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModelResponseProperties?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateModelResponseProperties2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormatType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomToolChatCompletionsCustomFormatGrammarFormatType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormatType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomToolChatCompletionsCustomFormatTextFormatType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolChatCompletionsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomToolChatCompletionsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelIdsShared?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableModelIdsShared2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModelIdsSharedEnum2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModelResponsePropertiesPromptCacheRetention2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.ModerationMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModerationMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_67E90A978B596076(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2FunctionCall?, global::tryAGI.OpenAI.ChatCompletionFunctionCallOption>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D8D67DB6D4959CDC(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatTextFormat, global::tryAGI.OpenAI.CustomToolChatCompletionsCustomFormatGrammarFormat>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_867B86511158A569(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_A485992B9B9C6ABE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_02E8F7DF8155292A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_11C29D834D6AF70D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_B294AC8C27DBB1E7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PredictionContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePredictionContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheBreakpointParamMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheTTLEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableReasoningEffortEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableResponseFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFormatJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFormatTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseModalitiesVariant1Item?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseModalitiesVariant1Item2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ServiceTierEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableServiceTierEnum2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.StopConfiguration?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableStopConfiguration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VerbosityEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableVerbosityEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoice?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableVoiceIdsOrCustomVoice2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsShared?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVoiceIdsShared2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVoiceIdsSharedEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchContextSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableWebSearchContextSize2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(long?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt64(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionFunctions>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2404D3D2B0062A03(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2C01A7AD62806ECD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestMessage>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_606C4BCEC31C0957(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8B0064D7F4AA9CC7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E9379FD1BA40DF3D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6D284F2CC15FB87A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BD2107D36E1E2EB2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1B4FE3C250C76241(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseModalitiesVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_325D89D128AA6548(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B3903E113224A413(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2988BF3CC2BBA364(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5284A63485F6F646(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestToolMessageContentPart>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0FA2295A639E8A2E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPart>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_49F36FE069CD1550(options);
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