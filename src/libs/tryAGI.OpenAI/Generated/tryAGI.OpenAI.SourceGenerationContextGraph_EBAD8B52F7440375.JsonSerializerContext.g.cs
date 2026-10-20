
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_EBAD8B52F7440375 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_EBAD8B52F7440375 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_EBAD8B52F7440375(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NetworkAccessResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NetworkAccessResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceSkillReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceSkillReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceFileIdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceFileIdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTemplateResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTemplateResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTemplateListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTemplateListResourceObjectNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentTemplateResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_7830993E4F3DBCE1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_35153BC742C70D83(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateFileResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_DA71F1F92F7B942D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateSkillResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_1B1F40BBC1DA005F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::System.DateTimeOffset))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_DateTimeOffset(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DesktopResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_DesktopResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentPackagesResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentPackagesResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentTemplateListResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentTemplateListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentTemplateResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentTemplateResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentTemplateResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentTemplateResourceObject2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateFileResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateFileResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateFileResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateFileResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileId))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateFileResourceFileId(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateFileResourceFileIdType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateFileResourceInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateFileResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateSkillResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateSkillResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateSkillResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateSkillResourceInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateSkillResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateSkillResourceSkillReference(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_HostedTemplateSkillResourceSkillReferenceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkAccessResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NetworkAccessResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicyResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NetworkPolicyResource(options);
                }
                if (type == typeof(long))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::System.DateTimeOffset?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDateTimeOffset(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentTemplateListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentTemplateResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentTemplateResourceObject2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateFileResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedTemplateFileResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedTemplateFileResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedTemplateFileResourceFileIdType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedTemplateFileResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedTemplateSkillResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedTemplateSkillResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedTemplateSkillResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedTemplateSkillResourceSkillReferenceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkAccessResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableNetworkAccessResource2(options);
                }
                if (type == typeof(long?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EnvironmentTemplateResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_81A89E661E3414C3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5EA93C387ED5A055(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedTemplateFileResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9A9F5869545F3A44(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedTemplateSkillResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_33D588E2690B9F66(options);
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