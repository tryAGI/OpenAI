
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_905D45827CCD54AE : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_905D45827CCD54AE Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_905D45827CCD54AE(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AgentContentResourceJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.SubagentObjectResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SubagentObjectResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SubagentStatusResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SubagentStatusResource?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.SubagentObjectResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SubagentObjectResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SubagentObjectResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SubagentObjectResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputTextResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputTextResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EncryptedContentResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EncryptedContentResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentContentResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentContentResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SubagentStatusResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SubagentStatusResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SubagentStatusResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SubagentStatusResourceNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BA79033F863F8AED(options);
                }
                if (type == typeof(global::System.DateTimeOffset))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_DateTimeOffset(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentContentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentContentResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentContentResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AgentContentResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EncryptedContentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EncryptedContentResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EncryptedContentResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OutputTextResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OutputTextResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SubagentObjectResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SubagentObjectResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SubagentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SubagentResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SubagentStatusResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SubagentStatusResource2(options);
                }
                if (type == typeof(global::System.DateTimeOffset?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDateTimeOffset(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentContentResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentContentResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentContentResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEncryptedContentResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputTextResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SubagentObjectResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSubagentObjectResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SubagentStatusResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSubagentStatusResource2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentContentResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A6E82A8FAB805418(options);
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