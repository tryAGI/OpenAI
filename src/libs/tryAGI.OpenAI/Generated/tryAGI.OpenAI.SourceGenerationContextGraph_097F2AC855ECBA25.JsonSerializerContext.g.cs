
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_097F2AC855ECBA25 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_097F2AC855ECBA25 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_097F2AC855ECBA25(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamClientSecretPostTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamClientSecretPostTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateMcpOauthTokenEndpointAuthParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamMcpOauthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamMcpOauthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamStaticBearerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamStaticBearerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamEnvironmentVariableTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamEnvironmentVariableTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RotateVaultCredentialAuthParamDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(global::tryAGI.OpenAI.RotateMcpOauthRefreshParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateMcpOauthRefreshParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateMcpOauthTokenEndpointAuthParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateMcpOauthTokenEndpointAuthParamClientSecretBasic(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateMcpOauthTokenEndpointAuthParamClientSecretPost(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateMcpOauthTokenEndpointAuthParamClientSecretPostType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateMcpOauthTokenEndpointAuthParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateMcpOauthTokenEndpointAuthParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateVaultCredentialAuthParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateVaultCredentialAuthParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateVaultCredentialAuthParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateVaultCredentialAuthParamEnvironmentVariable(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateVaultCredentialAuthParamEnvironmentVariableType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateVaultCredentialAuthParamMcpOauth(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateVaultCredentialAuthParamMcpOauthType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateVaultCredentialAuthParamStaticBearer(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateVaultCredentialAuthParamStaticBearerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_RotateVaultCredentialParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasicType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRotateMcpOauthTokenEndpointAuthParamClientSecretBasicType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPostType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRotateMcpOauthTokenEndpointAuthParamClientSecretPostType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRotateMcpOauthTokenEndpointAuthParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRotateVaultCredentialAuthParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRotateVaultCredentialAuthParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariableType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRotateVaultCredentialAuthParamEnvironmentVariableType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauthType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRotateVaultCredentialAuthParamMcpOauthType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearerType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRotateVaultCredentialAuthParamStaticBearerType2(options);
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