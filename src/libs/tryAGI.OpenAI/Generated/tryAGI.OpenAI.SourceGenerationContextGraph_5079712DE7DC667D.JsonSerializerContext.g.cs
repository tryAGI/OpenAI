
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_5079712DE7DC667D : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_5079712DE7DC667D Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_5079712DE7DC667D(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.StatusJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.ActiveStatusType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ActiveStatusType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LockedStatusType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LockedStatusType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClosedStatusType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClosedStatusType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadResourceStatusDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadResourceStatusDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ActiveStatusType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ActiveStatusTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ActiveStatusType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ActiveStatusTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LockedStatusType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LockedStatusTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LockedStatusType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LockedStatusTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClosedStatusType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClosedStatusTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClosedStatusType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClosedStatusTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadResourceStatusDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadResourceStatusDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadResourceStatusDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadResourceStatusDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(global::tryAGI.OpenAI.ActiveStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ActiveStatus(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ActiveStatusType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ActiveStatusType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClosedStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ClosedStatus(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClosedStatusType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ClosedStatusType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LockedStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LockedStatus(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LockedStatusType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LockedStatusType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Status))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Status2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadResourceStatusDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadResourceStatusDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadResourceStatusDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadResourceStatusDiscriminatorType2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ActiveStatusType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableActiveStatusType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClosedStatusType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableClosedStatusType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LockedStatusType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLockedStatusType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Status?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableThreadResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadResourceStatusDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableThreadResourceStatusDiscriminatorType2(options);
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