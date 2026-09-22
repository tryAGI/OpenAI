
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PermissionErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string>), TypeInfoPropertyName = "AnyOfErrorString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectObject), TypeInfoPropertyName = "ProjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PublicProjectResidency), TypeInfoPropertyName = "PublicProjectResidency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyObject), TypeInfoPropertyName = "ProjectApiKeyObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerProjectAccess), TypeInfoPropertyName = "ProjectApiKeyOwnerProjectAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerType), TypeInfoPropertyName = "ProjectApiKeyOwnerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerServiceAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyDeleteResponseObject), TypeInfoPropertyName = "ProjectApiKeyDeleteResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyListResponseObject), TypeInfoPropertyName = "ProjectApiKeyListResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectListResponseObject), TypeInfoPropertyName = "ProjectListResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectModelPermissions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectModelPermissionsObject), TypeInfoPropertyName = "ProjectModelPermissionsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectModelPermissionsMode), TypeInfoPropertyName = "ProjectModelPermissionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponseObject), TypeInfoPropertyName = "ProjectModelPermissionsDeleteResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode), TypeInfoPropertyName = "ProjectModelPermissionsUpdateRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectRateLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectRateLimitObject), TypeInfoPropertyName = "ProjectRateLimitObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectRateLimitListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectRateLimitListResponseObject), TypeInfoPropertyName = "ProjectRateLimitListResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountObject), TypeInfoPropertyName = "ProjectServiceAccountObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountRole), TypeInfoPropertyName = "ProjectServiceAccountRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountApiKeyObject), TypeInfoPropertyName = "ProjectServiceAccountApiKeyObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseObject), TypeInfoPropertyName = "ProjectServiceAccountCreateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseRole), TypeInfoPropertyName = "ProjectServiceAccountCreateResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponseObject), TypeInfoPropertyName = "ProjectServiceAccountDeleteResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountListResponseObject), TypeInfoPropertyName = "ProjectServiceAccountListResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectServiceAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserObject), TypeInfoPropertyName = "ProjectUserObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserDeleteResponseObject), TypeInfoPropertyName = "ProjectUserDeleteResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateProjectServiceAccountBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole), TypeInfoPropertyName = "UpdateProjectServiceAccountBodyRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType), TypeInfoPropertyName = "MisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum), TypeInfoPropertyName = "MisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectApiKeysOwnerProjectAccess), TypeInfoPropertyName = "ListProjectApiKeysOwnerProjectAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string>?), TypeInfoPropertyName = "NullableAnyOfErrorString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectObject?), TypeInfoPropertyName = "NullableProjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PublicProjectResidency?), TypeInfoPropertyName = "NullablePublicProjectResidency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyObject?), TypeInfoPropertyName = "NullableProjectApiKeyObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerProjectAccess?), TypeInfoPropertyName = "NullableProjectApiKeyOwnerProjectAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerType?), TypeInfoPropertyName = "NullableProjectApiKeyOwnerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyDeleteResponseObject?), TypeInfoPropertyName = "NullableProjectApiKeyDeleteResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectApiKeyListResponseObject?), TypeInfoPropertyName = "NullableProjectApiKeyListResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectListResponseObject?), TypeInfoPropertyName = "NullableProjectListResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectModelPermissionsObject?), TypeInfoPropertyName = "NullableProjectModelPermissionsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectModelPermissionsMode?), TypeInfoPropertyName = "NullableProjectModelPermissionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponseObject?), TypeInfoPropertyName = "NullableProjectModelPermissionsDeleteResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode?), TypeInfoPropertyName = "NullableProjectModelPermissionsUpdateRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectRateLimitObject?), TypeInfoPropertyName = "NullableProjectRateLimitObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectRateLimitListResponseObject?), TypeInfoPropertyName = "NullableProjectRateLimitListResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountObject?), TypeInfoPropertyName = "NullableProjectServiceAccountObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountRole?), TypeInfoPropertyName = "NullableProjectServiceAccountRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountApiKeyObject?), TypeInfoPropertyName = "NullableProjectServiceAccountApiKeyObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseObject?), TypeInfoPropertyName = "NullableProjectServiceAccountCreateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseRole?), TypeInfoPropertyName = "NullableProjectServiceAccountCreateResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponseObject?), TypeInfoPropertyName = "NullableProjectServiceAccountDeleteResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectServiceAccountListResponseObject?), TypeInfoPropertyName = "NullableProjectServiceAccountListResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserObject?), TypeInfoPropertyName = "NullableProjectUserObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectUserDeleteResponseObject?), TypeInfoPropertyName = "NullableProjectUserDeleteResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole?), TypeInfoPropertyName = "NullableUpdateProjectServiceAccountBodyRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType?), TypeInfoPropertyName = "NullableMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectApiKeysOwnerProjectAccess?), TypeInfoPropertyName = "NullableListProjectApiKeysOwnerProjectAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectRateLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectServiceAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectUser>))]
    internal sealed partial class ProjectsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.ProjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerProjectAccess)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerProjectAccess?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyDeleteResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyDeleteResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyListResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyListResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectListResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectListResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectRateLimitObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectRateLimitObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectRateLimitListResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectRateLimitListResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountApiKeyObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountApiKeyObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountListResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountListResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectUserObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectUserObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectUserDeleteResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectUserDeleteResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PublicProjectResidency)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PublicProjectResidency?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectApiKeysOwnerProjectAccess)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectApiKeysOwnerProjectAccess?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerProjectAccess))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyOwnerProjectAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerProjectAccess?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyOwnerProjectAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyOwnerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyOwnerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyOwnerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyDeleteResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyDeleteResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyDeleteResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyDeleteResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyListResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyListResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectApiKeyListResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectApiKeyListResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectListResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectListResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectListResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectListResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectModelPermissionsObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectModelPermissionsObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectModelPermissionsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectModelPermissionsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectModelPermissionsDeleteResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectModelPermissionsDeleteResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectModelPermissionsUpdateRequestModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectModelPermissionsUpdateRequestModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectRateLimitObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectRateLimitObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectRateLimitObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectRateLimitObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectRateLimitListResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectRateLimitListResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectRateLimitListResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectRateLimitListResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountApiKeyObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountApiKeyObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountApiKeyObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountApiKeyObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountCreateResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountCreateResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountCreateResponseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountCreateResponseRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountCreateResponseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountDeleteResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountDeleteResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountDeleteResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountListResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountListResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectServiceAccountListResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountListResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectUserObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectUserObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectUserObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectUserObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectUserDeleteResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectUserDeleteResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectUserDeleteResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectUserDeleteResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UpdateProjectServiceAccountBodyRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UpdateProjectServiceAccountBodyRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PublicProjectResidency))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PublicProjectResidencyJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PublicProjectResidency?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PublicProjectResidencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectApiKeysOwnerProjectAccess))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListProjectApiKeysOwnerProjectAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectApiKeysOwnerProjectAccess?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListProjectApiKeysOwnerProjectAccessNullableJsonConverter();
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
                    0 => new ProjectsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}