
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpendAlertBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency), TypeInfoPropertyName = "CreateSpendAlertBodyCurrency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpendAlertBodyInterval), TypeInfoPropertyName = "CreateSpendAlertBodyInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpendAlertNotificationChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlertObject), TypeInfoPropertyName = "OrganizationSpendAlertObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlertCurrency), TypeInfoPropertyName = "OrganizationSpendAlertCurrency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlertInterval), TypeInfoPropertyName = "OrganizationSpendAlertInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResourceObject), TypeInfoPropertyName = "OrganizationSpendAlertDeletedResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlertListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlertListResourceObject), TypeInfoPropertyName = "OrganizationSpendAlertListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationSpendAlert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PermissionErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string>), TypeInfoPropertyName = "AnyOfErrorString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlertObject), TypeInfoPropertyName = "ProjectSpendAlertObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlertCurrency), TypeInfoPropertyName = "ProjectSpendAlertCurrency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlertInterval), TypeInfoPropertyName = "ProjectSpendAlertInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlertDeletedResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlertDeletedResourceObject), TypeInfoPropertyName = "ProjectSpendAlertDeletedResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlertListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlertListResourceObject), TypeInfoPropertyName = "ProjectSpendAlertListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectSpendAlert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpendAlertNotificationChannelType), TypeInfoPropertyName = "SpendAlertNotificationChannelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType), TypeInfoPropertyName = "MisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum), TypeInfoPropertyName = "MisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectSpendAlertsOrder), TypeInfoPropertyName = "ListProjectSpendAlertsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListOrganizationSpendAlertsOrder), TypeInfoPropertyName = "ListOrganizationSpendAlertsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency?), TypeInfoPropertyName = "NullableCreateSpendAlertBodyCurrency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSpendAlertBodyInterval?), TypeInfoPropertyName = "NullableCreateSpendAlertBodyInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlertObject?), TypeInfoPropertyName = "NullableOrganizationSpendAlertObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlertCurrency?), TypeInfoPropertyName = "NullableOrganizationSpendAlertCurrency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlertInterval?), TypeInfoPropertyName = "NullableOrganizationSpendAlertInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResourceObject?), TypeInfoPropertyName = "NullableOrganizationSpendAlertDeletedResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OrganizationSpendAlertListResourceObject?), TypeInfoPropertyName = "NullableOrganizationSpendAlertListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Error, string>?), TypeInfoPropertyName = "NullableAnyOfErrorString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlertObject?), TypeInfoPropertyName = "NullableProjectSpendAlertObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlertCurrency?), TypeInfoPropertyName = "NullableProjectSpendAlertCurrency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlertInterval?), TypeInfoPropertyName = "NullableProjectSpendAlertInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlertDeletedResourceObject?), TypeInfoPropertyName = "NullableProjectSpendAlertDeletedResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProjectSpendAlertListResourceObject?), TypeInfoPropertyName = "NullableProjectSpendAlertListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpendAlertNotificationChannelType?), TypeInfoPropertyName = "NullableSpendAlertNotificationChannelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType?), TypeInfoPropertyName = "NullableMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListProjectSpendAlertsOrder?), TypeInfoPropertyName = "NullableListProjectSpendAlertsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListOrganizationSpendAlertsOrder?), TypeInfoPropertyName = "NullableListOrganizationSpendAlertsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OrganizationSpendAlert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ProjectSpendAlert>))]
    internal sealed partial class SpendAlertsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpendAlertsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SpendAlertsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SpendAlertsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpendAlertBodyInterval)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpendAlertBodyInterval?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertCurrency)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertCurrency?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertInterval)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertInterval?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertCurrency)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertCurrency?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertInterval)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertInterval?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertDeletedResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertDeletedResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpendAlertNotificationChannelType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpendAlertNotificationChannelType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectSpendAlertsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectSpendAlertsOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListOrganizationSpendAlertsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListOrganizationSpendAlertsOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSpendAlertBodyCurrencyJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSpendAlertBodyCurrencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpendAlertBodyInterval))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSpendAlertBodyIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSpendAlertBodyInterval?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSpendAlertBodyIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertCurrency))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertCurrencyJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertCurrency?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertCurrencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertInterval))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertInterval?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertDeletedResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertDeletedResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertDeletedResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OrganizationSpendAlertListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectSpendAlertObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectSpendAlertObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertCurrency))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectSpendAlertCurrencyJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertCurrency?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectSpendAlertCurrencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertInterval))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectSpendAlertIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertInterval?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectSpendAlertIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertDeletedResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectSpendAlertDeletedResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertDeletedResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectSpendAlertDeletedResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectSpendAlertListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProjectSpendAlertListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProjectSpendAlertListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpendAlertNotificationChannelType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpendAlertNotificationChannelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpendAlertNotificationChannelType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpendAlertNotificationChannelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectSpendAlertsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListProjectSpendAlertsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListProjectSpendAlertsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListProjectSpendAlertsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListOrganizationSpendAlertsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListOrganizationSpendAlertsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListOrganizationSpendAlertsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListOrganizationSpendAlertsOrderNullableJsonConverter();
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
                    0 => new SpendAlertsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}