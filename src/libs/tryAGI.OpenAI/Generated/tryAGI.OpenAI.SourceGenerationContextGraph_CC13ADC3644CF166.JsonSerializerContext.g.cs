
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_CC13ADC3644CF166 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_CC13ADC3644CF166 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_CC13ADC3644CF166(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType)

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