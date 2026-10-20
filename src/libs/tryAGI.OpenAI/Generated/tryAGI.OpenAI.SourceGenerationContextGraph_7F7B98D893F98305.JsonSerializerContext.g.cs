
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_7F7B98D893F98305 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_7F7B98D893F98305 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_7F7B98D893F98305(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NetworkAccessParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NetworkAccessParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamSkillReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamSkillReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64MediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64MediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamFileIdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamFileIdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_16FADF073CF5508D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_570D214C9DAAFB74(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C5B170C97F2CD10B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_014ADB54F81B220E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DesktopParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DesktopParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentPackagesParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EnvironmentPackagesParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParamFileId(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParamFileIdType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParamInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParamInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParamInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginParamInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginParamInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParamInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParamInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReference))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParamSkillReference(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParamSkillReferenceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineCapabilitySourceParamBase64(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineCapabilitySourceParamBase64MediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineCapabilitySourceParamBase64Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkAccessParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_NetworkAccessParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicyParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_NetworkPolicyParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SetupCommandParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SetupCommandParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UpdateEnvironmentTemplateParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_UpdateEnvironmentTemplateParams(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileParamFileIdType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileParamInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedPluginParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedPluginParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedPluginParamInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillParamInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillParamSkillReferenceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInlineCapabilitySourceParamBase64MediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInlineCapabilitySourceParamBase64Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkAccessParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableNetworkAccessParam2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C0598021B65A2040(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D8E6CD18752D4032(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_ECB76628EE8F6046(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SetupCommandParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2690B46C57642571(options);
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