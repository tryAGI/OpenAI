
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AddUploadPartRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompleteUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileExpirationAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateUploadRequestPurpose), TypeInfoPropertyName = "CreateUploadRequestPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileExpirationAfterAnchor), TypeInfoPropertyName = "FileExpirationAfterAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OpenAIFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OpenAIFileObject), TypeInfoPropertyName = "OpenAIFileObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OpenAIFilePurpose), TypeInfoPropertyName = "OpenAIFilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OpenAIFileStatus), TypeInfoPropertyName = "OpenAIFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Upload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadStatus), TypeInfoPropertyName = "UploadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadObject), TypeInfoPropertyName = "UploadObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.OpenAIFile, object>), TypeInfoPropertyName = "AllOfOpenAIFileObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadPartObject), TypeInfoPropertyName = "UploadPartObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateUploadRequestPurpose?), TypeInfoPropertyName = "NullableCreateUploadRequestPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileExpirationAfterAnchor?), TypeInfoPropertyName = "NullableFileExpirationAfterAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OpenAIFileObject?), TypeInfoPropertyName = "NullableOpenAIFileObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OpenAIFilePurpose?), TypeInfoPropertyName = "NullableOpenAIFilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OpenAIFileStatus?), TypeInfoPropertyName = "NullableOpenAIFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadStatus?), TypeInfoPropertyName = "NullableUploadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadObject?), TypeInfoPropertyName = "NullableUploadObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.OpenAIFile, object>?), TypeInfoPropertyName = "NullableAllOfOpenAIFileObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadPartObject?), TypeInfoPropertyName = "NullableUploadPartObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class UploadsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UploadsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UploadsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UploadsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.OpenAIFile, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateUploadRequestPurpose)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateUploadRequestPurpose?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileExpirationAfterAnchor)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileExpirationAfterAnchor?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OpenAIFileObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OpenAIFileObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OpenAIFilePurpose)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OpenAIFilePurpose?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OpenAIFileStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OpenAIFileStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UploadStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UploadStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UploadObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UploadObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UploadPartObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UploadPartObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateUploadRequestPurpose))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateUploadRequestPurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateUploadRequestPurpose?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateUploadRequestPurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileExpirationAfterAnchor))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileExpirationAfterAnchorJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileExpirationAfterAnchor?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileExpirationAfterAnchorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OpenAIFileObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OpenAIFileObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OpenAIFileObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OpenAIFileObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OpenAIFilePurpose))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OpenAIFilePurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OpenAIFilePurpose?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OpenAIFilePurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OpenAIFileStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OpenAIFileStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OpenAIFileStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OpenAIFileStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UploadStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UploadStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UploadStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UploadStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UploadObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UploadObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UploadObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UploadObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UploadPartObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UploadPartObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UploadPartObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UploadPartObjectNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
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
                    0 => new UploadsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}