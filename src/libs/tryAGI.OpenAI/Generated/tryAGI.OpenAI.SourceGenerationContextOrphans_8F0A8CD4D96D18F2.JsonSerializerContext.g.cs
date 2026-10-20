
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_8F0A8CD4D96D18F2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_8F0A8CD4D96D18F2 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_8F0A8CD4D96D18F2(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamInputFidelityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamInputFidelityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamModerationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamModerationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EditImageBodyJsonParamBackgroundNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ImageRefParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_67BB46000EC013B9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_99D56EECC1DA046C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_DDE0DF7ADAB5C304(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EditImageBodyJsonParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EditImageBodyJsonParamBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EditImageBodyJsonParamInputFidelity2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EditImageBodyJsonParamModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EditImageBodyJsonParamModeration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EditImageBodyJsonParamOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EditImageBodyJsonParamQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EditImageBodyJsonParamSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageRefParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageRefParam(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_244D43125C50CE9C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_185FECB5F3FFCAC2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamBackground?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEditImageBodyJsonParamBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEditImageBodyJsonParamInputFidelity2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEditImageBodyJsonParamModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamModeration?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEditImageBodyJsonParamModeration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEditImageBodyJsonParamOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamQuality?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEditImageBodyJsonParamQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EditImageBodyJsonParamSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEditImageBodyJsonParamSize2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ImageRefParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9C21FB38382F35B3(options);
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