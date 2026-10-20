
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_ED0BBD5AE8CB0D66 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_ED0BBD5AE8CB0D66 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_ED0BBD5AE8CB0D66(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.InviteObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InviteObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InviteRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InviteRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InviteStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InviteStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InviteProjectRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InviteProjectRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InviteListResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InviteListResponseObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.InviteObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InviteObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InviteObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InviteObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InviteRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InviteRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InviteRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InviteRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InviteStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InviteStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InviteStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InviteStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InviteProjectRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InviteProjectRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InviteProjectRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InviteProjectRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InviteListResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InviteListResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InviteListResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InviteListResponseObjectNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Invite>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B4168BC4EE6E3139(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteProject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_281B2B787632DC6F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Invite))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Invite(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InviteListResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InviteListResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InviteListResponseObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InviteListResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InviteObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InviteObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InviteProject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InviteProject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InviteProjectRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InviteProjectRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InviteRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InviteRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InviteStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InviteStatus2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InviteListResponseObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInviteListResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InviteObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInviteObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InviteProjectRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInviteProjectRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InviteRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInviteRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InviteStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInviteStatus2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Invite>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2633A50C82739634(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InviteProject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_FE22969BCB94289A(options);
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