
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InviteProjectGroupBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupObject), TypeInfoPropertyName = "ProjectGroupObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupGroupType), TypeInfoPropertyName = "ProjectGroupGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupDeletedResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupDeletedResourceObject), TypeInfoPropertyName = "ProjectGroupDeletedResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupListResourceObject), TypeInfoPropertyName = "ProjectGroupListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType), TypeInfoPropertyName = "MisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum), TypeInfoPropertyName = "MisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectGroupsOrder), TypeInfoPropertyName = "ListProjectGroupsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RetrieveProjectGroupGroupType), TypeInfoPropertyName = "RetrieveProjectGroupGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupObject?), TypeInfoPropertyName = "NullableProjectGroupObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupGroupType?), TypeInfoPropertyName = "NullableProjectGroupGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupDeletedResourceObject?), TypeInfoPropertyName = "NullableProjectGroupDeletedResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectGroupListResourceObject?), TypeInfoPropertyName = "NullableProjectGroupListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType?), TypeInfoPropertyName = "NullableMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectGroupsOrder?), TypeInfoPropertyName = "NullableListProjectGroupsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RetrieveProjectGroupGroupType?), TypeInfoPropertyName = "NullableRetrieveProjectGroupGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectGroup>))]
    internal sealed partial class ProjectGroupsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectGroupsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectGroupsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectGroupsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.Error, string>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupGroupType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupGroupType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupDeletedResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupDeletedResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectGroupsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectGroupsOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RetrieveProjectGroupGroupType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RetrieveProjectGroupGroupType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectGroupObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectGroupObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupGroupType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectGroupGroupTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupGroupType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectGroupGroupTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupDeletedResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectGroupDeletedResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupDeletedResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectGroupDeletedResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectGroupListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectGroupListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectGroupListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectGroupsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListProjectGroupsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectGroupsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListProjectGroupsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RetrieveProjectGroupGroupType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RetrieveProjectGroupGroupTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RetrieveProjectGroupGroupType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RetrieveProjectGroupGroupTypeNullableJsonConverter();
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
                    0 => new ProjectGroupsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}