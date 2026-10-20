
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_450A3E24EE149813 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_450A3E24EE149813 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_450A3E24EE149813(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaToolJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem18JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Format3JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant15JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicy4JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SkillsItem3JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicy5JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaFiltersJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FiltersItem2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContextSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFidelity)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFidelity?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaRankerVersionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaRankerVersionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCallableToolAllowedCallerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCallableToolAllowedCallerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchPreviewToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchPreviewToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSearchContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSearchContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContextSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContextSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApproximateLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApproximateLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchExecutionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchExecutionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaNamespaceToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaNamespaceToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaNamespaceToolParamToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaNamespaceToolParamToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolParamFormatDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolParamFormatDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomGrammarFormatParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomGrammarFormatParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaGrammarSyntax1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaGrammarSyntax1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomTextFormatParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomTextFormatParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalEnvironmentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalEnvironmentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamNetworkPolicyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamNetworkPolicyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamSkillDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamSkillDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSkillReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSkillReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyAllowlistParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyAllowlistParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyDisabledParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyDisabledParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerMemoryLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerMemoryLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModerationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModerationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenActionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFidelity))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFidelityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFidelity?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFidelityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgrammaticToolCallingParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgrammaticToolCallingParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolConnectorIdJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolConnectorIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolRequireApprovalVariant1Enum2JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolRequireApprovalVariant1Enum2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolSearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolSearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchApproximateLocationWebSearchApproximateLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchApproximateLocationWebSearchApproximateLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerUsePreviewToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerUsePreviewToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerEnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompoundFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompoundFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComparisonFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComparisonFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaRankerVersionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaRankerVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaRankerVersionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaRankerVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_EAE69C9361FEA0E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_2DA866CD6D65D4EE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLocalSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D386F3831B29642B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSearchContentType>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_7C85385FBE0CEB3E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D6AF8FE2BB293ED3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_2C996200A138DC7E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A588C663D689201D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem3>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_3F2038DF7B013DC9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem18>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E375E849C1462BFC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C236CB9A53D5F0E5(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_F928175D16C32167(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApproximateLocation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApproximateLocation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApproximateLocationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAutoCodeInterpreterToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAutoCodeInterpreterToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCallableToolAllowedCaller2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComparisonFilter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComparisonFilter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComparisonFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompoundFilter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCompoundFilter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompoundFilterFilterDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCompoundFilterFilterDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCompoundFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerEnvironment2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerUsePreviewTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerUsePreviewToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerAutoParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerAutoParamNetworkPolicyDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerAutoParamNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerAutoParamSkillDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerAutoParamSkillDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerAutoParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerMemoryLimit2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerNetworkPolicyAllowlistParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerNetworkPolicyAllowlistParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerNetworkPolicyDisabledParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerNetworkPolicyDisabledParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerNetworkPolicyDomainSecretParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerReferenceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomGrammarFormatParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomGrammarFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomTextFormatParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomTextFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolParamFormatDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolParamFormatDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEmptyModelParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaEmptyModelParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileSearchTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileSearchTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileSearchToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFilters))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFilters(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1Discriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellToolParamEnvironmentVariant1Discriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaGrammarSyntax12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaHybridSearchOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaHybridSearchOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenActionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolInputImageMask))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolInputImageMask(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolModeration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInlineSkillParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInlineSkillParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInlineSkillSourceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInlineSkillSourceParamMediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInlineSkillSourceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFidelity))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputFidelity2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalEnvironmentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalEnvironmentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalShellToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalShellToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalSkillParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalSkillParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPTool(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolConnectorId2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolFilter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolFilter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolRequireApprovalVariant1Enum(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolRequireApprovalVariant1Enum22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaNamespaceToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaNamespaceToolParamToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaNamespaceToolParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaNamespaceToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgrammaticToolCallingParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaRankerVersionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaRankerVersionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaRankingOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaRankingOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSearchContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSearchContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSearchContextSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSkillReferenceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSkillReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchExecutionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchApproximateLocationWebSearchApproximateLocation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchApproximateLocationWebSearchApproximateLocationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchPreviewTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchPreviewToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolFilters))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchToolFilters(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchToolSearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentVariant15))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentVariant15(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FiltersItem2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_FiltersItem22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Format3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_Format32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy4))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NetworkPolicy42(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy5))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NetworkPolicy52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_7158C76B7E4EE28D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_70F91A4647BF4C91(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_33CE3604D32F85AE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_569B880384C23575(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_F891446D11C80FC4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillsItem3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SkillsItem32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem18))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ToolsItem182(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_69552AA6DD483460(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7D0057FCBF1FF89F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApproximateLocationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAutoCodeInterpreterToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCallableToolAllowedCaller2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCodeInterpreterToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComparisonFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCompoundFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerEnvironment2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerUsePreviewToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerAutoParamNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerAutoParamSkillDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerAutoParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerMemoryLimit2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerNetworkPolicyAllowlistParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerNetworkPolicyDisabledParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCustomGrammarFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCustomTextFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCustomToolParamFormatDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCustomToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFileSearchToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaGrammarSyntax12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenActionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolModeration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInlineSkillParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInlineSkillSourceParamMediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInlineSkillSourceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFidelity?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputFidelity2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaLocalEnvironmentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaLocalShellToolParamType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPToolConnectorId2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPToolRequireApprovalVariant1Enum22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaNamespaceToolParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaNamespaceToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaRankerVersionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaRankerVersionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSearchContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaSearchContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSearchContextSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaSearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaSkillReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaTool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchExecutionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchApproximateLocationWebSearchApproximateLocationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchPreviewToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchToolSearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FiltersItem2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableFiltersItem22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Format3?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableFormat32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy4?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableNetworkPolicy42(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy5?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableNetworkPolicy52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_01848C29385428F2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_528BFF85AF3E2294(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BC31F48C4D4D6F8C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillsItem3?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableSkillsItem32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem18?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableToolsItem182(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6B927CB1EA97EDA8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D1BCB1597AD6A845(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLocalSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_71B03C1937496CFF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSearchContentType>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E3D78B09BB121678(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F50A81EFA7CA3AAE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_ABF2149A5D315966(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E3941FEAF2607AE9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem3>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0A38409D7E2D219A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem18>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F8D5F0D02B3DA77(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_71AA2D78283B8378(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C8EB3E0743925723(options);
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