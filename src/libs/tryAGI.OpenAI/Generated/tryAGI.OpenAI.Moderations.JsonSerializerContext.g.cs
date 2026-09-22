
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>>), TypeInfoPropertyName = "CreateModerationRequestInputVariant3ItemVariant2_aa2fa50684e533e3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>>?), TypeInfoPropertyName = "CreateModerationRequestInputVariant3ItemVariant2_2c308d3a0e1a6420")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>>), TypeInfoPropertyName = "CreateModerationRequestInputVariant3ItemVariant2_82fca1e83967e178")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>), TypeInfoPropertyName = "OneOfCreateModerationRequestInputVariant3ItemVariant1CreateModerationRequestInputVariant3ItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type), TypeInfoPropertyName = "CreateModerationRequestInputVariant3ItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1ImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type), TypeInfoPropertyName = "CreateModerationRequestInputVariant3ItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>), TypeInfoPropertyName = "AnyOfStringCreateModerationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestModel), TypeInfoPropertyName = "CreateModerationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesHateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesSexualItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem), TypeInfoPropertyName = "CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType), TypeInfoPropertyName = "MisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum), TypeInfoPropertyName = "MisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateModerationRequestInputVariant3ItemVariant1CreateModerationRequestInputVariant3ItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type?), TypeInfoPropertyName = "NullableCreateModerationRequestInputVariant3ItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type?), TypeInfoPropertyName = "NullableCreateModerationRequestInputVariant3ItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>?), TypeInfoPropertyName = "NullableAnyOfStringCreateModerationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationRequestModel?), TypeInfoPropertyName = "NullableCreateModerationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesHateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesIllicitItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesSexualItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesSexualMinor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesViolenceItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem?), TypeInfoPropertyName = "NullableCreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType?), TypeInfoPropertyName = "NullableMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>))]
    internal sealed partial class ModerationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModerationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ModerationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ModerationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestInputVariant3ItemVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestInputVariant3ItemVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestInputVariant3ItemVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestInputVariant3ItemVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstructionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstructionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSexualItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSexualItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinorJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
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
                    0 => new ModerationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}