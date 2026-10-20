
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_37DAE5B2DE327ACC : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_37DAE5B2DE327ACC Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_37DAE5B2DE327ACC(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Provider3JsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderParamsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderParamsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AwsExternalStorageProviderParamsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AwsExternalStorageProviderParamsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AzureExternalStorageProviderParamsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AzureExternalStorageProviderParamsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GcpExternalStorageProviderParamsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GcpExternalStorageProviderParamsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderParamsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OciExternalStorageProviderParamsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderParamsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OciExternalStorageProviderParamsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateExternalStorageBodyProviderDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateExternalStorageBodyProviderDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AwsExternalStorageProviderParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AwsExternalStorageProviderParamsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AzureExternalStorageProviderParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AzureExternalStorageProviderParamsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateExternalStorageBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CreateExternalStorageBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CreateExternalStorageBodyProviderDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CreateExternalStorageBodyProviderDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_GcpExternalStorageProviderParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_GcpExternalStorageProviderParamsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OciExternalStorageProviderParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderParamsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OciExternalStorageProviderParamsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Provider3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Provider32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAwsExternalStorageProviderParamsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAzureExternalStorageProviderParamsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateExternalStorageBodyProviderDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGcpExternalStorageProviderParamsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderParamsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOciExternalStorageProviderParamsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Provider3?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProvider32(options);
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