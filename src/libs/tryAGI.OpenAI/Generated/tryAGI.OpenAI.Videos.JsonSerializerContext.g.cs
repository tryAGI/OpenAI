
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrderEnum), TypeInfoPropertyName = "OrderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoModel), TypeInfoPropertyName = "VideoModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoModelEnum), TypeInfoPropertyName = "VideoModelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoStatus), TypeInfoPropertyName = "VideoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoSize), TypeInfoPropertyName = "VideoSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoResourceObject), TypeInfoPropertyName = "VideoResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoListResourceObject), TypeInfoPropertyName = "VideoListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VideoResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageRefParam2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoSeconds), TypeInfoPropertyName = "VideoSeconds2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoMultipartBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>), TypeInfoPropertyName = "OneOfByteArrayImageRefParam22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoJsonBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoCharacterBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoCharacterResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoReferenceInputParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoEditMultipartBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>), TypeInfoPropertyName = "OneOfByteArrayVideoReferenceInputParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoEditJsonBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoExtendMultipartBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>), TypeInfoPropertyName = "OneOfVideoReferenceInputParamByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoExtendJsonBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedVideoResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedVideoResourceObject), TypeInfoPropertyName = "DeletedVideoResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoContentVariant), TypeInfoPropertyName = "VideoContentVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVideoRemixBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrderEnum?), TypeInfoPropertyName = "NullableOrderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoModel?), TypeInfoPropertyName = "NullableVideoModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoModelEnum?), TypeInfoPropertyName = "NullableVideoModelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoStatus?), TypeInfoPropertyName = "NullableVideoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoSize?), TypeInfoPropertyName = "NullableVideoSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoResourceObject?), TypeInfoPropertyName = "NullableVideoResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoListResourceObject?), TypeInfoPropertyName = "NullableVideoListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoSeconds?), TypeInfoPropertyName = "NullableVideoSeconds2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>?), TypeInfoPropertyName = "NullableOneOfByteArrayImageRefParam22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>?), TypeInfoPropertyName = "NullableOneOfByteArrayVideoReferenceInputParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>?), TypeInfoPropertyName = "NullableOneOfVideoReferenceInputParamByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedVideoResourceObject?), TypeInfoPropertyName = "NullableDeletedVideoResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VideoContentVariant?), TypeInfoPropertyName = "NullableVideoContentVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VideoResource>))]
    internal sealed partial class VideosSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideosSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VideosSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VideosSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VideoModelJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<byte[], global::tryAGI.OpenAI.ImageRefParam2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.OrderEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrderEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoModelEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoModelEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoSeconds)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoSeconds?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedVideoResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedVideoResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoContentVariant)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoContentVariant?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrderEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrderEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrderEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrderEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoModelEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoModelEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoModelEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoModelEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoSeconds))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoSecondsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoSeconds?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoSecondsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedVideoResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedVideoResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedVideoResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedVideoResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoContentVariant))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoContentVariantJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VideoContentVariant?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VideoContentVariantNullableJsonConverter();
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
                    0 => new VideosSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}