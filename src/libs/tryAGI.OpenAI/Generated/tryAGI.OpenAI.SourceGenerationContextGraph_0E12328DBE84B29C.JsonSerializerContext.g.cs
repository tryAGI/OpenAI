
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_0E12328DBE84B29C : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_0E12328DBE84B29C Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_0E12328DBE84B29C(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ProviderJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogRoleUnboundFromResourceSource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogRoleUnboundFromResourceSource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogActorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogActorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogActorApiKeyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogActorApiKeyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListAuditLogsResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListAuditLogsResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProviderDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProviderDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AuditLogRoleBoundToResourceSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AuditLogRoleBoundToResourceSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogRoleUnboundFromResourceSource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AuditLogRoleUnboundFromResourceSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogRoleUnboundFromResourceSource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AuditLogRoleUnboundFromResourceSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogActorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AuditLogActorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogActorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AuditLogActorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogActorApiKeyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AuditLogActorApiKeyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogActorApiKeyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AuditLogActorApiKeyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AuditLogEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AuditLogEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AuditLogEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListAuditLogsResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListAuditLogsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListAuditLogsResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListAuditLogsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AwsExternalStorageProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AwsExternalStorageProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AzureExternalStorageProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AzureExternalStorageProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GcpExternalStorageProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GcpExternalStorageProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OciExternalStorageProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OciExternalStorageProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProviderDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProviderDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProviderDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProviderDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLog>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_12D2547B1153E842(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B31231F61C33E515(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_63126628F3493977(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogEventType>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_B7DD5AB6C4741F8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_00B56CE2D2F1CF8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_45EBF42508FE1EA4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLog))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLog(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogActor))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogActor(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogActorApiKey))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogActorApiKey(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogActorApiKeyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogActorApiKeyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogActorServiceAccount))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogActorServiceAccount(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogActorSession))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogActorSession(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogActorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogActorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogActorUser))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogActorUser(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogApiKeyCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogApiKeyCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogApiKeyCreatedData))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogApiKeyCreatedData(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogApiKeyDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogApiKeyDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogApiKeyUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogApiKeyUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogApiKeyUpdatedChangesRequested))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogApiKeyUpdatedChangesRequested(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogCertificateCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogCertificateCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogCertificateDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogCertificateDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogCertificateUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogCertificateUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogCertificatesActivated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogCertificatesActivated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogCertificatesActivatedCertificate(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogCertificatesDeactivated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogCertificatesDeactivated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogCertificatesDeactivatedCertificate(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogCheckpointPermissionCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreatedData))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogCheckpointPermissionCreatedData(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogCheckpointPermissionDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogCheckpointPermissionDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogExternalKeyRegistered))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogExternalKeyRegistered(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogExternalKeyRemoved))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogExternalKeyRemoved(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogExternalStorageRegistered))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogExternalStorageRegistered(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogExternalStorageRegisteredData))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogExternalStorageRegisteredData(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogExternalStorageRemoved))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogExternalStorageRemoved(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogGroupCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogGroupCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogGroupCreatedData))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogGroupCreatedData(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogGroupDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogGroupDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogGroupUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogGroupUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogGroupUpdatedChangesRequested))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogGroupUpdatedChangesRequested(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogInviteAccepted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogInviteAccepted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogInviteDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogInviteDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogInviteSent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogInviteSent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogInviteSentData))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogInviteSentData(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogIpAllowlistConfigActivated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogIpAllowlistConfigActivatedConfig(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogIpAllowlistConfigDeactivated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogIpAllowlistConfigDeactivatedConfig(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogIpAllowlistCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogIpAllowlistDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogIpAllowlistUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogLoginFailed))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogLoginFailed(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogLogoutFailed))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogLogoutFailed(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogOrganizationUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogOrganizationUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogOrganizationUpdatedChangesRequested))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogOrganizationUpdatedChangesRequested(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogProject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogProject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogProjectArchived))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogProjectArchived(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogProjectCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogProjectCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogProjectCreatedData))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogProjectCreatedData(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogProjectDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogProjectDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogProjectUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogProjectUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogProjectUpdatedChangesRequested))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogProjectUpdatedChangesRequested(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRateLimitDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRateLimitDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRateLimitUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRateLimitUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRateLimitUpdatedChangesRequested))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRateLimitUpdatedChangesRequested(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRoleAssignmentCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRoleAssignmentCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRoleAssignmentDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRoleAssignmentDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRoleBoundToResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRoleBoundToResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRoleBoundToResourceSource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRoleCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRoleCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRoleDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRoleDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRoleUnboundFromResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRoleUnboundFromResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRoleUnboundFromResourceSource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRoleUnboundFromResourceSource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRoleUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRoleUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRoleUpdatedChangesRequested))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogRoleUpdatedChangesRequested(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogScimDisabled))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogScimDisabled(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogScimEnabled))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogScimEnabled(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogServiceAccountCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogServiceAccountCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogServiceAccountCreatedData))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogServiceAccountCreatedData(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogServiceAccountDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogServiceAccountDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogServiceAccountUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogServiceAccountUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogServiceAccountUpdatedChangesRequested))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogServiceAccountUpdatedChangesRequested(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogUserAdded))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogUserAdded(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogUserAddedData))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogUserAddedData(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogUserDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogUserDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogUserUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogUserUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogUserUpdatedChangesRequested))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogUserUpdatedChangesRequested(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogWorkloadIdentityProviderCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogWorkloadIdentityProviderDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogWorkloadIdentityProviderMappingCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogWorkloadIdentityProviderMappingDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogWorkloadIdentityProviderMappingUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AuditLogWorkloadIdentityProviderUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AwsExternalStorageProviderResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AwsExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AzureExternalStorageProviderResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AzureExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_GcpExternalStorageProviderResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_GcpExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ListAuditLogsEffectiveAt))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ListAuditLogsEffectiveAt(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ListAuditLogsResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ListAuditLogsResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ListAuditLogsResponseObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ListAuditLogsResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OciExternalStorageProviderResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OciExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Provider))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Provider2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProviderDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProviderDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProviderDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProviderDiscriminatorType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AuditLogActorApiKeyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAuditLogActorApiKeyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogActorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAuditLogActorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAuditLogEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAuditLogRoleBoundToResourceSource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AuditLogRoleUnboundFromResourceSource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAuditLogRoleUnboundFromResourceSource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAwsExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAzureExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGcpExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ListAuditLogsResponseObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableListAuditLogsResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOciExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Provider?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableProvider2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProviderDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProviderDiscriminatorType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(long?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLog>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C1519B7943705AF5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8EF23A1E1CB6798B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_02C6F68045E32D5E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogEventType>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_83AB151A77D7A240(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C74B1F0D790E688E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6D0678E0A82EB64B(options);
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