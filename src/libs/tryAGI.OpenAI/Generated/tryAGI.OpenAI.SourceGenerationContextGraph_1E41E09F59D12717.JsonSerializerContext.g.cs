
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_1E41E09F59D12717 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_1E41E09F59D12717 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_1E41E09F59D12717(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTypeParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTypeParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTypeResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTypeResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentStatusResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentStatusResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PublicEnvironmentResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PublicEnvironmentResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentEnvironmentListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentEnvironmentListResourceObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTypeParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTypeParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTypeParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTypeParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTypeResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTypeResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTypeResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTypeResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentStatusResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentStatusResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentStatusResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentStatusResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceFileIdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceFileIdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceSkillReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceSkillReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PublicEnvironmentResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PublicEnvironmentResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PublicEnvironmentResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PublicEnvironmentResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentEnvironmentListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentEnvironmentListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentEnvironmentListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentEnvironmentListResourceObjectNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_3A4845214B4505E4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_35153BC742C70D83(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_FD87951FB4C7FF61(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PublicEnvironmentResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B699F272C9A2C499(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentEnvironmentListResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentEnvironmentListResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentEnvironmentListResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentEnvironmentListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentStatusResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EnvironmentStatusResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentTypeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EnvironmentTypeParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentTypeResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EnvironmentTypeResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResourceFileId(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResourceFileIdType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResourceInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResourceInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginResourceInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResourceInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReference))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResourceSkillReference(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResourceSkillReferenceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PublicEnvironmentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PublicEnvironmentResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PublicEnvironmentResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PublicEnvironmentResourceObject2(options);
                }
                if (type == typeof(long))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentEnvironmentListResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentEnvironmentListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentStatusResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentStatusResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentTypeParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentTypeParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentTypeResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentTypeResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileResourceFileIdType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedPluginResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedPluginResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedPluginResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillResourceSkillReferenceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PublicEnvironmentResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePublicEnvironmentResourceObject2(options);
                }
                if (type == typeof(long?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5D47DF5648867ADF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5EA93C387ED5A055(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E27D3211C01D8351(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.PublicEnvironmentResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EC8C783C95E47E47(options);
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