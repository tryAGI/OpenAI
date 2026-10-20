
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_E27D179222749DD6 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_E27D179222749DD6 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_E27D179222749DD6(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Provider2JsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ExternalStorageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ExternalStorageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ExternalStorageResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ExternalStorageResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AwsExternalStorageProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AwsExternalStorageProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AzureExternalStorageProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AzureExternalStorageProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GcpExternalStorageProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GcpExternalStorageProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OciExternalStorageProviderResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OciExternalStorageProviderResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ExternalStorageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ExternalStorageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ExternalStorageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ExternalStorageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ExternalStorageResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ExternalStorageResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ExternalStorageResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ExternalStorageResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ExternalStorageResponseProviderDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ExternalStorageResponseProviderDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AwsExternalStorageProviderResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AwsExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AzureExternalStorageProviderResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AzureExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ExternalStorageResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ExternalStorageResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ExternalStorageResponseObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ExternalStorageResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ExternalStorageResponseProviderDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ExternalStorageResponseProviderDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ExternalStorageStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ExternalStorageStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_GcpExternalStorageProviderResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_GcpExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OciExternalStorageProviderResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OciExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Provider2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Provider22(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAwsExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAzureExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ExternalStorageResponseObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableExternalStorageResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableExternalStorageResponseProviderDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ExternalStorageStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableExternalStorageStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGcpExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOciExternalStorageProviderResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Provider2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProvider22(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
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