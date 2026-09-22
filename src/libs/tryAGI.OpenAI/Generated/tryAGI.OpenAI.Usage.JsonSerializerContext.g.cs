
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CostsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CostsResultObject), TypeInfoPropertyName = "CostsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CostsResultAmount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CostsResultQuantityUnit?, object>), TypeInfoPropertyName = "AnyOfStringCostsResultQuantityUnitObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CostsResultQuantityUnit), TypeInfoPropertyName = "CostsResultQuantityUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject), TypeInfoPropertyName = "UsageAudioSpeechesResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject), TypeInfoPropertyName = "UsageAudioTranscriptionsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject), TypeInfoPropertyName = "UsageCodeInterpreterSessionsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCompletionsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject), TypeInfoPropertyName = "UsageCompletionsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageEmbeddingsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject), TypeInfoPropertyName = "UsageEmbeddingsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResultObject), TypeInfoPropertyName = "UsageFileSearchCallsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesResultObject), TypeInfoPropertyName = "UsageImagesResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageModerationsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageModerationsResultObject), TypeInfoPropertyName = "UsageModerationsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageResponseObject), TypeInfoPropertyName = "UsageResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageTimeBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageTimeBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageTimeBucketObject), TypeInfoPropertyName = "UsageTimeBucketObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResultsItem), TypeInfoPropertyName = "ResultsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageVectorStoresResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject), TypeInfoPropertyName = "UsageTimeBucketResultDiscriminatorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject), TypeInfoPropertyName = "UsageVectorStoresResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultObject), TypeInfoPropertyName = "UsageWebSearchCallsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType), TypeInfoPropertyName = "MisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum), TypeInfoPropertyName = "MisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCostsBucketWidth), TypeInfoPropertyName = "UsageCostsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCostsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCostsGroupByItem), TypeInfoPropertyName = "UsageCostsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesBucketWidth), TypeInfoPropertyName = "UsageAudioSpeechesBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem), TypeInfoPropertyName = "UsageAudioSpeechesGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth), TypeInfoPropertyName = "UsageAudioTranscriptionsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem), TypeInfoPropertyName = "UsageAudioTranscriptionsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth), TypeInfoPropertyName = "UsageCodeInterpreterSessionsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem), TypeInfoPropertyName = "UsageCodeInterpreterSessionsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCompletionsBucketWidth), TypeInfoPropertyName = "UsageCompletionsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCompletionsGroupByItem), TypeInfoPropertyName = "UsageCompletionsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageEmbeddingsBucketWidth), TypeInfoPropertyName = "UsageEmbeddingsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem), TypeInfoPropertyName = "UsageEmbeddingsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageFileSearchCallsBucketWidth), TypeInfoPropertyName = "UsageFileSearchCallsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem), TypeInfoPropertyName = "UsageFileSearchCallsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesBucketWidth), TypeInfoPropertyName = "UsageImagesBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesSource), TypeInfoPropertyName = "UsageImagesSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesSize), TypeInfoPropertyName = "UsageImagesSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageImagesGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesGroupByItem), TypeInfoPropertyName = "UsageImagesGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageModerationsBucketWidth), TypeInfoPropertyName = "UsageModerationsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageModerationsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageModerationsGroupByItem), TypeInfoPropertyName = "UsageModerationsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageVectorStoresBucketWidth), TypeInfoPropertyName = "UsageVectorStoresBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageVectorStoresGroupByItem), TypeInfoPropertyName = "UsageVectorStoresGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageWebSearchCallsBucketWidth), TypeInfoPropertyName = "UsageWebSearchCallsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel), TypeInfoPropertyName = "UsageWebSearchCallsContextLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem), TypeInfoPropertyName = "UsageWebSearchCallsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CostsResultObject?), TypeInfoPropertyName = "NullableCostsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CostsResultQuantityUnit?, object>?), TypeInfoPropertyName = "NullableAnyOfStringCostsResultQuantityUnitObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CostsResultQuantityUnit?), TypeInfoPropertyName = "NullableCostsResultQuantityUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject?), TypeInfoPropertyName = "NullableUsageAudioSpeechesResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject?), TypeInfoPropertyName = "NullableUsageAudioTranscriptionsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject?), TypeInfoPropertyName = "NullableUsageCodeInterpreterSessionsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject?), TypeInfoPropertyName = "NullableUsageCompletionsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject?), TypeInfoPropertyName = "NullableUsageEmbeddingsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResultObject?), TypeInfoPropertyName = "NullableUsageFileSearchCallsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesResultObject?), TypeInfoPropertyName = "NullableUsageImagesResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageModerationsResultObject?), TypeInfoPropertyName = "NullableUsageModerationsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageResponseObject?), TypeInfoPropertyName = "NullableUsageResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageTimeBucketObject?), TypeInfoPropertyName = "NullableUsageTimeBucketObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResultsItem?), TypeInfoPropertyName = "NullableResultsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject?), TypeInfoPropertyName = "NullableUsageTimeBucketResultDiscriminatorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject?), TypeInfoPropertyName = "NullableUsageVectorStoresResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultObject?), TypeInfoPropertyName = "NullableUsageWebSearchCallsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType?), TypeInfoPropertyName = "NullableMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCostsBucketWidth?), TypeInfoPropertyName = "NullableUsageCostsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCostsGroupByItem?), TypeInfoPropertyName = "NullableUsageCostsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesBucketWidth?), TypeInfoPropertyName = "NullableUsageAudioSpeechesBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem?), TypeInfoPropertyName = "NullableUsageAudioSpeechesGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth?), TypeInfoPropertyName = "NullableUsageAudioTranscriptionsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem?), TypeInfoPropertyName = "NullableUsageAudioTranscriptionsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth?), TypeInfoPropertyName = "NullableUsageCodeInterpreterSessionsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem?), TypeInfoPropertyName = "NullableUsageCodeInterpreterSessionsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCompletionsBucketWidth?), TypeInfoPropertyName = "NullableUsageCompletionsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageCompletionsGroupByItem?), TypeInfoPropertyName = "NullableUsageCompletionsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageEmbeddingsBucketWidth?), TypeInfoPropertyName = "NullableUsageEmbeddingsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem?), TypeInfoPropertyName = "NullableUsageEmbeddingsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageFileSearchCallsBucketWidth?), TypeInfoPropertyName = "NullableUsageFileSearchCallsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem?), TypeInfoPropertyName = "NullableUsageFileSearchCallsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesBucketWidth?), TypeInfoPropertyName = "NullableUsageImagesBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesSource?), TypeInfoPropertyName = "NullableUsageImagesSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesSize?), TypeInfoPropertyName = "NullableUsageImagesSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageImagesGroupByItem?), TypeInfoPropertyName = "NullableUsageImagesGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageModerationsBucketWidth?), TypeInfoPropertyName = "NullableUsageModerationsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageModerationsGroupByItem?), TypeInfoPropertyName = "NullableUsageModerationsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageVectorStoresBucketWidth?), TypeInfoPropertyName = "NullableUsageVectorStoresBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageVectorStoresGroupByItem?), TypeInfoPropertyName = "NullableUsageVectorStoresGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageWebSearchCallsBucketWidth?), TypeInfoPropertyName = "NullableUsageWebSearchCallsBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel?), TypeInfoPropertyName = "NullableUsageWebSearchCallsContextLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem?), TypeInfoPropertyName = "NullableUsageWebSearchCallsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageTimeBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResultsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCostsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageCompletionsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageImagesGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageModerationsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageVectorStoresGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem>))]
    internal sealed partial class UsageSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UsageSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UsageSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResultsItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CostsResultQuantityUnit?, object>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultQuantityUnit)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultQuantityUnit?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCostsBucketWidth)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCostsBucketWidth?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCostsGroupByItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCostsGroupByItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesBucketWidth)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesBucketWidth?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsBucketWidth)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsBucketWidth?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsGroupByItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsGroupByItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsBucketWidth)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsBucketWidth?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsBucketWidth)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsBucketWidth?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesBucketWidth)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesBucketWidth?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesSource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesSource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesGroupByItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesGroupByItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsBucketWidth)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsBucketWidth?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsGroupByItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsGroupByItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresBucketWidth)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresBucketWidth?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresGroupByItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresGroupByItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsBucketWidth)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsBucketWidth?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CostsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CostsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultQuantityUnit))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CostsResultQuantityUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultQuantityUnit?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CostsResultQuantityUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCompletionsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCompletionsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageFileSearchCallsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageFileSearchCallsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageImagesResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageImagesResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageModerationsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageModerationsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageTimeBucketObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageTimeBucketObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageTimeBucketResultDiscriminatorObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageTimeBucketResultDiscriminatorObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCostsBucketWidth))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCostsBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCostsBucketWidth?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCostsBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCostsGroupByItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCostsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCostsGroupByItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCostsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesBucketWidth))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesBucketWidth?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesGroupByItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsGroupByItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsBucketWidth))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCompletionsBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsBucketWidth?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCompletionsBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsGroupByItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCompletionsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsGroupByItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCompletionsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsBucketWidth))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsBucketWidth?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsBucketWidth))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageFileSearchCallsBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsBucketWidth?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageFileSearchCallsBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageFileSearchCallsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsGroupByItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageFileSearchCallsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesBucketWidth))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageImagesBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesBucketWidth?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageImagesBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesSource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageImagesSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesSource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageImagesSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageImagesSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageImagesSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesGroupByItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageImagesGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesGroupByItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageImagesGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsBucketWidth))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageModerationsBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsBucketWidth?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageModerationsBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsGroupByItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageModerationsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsGroupByItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageModerationsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresBucketWidth))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresBucketWidth?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresGroupByItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresGroupByItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsBucketWidth))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsBucketWidth?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsContextLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsContextLevel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsContextLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsGroupByItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsGroupByItemNullableJsonConverter();
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
                    0 => new UsageSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}