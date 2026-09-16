
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogEventType), TypeInfoPropertyName = "AuditLogEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogApiKeyCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogApiKeyCreatedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogApiKeyUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogApiKeyUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogApiKeyDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreatedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCheckpointPermissionDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogExternalKeyRegistered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogExternalKeyRemoved))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogGroupCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogGroupCreatedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogGroupUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogGroupUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogGroupDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogScimEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogScimDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogInviteSent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogInviteSentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogInviteAccepted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogInviteDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogLoginFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogLogoutFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogOrganizationUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogOrganizationUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProjectCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProjectCreatedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProjectUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProjectUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProjectArchived))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogProjectDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRateLimitUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRateLimitUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRateLimitDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleAssignmentCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleAssignmentDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleBoundToResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource), TypeInfoPropertyName = "AuditLogRoleBoundToResourceSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleUnboundFromResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleUnboundFromResourceSource), TypeInfoPropertyName = "AuditLogRoleUnboundFromResourceSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogServiceAccountCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogServiceAccountCreatedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogServiceAccountUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogServiceAccountUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogServiceAccountDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogWorkloadIdentityProviderMappingDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogUserAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogUserAddedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogUserUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogUserUpdatedChangesRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogUserDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificateCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificateUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificateDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificatesActivated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificatesDeactivated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorType), TypeInfoPropertyName = "AuditLogActorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorApiKeyType), TypeInfoPropertyName = "AuditLogActorApiKeyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorServiceAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAuditLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAuditLogsResponseObject), TypeInfoPropertyName = "ListAuditLogsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAuditLogsEffectiveAt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogEventType?), TypeInfoPropertyName = "NullableAuditLogEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource?), TypeInfoPropertyName = "NullableAuditLogRoleBoundToResourceSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogRoleUnboundFromResourceSource?), TypeInfoPropertyName = "NullableAuditLogRoleUnboundFromResourceSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorType?), TypeInfoPropertyName = "NullableAuditLogActorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AuditLogActorApiKeyType?), TypeInfoPropertyName = "NullableAuditLogActorApiKeyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAuditLogsResponseObject?), TypeInfoPropertyName = "NullableListAuditLogsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivatedConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivatedConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogCertificatesActivatedCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogCertificatesDeactivatedCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AuditLogEventType>))]
    internal sealed partial class AuditLogsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuditLogsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AuditLogsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AuditLogsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListAuditLogsResponseObject?);
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
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
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
                    0 => new AuditLogsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}