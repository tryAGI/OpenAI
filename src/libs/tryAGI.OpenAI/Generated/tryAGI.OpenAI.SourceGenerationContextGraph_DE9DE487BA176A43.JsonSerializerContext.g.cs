
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_DE9DE487BA176A43 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_DE9DE487BA176A43 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_DE9DE487BA176A43(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialListResourceObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceNoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceNoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceClientSecretBasicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceClientSecretBasicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceClientSecretPostTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceClientSecretPostTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpOauthTokenEndpointAuthResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceMcpOauthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceMcpOauthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceStaticBearerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceStaticBearerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceUnrestrictedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceUnrestrictedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceLimitedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceLimitedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialNetworkingResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceEnvironmentVariableTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceEnvironmentVariableTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialAuthResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VaultCredentialListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VaultCredentialListResourceObjectNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultCredentialResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_1E595466037D38FA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::System.DateTimeOffset))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_DateTimeOffset(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthRefreshResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpOauthRefreshResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpOauthTokenEndpointAuthResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpOauthTokenEndpointAuthResourceClientSecretBasic(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpOauthTokenEndpointAuthResourceClientSecretBasicType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpOauthTokenEndpointAuthResourceClientSecretPost(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpOauthTokenEndpointAuthResourceClientSecretPostType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpOauthTokenEndpointAuthResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpOauthTokenEndpointAuthResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpOauthTokenEndpointAuthResourceNone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpOauthTokenEndpointAuthResourceNoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialAuthResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialAuthResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialAuthResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialAuthResourceEnvironmentVariable(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialAuthResourceEnvironmentVariableType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialAuthResourceMcpOauth(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialAuthResourceMcpOauthType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialAuthResourceStaticBearer(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialAuthResourceStaticBearerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialListResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialListResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialListResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingResourceLimited(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingResourceLimitedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingResourceUnrestricted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialNetworkingResourceUnrestrictedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VaultCredentialResourceObject2(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::System.DateTimeOffset?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDateTimeOffset(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpOauthTokenEndpointAuthResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasicType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpOauthTokenEndpointAuthResourceClientSecretBasicType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPostType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpOauthTokenEndpointAuthResourceClientSecretPostType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpOauthTokenEndpointAuthResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpOauthTokenEndpointAuthResourceNoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialAuthResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialAuthResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariableType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialAuthResourceEnvironmentVariableType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauthType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialAuthResourceMcpOauthType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearerType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialAuthResourceStaticBearerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialListResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialNetworkingResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialNetworkingResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimitedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialNetworkingResourceLimitedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestrictedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialNetworkingResourceUnrestrictedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VaultCredentialResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVaultCredentialResourceObject2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VaultCredentialResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AE6D6E1814022439(options);
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