
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_99EC89777B7EB0B0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_99EC89777B7EB0B0 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_99EC89777B7EB0B0(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SkillsItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicyJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodyExpiresAfterAnchor)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodyExpiresAfterAnchor?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SkillReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SkillReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodyExpiresAfterAnchor))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateContainerBodyExpiresAfterAnchorJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodyExpiresAfterAnchor?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateContainerBodyExpiresAfterAnchorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateContainerBodySkillDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateContainerBodySkillDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateContainerBodyMemoryLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateContainerBodyMemoryLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateContainerBodyNetworkPolicyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateContainerBodyNetworkPolicyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SkillReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SkillReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SkillReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SkillReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyDisabledParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyDisabledParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyAllowlistParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyAllowlistParamTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_57C01D3546E0935C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_55A1B6E90BD83E29(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ContainerNetworkPolicyAllowlistParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerNetworkPolicyAllowlistParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ContainerNetworkPolicyDisabledParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerNetworkPolicyDisabledParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerNetworkPolicyDomainSecretParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContainerBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateContainerBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateContainerBodyExpiresAfter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContainerBodyExpiresAfterAnchor))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateContainerBodyExpiresAfterAnchor2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateContainerBodyMemoryLimit2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateContainerBodyNetworkPolicyDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateContainerBodyNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateContainerBodySkillDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateContainerBodySkillDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InlineSkillParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineSkillParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillSourceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineSkillSourceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineSkillSourceParamMediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineSkillSourceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_NetworkPolicy2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillReferenceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SkillReferenceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillReferenceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SkillReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillsItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SkillsItem2_3(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerNetworkPolicyAllowlistParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerNetworkPolicyDisabledParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContainerBodyExpiresAfterAnchor?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateContainerBodyExpiresAfterAnchor2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateContainerBodyMemoryLimit2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContainerBodyNetworkPolicyDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateContainerBodyNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContainerBodySkillDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateContainerBodySkillDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInlineSkillParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInlineSkillSourceParamMediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInlineSkillSourceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableNetworkPolicy2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillReferenceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSkillReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillsItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableSkillsItem2_3(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_69576CBB03C474C7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0FAE8B4CE7629F76(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
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