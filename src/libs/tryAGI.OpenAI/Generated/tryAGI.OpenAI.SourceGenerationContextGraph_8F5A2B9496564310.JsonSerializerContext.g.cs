
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_8F5A2B9496564310 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_8F5A2B9496564310 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_8F5A2B9496564310(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchRankerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchRankerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchResultObjectContentItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchResultObjectContentItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectLastErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter();
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
                if (type == typeof(double))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_9B381E90A4EF2D2B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_44E0CF8C6D74658C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_6F35DF7152C746AB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_59122DCE4DA189AD(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchRanker))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FileSearchRanker2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_8E1A8F5656643B53(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_49B1EDE9A00410F7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_455A7D8A948D2AD6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepCompletionUsageVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepCompletionUsageVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsMessageCreationObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectMessageCreation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsMessageCreationObjectMessageCreation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsMessageCreationObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeObjectCodeInterpreter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeOutputImageObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeOutputImageObjectImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeOutputImageObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeOutputLogsObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeOutputLogsObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectFileSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchObjectFileSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchRankingOptionsObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchResultObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchResultObjectContentItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchResultObjectContentItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFunctionObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFunctionObjectFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFunctionObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RunStepObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectLastError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepObjectLastError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepObjectLastErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepObjectStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepObjectType2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchRanker?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileSearchRanker2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_AEC54B1C23D248DA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A6F5CFDAABCB0602(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_052C8F0411FCBD3A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsMessageCreationObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsCodeObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsCodeOutputImageObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsCodeOutputLogsObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsFileSearchObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsFileSearchResultObjectContentItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsFunctionObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepObjectLastErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepObjectStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepObjectType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9863C93CDA017189(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B2E9EE125890D0B8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A45605418757433E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_00FEBFDCAC0FD86D(options);
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