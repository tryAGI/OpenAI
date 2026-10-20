
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_B5ED7E758CC556F3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_B5ED7E758CC556F3 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_B5ED7E758CC556F3(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentExpiredJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentFailedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentReadyJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentSuspendedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionActionRequiredJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionCreatedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionFailedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionIdleJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionInProgressJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionEnvelopeObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionEnvelopeObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentSessionRequiredActionTypeResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentSessionRequiredActionTypeResource?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentExpiredVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentExpiredVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentFailedVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentFailedVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentReadyVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentReadyVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentSuspendedVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentEnvironmentSuspendedVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionActionRequiredVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionActionRequiredVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionCreatedVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionCreatedVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionEnvelopeObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionEnvelopeObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionEnvelopeObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionEnvelopeObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionFailedVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionFailedVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionIdleVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionIdleVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionInProgressVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebhookAgentSessionInProgressVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentSessionRequiredActionTypeResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentSessionRequiredActionTypeResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentSessionRequiredActionTypeResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentSessionRequiredActionTypeResourceNullableJsonConverter();
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
                if (type == typeof(global::tryAGI.OpenAI.AgentEnvironmentEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentEnvironmentEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentSessionActionRequiredPayloadResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentSessionActionRequiredPayloadResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentSessionConnectPayloadResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentSessionConnectPayloadResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentSessionCreatedPayloadResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentSessionCreatedPayloadResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentSessionEnvironmentPayloadResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentSessionEnvironmentPayloadResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentSessionRequiredActionPayloadResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentSessionRequiredActionPayloadResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentSessionRequiredActionTypeResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentSessionRequiredActionTypeResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpired))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentEnvironmentExpired2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentEnvironmentExpiredVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentEnvironmentExpiredVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailed))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentEnvironmentFailed2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentEnvironmentFailedVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentEnvironmentFailedVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentReady))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentEnvironmentReady2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentEnvironmentReadyVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentEnvironmentReadyVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspended))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentEnvironmentSuspended2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentEnvironmentSuspendedVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentEnvironmentSuspendedVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionActionRequired))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionActionRequired2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionActionRequiredVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionActionRequiredVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionCreated2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionCreatedVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionCreatedVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionEnvelope(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionEnvelopeObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionEnvelopeObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionFailed))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionFailed2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionFailedVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionFailedVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionIdle))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionIdle2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionIdleVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionIdleVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionInProgress))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionInProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionInProgressVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebhookAgentSessionInProgressVariant2Type2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentSessionRequiredActionTypeResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentSessionRequiredActionTypeResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpired?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentEnvironmentExpired2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentExpiredVariant2Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentEnvironmentExpiredVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailed?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentEnvironmentFailed2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentEnvironmentFailedVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentReady?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentEnvironmentReady2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentEnvironmentReadyVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspended?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentEnvironmentSuspended2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentSuspendedVariant2Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentEnvironmentSuspendedVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionActionRequired?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentSessionActionRequired2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentSessionActionRequiredVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionCreated?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentSessionCreated2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentSessionCreatedVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionEnvelopeObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentSessionEnvelopeObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionFailed?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentSessionFailed2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentSessionFailedVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionIdle?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentSessionIdle2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentSessionIdleVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionInProgress?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentSessionInProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebhookAgentSessionInProgressVariant2Type2(options);
                }
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