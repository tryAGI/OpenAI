
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_2A3B3CAF44F5FC80 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_2A3B3CAF44F5FC80 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_2A3B3CAF44F5FC80(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VideoModelJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<byte[], global::tryAGI.OpenAI.ImageRefParam2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VideoSeconds?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
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
                if (type == typeof(byte))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_Byte(options);
                }
                if (type == typeof(byte[]))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ByteArray(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VideoResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C760EDACBB53924B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVideoEditJsonBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CreateVideoEditJsonBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVideoEditMultipartBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CreateVideoEditMultipartBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVideoExtendJsonBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CreateVideoExtendJsonBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVideoExtendMultipartBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CreateVideoExtendMultipartBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVideoJsonBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CreateVideoJsonBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateVideoMultipartBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CreateVideoMultipartBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Error22))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Error22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageRefParam2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageRefParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MisalignmentErrorDetailsResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MisalignmentErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MisalignmentErrorTypeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentSteer))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MisalignmentSteer(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_42376A66744E117B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B67A93BBE0C9F0EA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D382B31D950830BF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoListResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VideoListResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoListResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VideoListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VideoModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoModelEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VideoModelEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoReferenceInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VideoReferenceInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VideoResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VideoResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoSeconds))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VideoSeconds2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VideoSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VideoStatus2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(byte?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableByte(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMisalignmentErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMisalignmentErrorTypeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_8E35991AAD25DB92(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D64AC8D57BC658EE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_EE2CD6FA8332953C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoListResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVideoListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVideoModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoModelEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVideoModelEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVideoResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoSeconds?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVideoSeconds2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVideoSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VideoStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVideoStatus2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VideoResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C5AA4ABD4E12172F(options);
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