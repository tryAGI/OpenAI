
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateGroupUserBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupMemberUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupMemberUserUserType), TypeInfoPropertyName = "GroupMemberUserUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupUserAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupUserAssignmentObject), TypeInfoPropertyName = "GroupUserAssignmentObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupUserDeletedResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupUserDeletedResourceObject), TypeInfoPropertyName = "GroupUserDeletedResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserListResourceObject), TypeInfoPropertyName = "UserListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListGroupUsersOrder), TypeInfoPropertyName = "ListGroupUsersOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupMemberUserUserType?), TypeInfoPropertyName = "NullableGroupMemberUserUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupUserAssignmentObject?), TypeInfoPropertyName = "NullableGroupUserAssignmentObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GroupUserDeletedResourceObject?), TypeInfoPropertyName = "NullableGroupUserDeletedResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserListResourceObject?), TypeInfoPropertyName = "NullableUserListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListGroupUsersOrder?), TypeInfoPropertyName = "NullableListGroupUsersOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.GroupUser>))]
    internal sealed partial class GroupUsersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GroupUsersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GroupUsersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GroupUsersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.GroupMemberUserUserType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GroupMemberUserUserType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GroupUserAssignmentObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GroupUserAssignmentObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GroupUserDeletedResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GroupUserDeletedResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListGroupUsersOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListGroupUsersOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.GroupMemberUserUserType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GroupMemberUserUserTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GroupMemberUserUserType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GroupMemberUserUserTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GroupUserAssignmentObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GroupUserAssignmentObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GroupUserAssignmentObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GroupUserAssignmentObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GroupUserDeletedResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GroupUserDeletedResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GroupUserDeletedResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GroupUserDeletedResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListGroupUsersOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListGroupUsersOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListGroupUsersOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListGroupUsersOrderNullableJsonConverter();
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
                    0 => new GroupUsersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}