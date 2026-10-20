
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_B748ED90498664C0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_B748ED90498664C0 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_B748ED90498664C0(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputContentParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SessionInputParamJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamInputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamInputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamInputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamInputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamActionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamActionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BrowserOriginAccessDecisionParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BrowserOriginAccessDecisionParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserOriginAccessParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserOriginAccessParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputCancelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputCancelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputToolResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputToolResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_74FB6931C9EACD1B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_55685EC92864462C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_3240AB93DF1B16D6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionInputParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_7492EAA3380A9DCB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BrowserAuthenticationFieldValueParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BrowserOriginAccessDecisionParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParamBrowserAuthentication(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParamBrowserAuthenticationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParamBrowserOriginAccessParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParamBrowserOriginAccessParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalResponseParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateSessionEventsParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateSessionEventsParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_FunctionCallOutputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamInputImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParamInputImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParamInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamInputText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParamInputText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParamInputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputMessageParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageParamRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputMessageParamRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputMessageParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionInputParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionInputParamAgentSessionInputCancel(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionInputParamAgentSessionInputCancelType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionInputParamAgentSessionInputComputerUseApprovalRequestResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionInputParamAgentSessionInputMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionInputParamAgentSessionInputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionInputParamAgentSessionInputToolResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionInputParamAgentSessionInputToolResultType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionInputParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionInputParamDiscriminatorType2(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBrowserOriginAccessDecisionParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseParamBrowserAuthenticationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseParamBrowserOriginAccessParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalResponseParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentParamInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentParamInputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageParamRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputMessageParamRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputMessageParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionInputParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionInputParamAgentSessionInputCancelType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionInputParamAgentSessionInputComputerUseApprovalRequestResultType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionInputParamAgentSessionInputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionInputParamAgentSessionInputToolResultType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionInputParamDiscriminatorType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_FF6E7648DE2F47EA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E6BC49CE6B1EA748(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputMessageParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_720FF0DF3D3792F8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionInputParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8F3E5E38AA87CC45(options);
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