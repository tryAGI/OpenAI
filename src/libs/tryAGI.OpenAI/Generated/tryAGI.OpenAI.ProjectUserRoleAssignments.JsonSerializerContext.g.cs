
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssignedRoleDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssignedRoleDetailsAssignmentSourcesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssignedRoleDetailsAssignmentSourcesVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedRoleAssignmentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PublicAssignOrganizationGroupRoleBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RoleObject), TypeInfoPropertyName = "RoleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RoleListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RoleListResourceObject), TypeInfoPropertyName = "RoleListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssignedRoleDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserObject), TypeInfoPropertyName = "UserObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserUser1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserUser1Object), TypeInfoPropertyName = "UserUser1Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserProjects))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserProjectsObject), TypeInfoPropertyName = "UserProjectsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UserProjectsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserProjectsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserRoleAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserRoleAssignmentObject), TypeInfoPropertyName = "UserRoleAssignmentObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectUserRoleAssignmentsOrder), TypeInfoPropertyName = "ListProjectUserRoleAssignmentsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RoleObject?), TypeInfoPropertyName = "NullableRoleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RoleListResourceObject?), TypeInfoPropertyName = "NullableRoleListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserObject?), TypeInfoPropertyName = "NullableUserObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserUser1Object?), TypeInfoPropertyName = "NullableUserUser1Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserProjectsObject?), TypeInfoPropertyName = "NullableUserProjectsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UserRoleAssignmentObject?), TypeInfoPropertyName = "NullableUserRoleAssignmentObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectUserRoleAssignmentsOrder?), TypeInfoPropertyName = "NullableListProjectUserRoleAssignmentsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AssignedRoleDetailsAssignmentSourcesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AssignedRoleDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UserProjectsDataItem>))]
    internal sealed partial class ProjectUserRoleAssignmentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectUserRoleAssignmentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectUserRoleAssignmentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectUserRoleAssignmentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.RoleObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RoleObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RoleListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RoleListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserUser1Object)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserUser1Object?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserProjectsObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserProjectsObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserRoleAssignmentObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserRoleAssignmentObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectUserRoleAssignmentsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectUserRoleAssignmentsOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.RoleObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RoleObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RoleObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RoleObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RoleListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RoleListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RoleListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RoleListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserUser1Object))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserUser1ObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserUser1Object?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserUser1ObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserProjectsObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserProjectsObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserProjectsObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserProjectsObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserRoleAssignmentObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserRoleAssignmentObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserRoleAssignmentObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserRoleAssignmentObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectUserRoleAssignmentsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListProjectUserRoleAssignmentsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectUserRoleAssignmentsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListProjectUserRoleAssignmentsOrderNullableJsonConverter();
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
                    0 => new ProjectUserRoleAssignmentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}