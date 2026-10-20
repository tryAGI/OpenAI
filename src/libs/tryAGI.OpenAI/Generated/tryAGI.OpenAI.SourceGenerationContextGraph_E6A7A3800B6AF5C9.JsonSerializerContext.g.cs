
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_E6A7A3800B6AF5C9 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_E6A7A3800B6AF5C9 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_E6A7A3800B6AF5C9(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem?);
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
                if (type == typeof(double))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResult>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B0CC6528FADE2685(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_DB1329AC7DA3DF28(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F83288E2815CC239(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5CE6BCF3378AEE6A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D0306E3F6E6CDB78(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_6BF222AA49FFFC88(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_77C943988588063A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_270117B62332F83E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_87618D4523BA3B00(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B2F98E19C80B465F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_52E9027093B126C8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_2E7562A5EF420CF8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9A01D7C5361B9D0D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9616234A69B6E191(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5160D075C006CA35(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_15873099E1B22529(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationRequestInputVariant3ItemVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1ImageUrl))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationRequestInputVariant3ItemVariant1ImageUrl(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationRequestInputVariant3ItemVariant1Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationRequestInputVariant3ItemVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationRequestInputVariant3ItemVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationRequestModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategories))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategories(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypes(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesHateItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesSexualItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryScores))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModerationResponseResultCategoryScores(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F55002BE4830ED9E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_35D75A8F89D9EA73(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_95CBAD6AB8B702B6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationRequestInputVariant3ItemVariant1Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationRequestInputVariant3ItemVariant2Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationRequestModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesHateItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesIllicitItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesSexualItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesSexualMinor2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateModerationResponseResultCategoryAppliedInputTypesViolenceItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D9BE4052EB1B3941(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FA736E1AC133C089(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResult>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_463A4D5A861ECDFA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_37802380A256A369(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_898DC1A94C1E24CA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E758C77B695EADBD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3502075B9493EBCC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_318C38AE7A8B3AA7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_73E6EC492C6F0030(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_213F18E5BBB1C505(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_89649324FA6A248E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2812FDF29B47D561(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AE9944468B22F11A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9D753ED912763A05(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_33E53AB29DA06935(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1B10962A9FFAAC7E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9142C1DE8743A3D9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1, global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant2>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_1D5C1C83BB95E02D(options);
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