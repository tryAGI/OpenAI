
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Certificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CertificateObject), TypeInfoPropertyName = "CertificateObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CertificateCertificateDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteCertificateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteCertificateResponseObject), TypeInfoPropertyName = "DeleteCertificateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListCertificatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationCertificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListCertificatesResponseObject), TypeInfoPropertyName = "ListCertificatesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectCertificatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationProjectCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationProjectCertificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectCertificatesResponseObject), TypeInfoPropertyName = "ListProjectCertificatesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModifyCertificateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationCertificateObject), TypeInfoPropertyName = "OrganizationCertificateObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationCertificateCertificateDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationCertificateActivationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationCertificateActivationResponseObject), TypeInfoPropertyName = "OrganizationCertificateActivationResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponseObject), TypeInfoPropertyName = "OrganizationCertificateDeactivationResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateObject), TypeInfoPropertyName = "OrganizationProjectCertificateObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateCertificateDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponseObject), TypeInfoPropertyName = "OrganizationProjectCertificateActivationResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponseObject), TypeInfoPropertyName = "OrganizationProjectCertificateDeactivationResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PermissionErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string>), TypeInfoPropertyName = "AnyOfErrorString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToggleCertificatesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UploadCertificateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType), TypeInfoPropertyName = "MisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum), TypeInfoPropertyName = "MisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListOrganizationCertificatesOrder), TypeInfoPropertyName = "ListOrganizationCertificatesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetCertificateIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetCertificateIncludeItem), TypeInfoPropertyName = "GetCertificateIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectCertificatesOrder), TypeInfoPropertyName = "ListProjectCertificatesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CertificateObject?), TypeInfoPropertyName = "NullableCertificateObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteCertificateResponseObject?), TypeInfoPropertyName = "NullableDeleteCertificateResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListCertificatesResponseObject?), TypeInfoPropertyName = "NullableListCertificatesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectCertificatesResponseObject?), TypeInfoPropertyName = "NullableListProjectCertificatesResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationCertificateObject?), TypeInfoPropertyName = "NullableOrganizationCertificateObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationCertificateActivationResponseObject?), TypeInfoPropertyName = "NullableOrganizationCertificateActivationResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponseObject?), TypeInfoPropertyName = "NullableOrganizationCertificateDeactivationResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateObject?), TypeInfoPropertyName = "NullableOrganizationProjectCertificateObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponseObject?), TypeInfoPropertyName = "NullableOrganizationProjectCertificateActivationResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponseObject?), TypeInfoPropertyName = "NullableOrganizationProjectCertificateDeactivationResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string>?), TypeInfoPropertyName = "NullableAnyOfErrorString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType?), TypeInfoPropertyName = "NullableMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListOrganizationCertificatesOrder?), TypeInfoPropertyName = "NullableListOrganizationCertificatesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GetCertificateIncludeItem?), TypeInfoPropertyName = "NullableGetCertificateIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectCertificatesOrder?), TypeInfoPropertyName = "NullableListProjectCertificatesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OrganizationCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OrganizationProjectCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.GetCertificateIncludeItem>))]
    internal sealed partial class CertificatesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CertificatesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CertificatesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CertificatesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CertificateObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CertificateObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteCertificateResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteCertificateResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListCertificatesResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListCertificatesResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectCertificatesResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectCertificatesResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationCertificateObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationCertificateObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationCertificateActivationResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationCertificateActivationResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListOrganizationCertificatesOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListOrganizationCertificatesOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GetCertificateIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GetCertificateIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectCertificatesOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectCertificatesOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CertificateObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CertificateObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CertificateObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CertificateObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteCertificateResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteCertificateResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteCertificateResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteCertificateResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListCertificatesResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListCertificatesResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListCertificatesResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListCertificatesResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectCertificatesResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListProjectCertificatesResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectCertificatesResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListProjectCertificatesResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationCertificateObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationCertificateObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationCertificateObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationCertificateObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationCertificateActivationResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationCertificateActivationResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationCertificateActivationResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationCertificateActivationResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationCertificateDeactivationResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationCertificateDeactivationResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationCertificateDeactivationResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationProjectCertificateObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationProjectCertificateObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationProjectCertificateActivationResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateActivationResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationProjectCertificateActivationResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationProjectCertificateDeactivationResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationProjectCertificateDeactivationResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListOrganizationCertificatesOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListOrganizationCertificatesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListOrganizationCertificatesOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListOrganizationCertificatesOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GetCertificateIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GetCertificateIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GetCertificateIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GetCertificateIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectCertificatesOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListProjectCertificatesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectCertificatesOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListProjectCertificatesOrderNullableJsonConverter();
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
                    0 => new CertificatesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}