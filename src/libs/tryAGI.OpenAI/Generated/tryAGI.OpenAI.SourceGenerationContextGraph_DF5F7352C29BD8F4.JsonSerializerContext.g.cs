
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_DF5F7352C29BD8F4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_DF5F7352C29BD8F4 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_DF5F7352C29BD8F4(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AgentContentResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputContentResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SessionTurnItemResourceJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionMessageRoleResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionMessageRoleResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceOutputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceOutputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemStatusResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemStatusResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhaseResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhaseResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatusResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatusResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentMessageItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentMessageItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOtherType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOtherType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CommandExecutionItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CommandExecutionItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionItemListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionItemListResourceObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputTextResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputTextResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EncryptedContentResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EncryptedContentResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentContentResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentContentResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionMessageRoleResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionMessageRoleResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionMessageRoleResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionMessageRoleResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceInputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceInputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceInputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceInputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceOutputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceOutputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceOutputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceOutputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemStatusResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputItemStatusResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemStatusResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputItemStatusResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhaseResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhaseResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhaseResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhaseResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SummaryTextResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SummaryTextResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatusResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatusResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentResourceInputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentResourceInputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentResourceInputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentResourceInputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentMessageItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentMessageItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentMessageItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentMessageItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BrowserAuthenticationRequestItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BrowserAuthenticationRequestItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceActionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceActionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceDiscriminatorActionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceDiscriminatorActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalRequestResultItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalRequestResultItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceOpenPageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceOpenPageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceFindInPageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceFindInPageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOtherType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceOtherTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOtherType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceOtherTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CommandExecutionItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CommandExecutionItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CommandExecutionItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CommandExecutionItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InterruptSubagentCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InterruptSubagentCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSubagentCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSubagentCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SendSubagentInputCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SendSubagentInputCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResumeSubagentCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResumeSubagentCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WaitForSubagentsCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WaitForSubagentsCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CloseSubagentCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CloseSubagentCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionTurnItemResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionTurnItemResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionItemListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionItemListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionItemListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionItemListResourceObjectNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BA79033F863F8AED(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_6BE05555663EF51C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_76EFD47CC825F5DD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_3B660A613239EB21(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageContentResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D4436A48E2C32C10(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionTurnItemResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_56EBA4033058D106(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C81666678B7199E4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentContentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentContentResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentContentResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentContentResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentMessageItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentMessageItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentMessageItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentMessageItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserAuthenticationFieldResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_BrowserAuthenticationFieldResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserAuthenticationOptionResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_BrowserAuthenticationOptionResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_BrowserAuthenticationRequestItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_BrowserAuthenticationRequestItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CloseSubagentCallItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CloseSubagentCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CommandExecutionItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CommandExecutionItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CommandExecutionItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CommandExecutionItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerScreenshotResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerScreenshotResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerScreenshotResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerScreenshotResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseApprovalRequestResultItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseApprovalRequestResultItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseApprovalResponseKindResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseApprovalResponseKindResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseApprovalResponseKindResourceDiscriminatorAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseCallItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseCallItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseCallItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUseCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CreateSubagentCallItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CreateSubagentCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EncryptedContentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EncryptedContentResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EncryptedContentResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionCallItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionCallOutputItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionCallOutputItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionCallOutputResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallStatusResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionCallStatusResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputContentResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputContentResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputContentResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentResourceInputImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputContentResourceInputImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentResourceInputImageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputContentResourceInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentResourceInputText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputContentResourceInputText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentResourceInputTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputContentResourceInputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InterruptSubagentCallItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InterruptSubagentCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpCallItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_McpCallItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpCallItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_McpCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageContentResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageContentResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageContentResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResourceInputImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageContentResourceInputImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResourceInputImageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageContentResourceInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResourceInputText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageContentResourceInputText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResourceInputTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageContentResourceInputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResourceOutputText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageContentResourceOutputText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResourceOutputTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageContentResourceOutputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessagePhaseResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessagePhaseResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputItemStatusResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OutputItemStatusResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OutputTextResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OutputTextResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResumeSubagentCallItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResumeSubagentCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SendSubagentInputCallItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SendSubagentInputCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionItemListResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SessionItemListResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionItemListResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SessionItemListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionMessageRoleResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SessionMessageRoleResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionTurnItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SessionTurnItemResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SessionTurnItemResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SessionTurnItemResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SummaryTextResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SummaryTextResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SummaryTextResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SummaryTextResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WaitForSubagentsCallItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WaitForSubagentsCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionResourceFindInPage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionResourceFindInPageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionResourceOpenPage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionResourceOpenPageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOther))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionResourceOther(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOtherType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionResourceOtherType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionResourceSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearchType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionResourceSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchCallItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchCallItemResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchCallItemResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchCallItemResourceType2(options);
                }
                if (type == typeof(long))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentContentResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentContentResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentContentResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentMessageItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentMessageItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBrowserAuthenticationRequestItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCloseSubagentCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CommandExecutionItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCommandExecutionItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerScreenshotResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerScreenshotResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestResultItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalRequestResultItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseKindResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceDiscriminatorAction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseKindResourceDiscriminatorAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseCallItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateSubagentCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEncryptedContentResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionCallOutputItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallStatusResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionCallStatusResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentResourceInputImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentResourceInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentResourceInputTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentResourceInputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInterruptSubagentCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpCallItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResourceInputImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentResourceInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResourceInputTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentResourceInputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentResourceOutputTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentResourceOutputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessagePhaseResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessagePhaseResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputItemStatusResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputItemStatusResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputTextResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResumeSubagentCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSendSubagentInputCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionItemListResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionItemListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionMessageRoleResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionMessageRoleResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionTurnItemResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionTurnItemResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionTurnItemResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SummaryTextResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSummaryTextResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWaitForSubagentsCallItemResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchActionResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchActionResourceFindInPageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchActionResourceOpenPageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOtherType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchActionResourceOtherType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearchType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchActionResourceSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchCallItemResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchCallItemResourceType2(options);
                }
                if (type == typeof(long?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentContentResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A6E82A8FAB805418(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_00DA528B192B5D7D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EEE6C55815B4EB51(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8A64179B2AF3B41E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageContentResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B8AD41859B5B6294(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionTurnItemResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D5D59015E4B07FA7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SummaryTextResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_854F99407DBD6887(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
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