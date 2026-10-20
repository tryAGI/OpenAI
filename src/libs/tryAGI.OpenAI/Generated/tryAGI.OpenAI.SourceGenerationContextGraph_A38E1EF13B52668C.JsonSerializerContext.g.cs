
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_A38E1EF13B52668C : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_A38E1EF13B52668C Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_A38E1EF13B52668C(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicyVariant1JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SkillsVariant1ItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant14JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem15JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem17JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolChoiceVariant22JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.ToolChoiceVariant22?, global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebRTCTransportType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebRTCTransportType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesServiceTier)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesServiceTier?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningEffort)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningEffort?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveTextVerbosity)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveTextVerbosity?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveFileSearchToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveFileSearchToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveContainerMemoryLimit)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveContainerMemoryLimit?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSkillReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSkillReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParamMediaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParamMediaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInlineSkillParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveInlineSkillParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveContainerReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveContainerReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveLocalEnvironmentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveLocalEnvironmentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveImageGenerationToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveImageGenerationToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveMCPToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveMCPToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveCustomToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveCustomToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveNamespaceToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveNamespaceToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolSearchToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolSearchToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveComputerToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveComputerToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolChoiceEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolChoiceEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificFileSearchParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificFileSearchParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificImageGenParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificImageGenParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificComputerParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificComputerParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificCustomToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificCustomToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolChoiceValueEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolChoiceValueEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebRTCTransportType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveWebRTCTransportTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebRTCTransportType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveWebRTCTransportTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesServiceTier))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesServiceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesServiceTier?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesServiceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningEffort))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningEffort?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveReasoningSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveReasoningSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveReasoningSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveTextVerbosity))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveTextVerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveTextVerbosity?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveTextVerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveFunctionToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveFunctionToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveWebSearchToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveWebSearchToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveFileSearchToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveFileSearchToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveFileSearchToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveFileSearchToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveCodeInterpreterToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveCodeInterpreterToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveContainerMemoryLimit))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveContainerMemoryLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveContainerMemoryLimit?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveContainerMemoryLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveContainerNetworkPolicyDisabledParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveContainerNetworkPolicyDisabledParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveHostedShellNetworkPolicyAllowlistParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveHostedShellNetworkPolicyAllowlistParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSkillReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSkillReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSkillReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSkillReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInlineSkillSourceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInlineSkillSourceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParamMediaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInlineSkillSourceParamMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParamMediaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInlineSkillSourceParamMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInlineSkillParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInlineSkillParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveInlineSkillParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveInlineSkillParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveHostedShellContainerAutoParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveHostedShellContainerAutoParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveContainerReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveContainerReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveContainerReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveContainerReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveLocalEnvironmentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveLocalEnvironmentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveLocalEnvironmentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveLocalEnvironmentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveHostedShellToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveHostedShellToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveImageGenerationToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveImageGenerationToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveImageGenerationToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveImageGenerationToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveMCPToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveMCPToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveMCPToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveMCPToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveCustomToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveCustomToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveCustomToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveCustomToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveNamespaceToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveNamespaceToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveNamespaceToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveNamespaceToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolSearchToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveToolSearchToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolSearchToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveToolSearchToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveProgrammaticToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveProgrammaticToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveComputerToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveComputerToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveComputerToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveComputerToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveApplyPatchToolInputParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveApplyPatchToolInputParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolChoiceEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveToolChoiceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolChoiceEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveToolChoiceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveFunctionToolChoiceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveFunctionToolChoiceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveMCPToolChoiceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveMCPToolChoiceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificFileSearchParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificFileSearchParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificFileSearchParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificFileSearchParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificWebSearchParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificWebSearchParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificWebSearchPreviewParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificWebSearchPreviewParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificImageGenParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificImageGenParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificImageGenParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificImageGenParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificComputerParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificComputerParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificComputerParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificComputerParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificCodeInterpreterParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificCodeInterpreterParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificProgrammaticToolCallingParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificProgrammaticToolCallingParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificFunctionShellParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificFunctionShellParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificCustomToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificCustomToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificCustomToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificCustomToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificApplyPatchParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveSpecificApplyPatchParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolChoiceValueEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveToolChoiceValueEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveToolChoiceValueEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveToolChoiceValueEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveAllowedToolsChoiceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveAllowedToolsChoiceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveAllowedToolsChoiceParamToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveAllowedToolsChoiceParamToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveDataChannelConfigParamAllowedClientEventsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveDataChannelConfigParamAllowedClientEventsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveDataChannelConfigParamAllowedServerEventsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveDataChannelConfigParamAllowedServerEventsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationUpdateParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LiveResponsesDelegationUpdateParamTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C948D71A7D370CF4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveLocalSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_F5663048032B2B42(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_EF24A9BF4136D999(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem15>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_56FC8C60548168B1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem17>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_476F5B051D504BE3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentVariant14))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EnvironmentVariant14(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveAllowedServerEventParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveAllowedServerEventParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveAllowedToolsChoiceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveAllowedToolsChoiceParamToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveAllowedToolsChoiceParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveAllowedToolsChoiceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveApplyPatchToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveApplyPatchToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveApplyPatchToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveClientConfigParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LiveClientConfigParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveCodeInterpreterToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveCodeInterpreterToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveComputerToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveComputerToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveComputerToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveComputerToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveContainerMemoryLimit))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveContainerMemoryLimit2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveContainerNetworkPolicyDisabledParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveContainerNetworkPolicyDisabledParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveContainerReferenceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveContainerReferenceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveContainerReferenceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveContainerReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveCreateResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LiveCreateResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveCreateResponseSession))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LiveCreateResponseSession(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveCustomToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveCustomToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveCustomToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveCustomToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveDataChannelConfigParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveDataChannelConfigParamAllowedClientEvents2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveDataChannelConfigParamAllowedServerEvents2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveDelegationReasoningInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveDelegationReasoningInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveDelegationTextInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveDelegationTextInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveFileSearchToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveFileSearchToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveFileSearchToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveFileSearchToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveForkRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LiveForkRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveFunctionToolChoiceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveFunctionToolChoiceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveFunctionToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveFunctionToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveHostedShellContainerAutoParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1Discriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveHostedShellContainerAutoParamNetworkPolicyVariant1Discriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveHostedShellContainerAutoParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveHostedShellNetworkPolicyAllowlistParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveHostedShellNetworkPolicyAllowlistParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveHostedShellToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1Discriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveHostedShellToolInputParamEnvironmentVariant1Discriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveHostedShellToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveImageGenerationToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveImageGenerationToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveImageGenerationToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveImageGenerationToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveInlineSkillParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveInlineSkillParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveInlineSkillParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveInlineSkillParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveInlineSkillSourceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParamMediaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveInlineSkillSourceParamMediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveInlineSkillSourceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveLocalEnvironmentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveLocalEnvironmentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveLocalEnvironmentParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveLocalEnvironmentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveLocalSkillParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveLocalSkillParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveMCPToolChoiceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveMCPToolChoiceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveMCPToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveMCPToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveMCPToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveMCPToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveMediaSessionForkParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LiveMediaSessionForkParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveNamespaceToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveNamespaceToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveNamespaceToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveNamespaceToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveProgrammaticToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveProgrammaticToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveProgrammaticToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveReasoningEffort))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveReasoningEffort2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveReasoningSummary))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveReasoningSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveResponsesDelegationSettingsUpdateInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2Discriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2Discriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LiveResponsesDelegationUpdateParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveResponsesDelegationUpdateParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponsesServiceTier))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveResponsesServiceTier2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSkillReferenceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSkillReferenceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSkillReferenceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSkillReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificApplyPatchParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificApplyPatchParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificApplyPatchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificCodeInterpreterParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificCodeInterpreterParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificComputerParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificComputerParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificComputerParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificComputerParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificCustomToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificCustomToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificCustomToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificCustomToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificFileSearchParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificFileSearchParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificFileSearchParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificFileSearchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificFunctionShellParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificFunctionShellParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificFunctionShellParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificImageGenParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificImageGenParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificImageGenParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificImageGenParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificProgrammaticToolCallingParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificWebSearchParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificWebSearchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificWebSearchPreviewParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveSpecificWebSearchPreviewParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveTextVerbosity))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveTextVerbosity2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveToolChoiceEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveToolChoiceEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveToolChoiceValueEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveToolChoiceValueEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveToolSearchToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveToolSearchToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveToolSearchToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveToolSearchToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveWebRTCTransport))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LiveWebRTCTransport(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveWebRTCTransportType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LiveWebRTCTransportType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveWebSearchToolInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LiveWebSearchToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicyVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_NetworkPolicyVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_4A6EB8E769335260(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D78E033373CFC058(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.ToolChoiceVariant22?, global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D871C0196EAC03AC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillsVariant1Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SkillsVariant1Item2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceVariant22))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceVariant222(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem15))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolsItem152(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem17))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolsItem172(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveAllowedToolsChoiceParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveAllowedToolsChoiceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveAllowedToolsChoiceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveApplyPatchToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveApplyPatchToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveCodeInterpreterToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveComputerToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveComputerToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveContainerMemoryLimit?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveContainerMemoryLimit2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveContainerNetworkPolicyDisabledParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveContainerReferenceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveContainerReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveCustomToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveCustomToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveDataChannelConfigParamAllowedClientEvents2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveDataChannelConfigParamAllowedServerEvents2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveFileSearchToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveFileSearchToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveFunctionToolChoiceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveFunctionToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveHostedShellContainerAutoParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveHostedShellNetworkPolicyAllowlistParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveHostedShellToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveImageGenerationToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveImageGenerationToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveInlineSkillParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveInlineSkillParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParamMediaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveInlineSkillSourceParamMediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveInlineSkillSourceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveInlineSkillSourceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveLocalEnvironmentParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveLocalEnvironmentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveMCPToolChoiceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveMCPToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveMCPToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveNamespaceToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveNamespaceToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveProgrammaticToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveReasoningEffort?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveReasoningEffort2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveReasoningSummary?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveReasoningSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveResponsesDelegationUpdateParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponsesServiceTier?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveResponsesServiceTier2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSkillReferenceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveSkillReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificApplyPatchParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveSpecificApplyPatchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveSpecificCodeInterpreterParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificComputerParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveSpecificComputerParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificCustomToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveSpecificCustomToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificFileSearchParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveSpecificFileSearchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificFunctionShellParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveSpecificFunctionShellParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificImageGenParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveSpecificImageGenParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveSpecificProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveSpecificWebSearchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveSpecificWebSearchPreviewParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveTextVerbosity?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveTextVerbosity2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveToolChoiceEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveToolChoiceEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveToolChoiceValueEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveToolChoiceValueEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveToolSearchToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveToolSearchToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveWebRTCTransportType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveWebRTCTransportType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLiveWebSearchToolInputParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.IList<string>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D645E24C54CF5A72(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_CD2F2D4B445A9BF7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveToolChoiceEnum?, global::tryAGI.OpenAI.ToolChoiceVariant22?, global::tryAGI.OpenAI.LiveAllowedToolsChoiceParam>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_CEABA8D6104EEB0E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillsVariant1Item?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSkillsVariant1Item2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceVariant22?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceVariant222(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem15?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolsItem152(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem17?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolsItem172(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveAllowedServerEventParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7D302244D4940B73(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveLocalSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7D5264872F36D281(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C03AAA9AB9C04C32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem15>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F7CCF256A7AA8C40(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem17>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_4117B89B971530C6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedClientEvents?, global::System.Collections.Generic.List<string>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7A6A67CCD68459B5(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDataChannelConfigParamAllowedServerEvents?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.LiveAllowedServerEventParam>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5288C65910E9C13F(options);
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