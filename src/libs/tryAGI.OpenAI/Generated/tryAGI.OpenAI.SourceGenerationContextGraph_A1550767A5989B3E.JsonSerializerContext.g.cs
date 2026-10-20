
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_A1550767A5989B3E : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_A1550767A5989B3E Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_A1550767A5989B3E(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamNoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamNoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamClientSecretPostTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamClientSecretPostTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMcpOauthTokenEndpointAuthParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamMcpOauthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamMcpOauthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamStaticBearerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamStaticBearerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamUnrestrictedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamUnrestrictedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamLimitedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamLimitedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamEnvironmentVariableTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamEnvironmentVariableTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateVaultCredentialAuthParamDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthRefreshParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateMcpOauthRefreshParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateMcpOauthTokenEndpointAuthParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateMcpOauthTokenEndpointAuthParamClientSecretBasic(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateMcpOauthTokenEndpointAuthParamClientSecretPost(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateMcpOauthTokenEndpointAuthParamClientSecretPostType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateMcpOauthTokenEndpointAuthParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateMcpOauthTokenEndpointAuthParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateMcpOauthTokenEndpointAuthParamNone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateMcpOauthTokenEndpointAuthParamNoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateVaultCredentialAuthParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateVaultCredentialAuthParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateVaultCredentialAuthParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateVaultCredentialAuthParamEnvironmentVariable(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateVaultCredentialAuthParamEnvironmentVariableType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateVaultCredentialAuthParamMcpOauth(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateVaultCredentialAuthParamMcpOauthType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateVaultCredentialAuthParamStaticBearer(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateVaultCredentialAuthParamStaticBearerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateVaultCredentialParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingParamLimited(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingParamLimitedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingParamUnrestricted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingParamUnrestrictedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateMcpOauthTokenEndpointAuthParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasicType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateMcpOauthTokenEndpointAuthParamClientSecretBasicType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPostType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateMcpOauthTokenEndpointAuthParamClientSecretPostType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateMcpOauthTokenEndpointAuthParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateMcpOauthTokenEndpointAuthParamNoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateVaultCredentialAuthParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateVaultCredentialAuthParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariableType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateVaultCredentialAuthParamEnvironmentVariableType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauthType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateVaultCredentialAuthParamMcpOauthType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearerType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateVaultCredentialAuthParamStaticBearerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialNetworkingParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialNetworkingParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimitedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialNetworkingParamLimitedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestrictedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialNetworkingParamUnrestrictedType2(options);
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