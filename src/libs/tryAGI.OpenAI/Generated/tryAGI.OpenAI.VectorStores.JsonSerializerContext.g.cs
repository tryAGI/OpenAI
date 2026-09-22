
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoChunkingStrategyRequestParamType), TypeInfoPropertyName = "AutoChunkingStrategyRequestParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChunkingStrategyRequestParam), TypeInfoPropertyName = "ChunkingStrategyRequestParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminatorType), TypeInfoPropertyName = "ChunkingStrategyRequestParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComparisonFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComparisonFilterType), TypeInfoPropertyName = "ComparisonFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>), TypeInfoPropertyName = "OneOfStringDoubleBooleanIListOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?>), TypeInfoPropertyName = "OneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompoundFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompoundFilterType), TypeInfoPropertyName = "CompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FiltersItem), TypeInfoPropertyName = "FiltersItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompoundFilterFilterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVectorStoreFileBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVectorStoreFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateVectorStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreExpirationAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam, global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam>), TypeInfoPropertyName = "OneOfAutoChunkingStrategyRequestParamStaticChunkingStrategyRequestParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteVectorStoreFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteVectorStoreFileResponseObject), TypeInfoPropertyName = "DeleteVectorStoreFileResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteVectorStoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteVectorStoreResponseObject), TypeInfoPropertyName = "DeleteVectorStoreResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoreFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType), TypeInfoPropertyName = "OtherChunkingStrategyResponseParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StaticChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StaticChunkingStrategyRequestParamType), TypeInfoPropertyName = "StaticChunkingStrategyRequestParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType), TypeInfoPropertyName = "StaticChunkingStrategyResponseParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateVectorStoreFileAttributesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateVectorStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>), TypeInfoPropertyName = "AllOfVectorStoreExpirationAfterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreExpirationAfterAnchor), TypeInfoPropertyName = "VectorStoreExpirationAfterAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?>), TypeInfoPropertyName = "OneOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectObject), TypeInfoPropertyName = "VectorStoreFileBatchObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectStatus), TypeInfoPropertyName = "VectorStoreFileBatchObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectFileCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileContentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileContentResponseObject), TypeInfoPropertyName = "VectorStoreFileContentResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject), TypeInfoPropertyName = "VectorStoreFileObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus), TypeInfoPropertyName = "VectorStoreFileObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode), TypeInfoPropertyName = "VectorStoreFileObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>), TypeInfoPropertyName = "OneOfStaticChunkingStrategyResponseParamOtherChunkingStrategyResponseParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreObjectObject), TypeInfoPropertyName = "VectorStoreObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreObjectFileCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreObjectStatus), TypeInfoPropertyName = "VectorStoreObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>), TypeInfoPropertyName = "OneOfComparisonFilterCompoundFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker), TypeInfoPropertyName = "VectorStoreSearchRequestRankingOptionsRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType), TypeInfoPropertyName = "VectorStoreSearchResultContentObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject), TypeInfoPropertyName = "VectorStoreSearchResultsPageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType), TypeInfoPropertyName = "MisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum), TypeInfoPropertyName = "MisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoresOrder), TypeInfoPropertyName = "ListVectorStoresOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder), TypeInfoPropertyName = "ListFilesInVectorStoreBatchOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter), TypeInfoPropertyName = "ListFilesInVectorStoreBatchFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoreFilesOrder), TypeInfoPropertyName = "ListVectorStoreFilesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoreFilesFilter), TypeInfoPropertyName = "ListVectorStoreFilesFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoChunkingStrategyRequestParamType?), TypeInfoPropertyName = "NullableAutoChunkingStrategyRequestParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChunkingStrategyRequestParam?), TypeInfoPropertyName = "NullableChunkingStrategyRequestParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminatorType?), TypeInfoPropertyName = "NullableChunkingStrategyRequestParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComparisonFilterType?), TypeInfoPropertyName = "NullableComparisonFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanIListOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?>?), TypeInfoPropertyName = "NullableOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompoundFilterType?), TypeInfoPropertyName = "NullableCompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FiltersItem?), TypeInfoPropertyName = "NullableFiltersItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam, global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam>?), TypeInfoPropertyName = "NullableOneOfAutoChunkingStrategyRequestParamStaticChunkingStrategyRequestParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteVectorStoreFileResponseObject?), TypeInfoPropertyName = "NullableDeleteVectorStoreFileResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeleteVectorStoreResponseObject?), TypeInfoPropertyName = "NullableDeleteVectorStoreResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType?), TypeInfoPropertyName = "NullableOtherChunkingStrategyResponseParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StaticChunkingStrategyRequestParamType?), TypeInfoPropertyName = "NullableStaticChunkingStrategyRequestParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType?), TypeInfoPropertyName = "NullableStaticChunkingStrategyResponseParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>?), TypeInfoPropertyName = "NullableAllOfVectorStoreExpirationAfterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreExpirationAfterAnchor?), TypeInfoPropertyName = "NullableVectorStoreExpirationAfterAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectObject?), TypeInfoPropertyName = "NullableVectorStoreFileBatchObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectStatus?), TypeInfoPropertyName = "NullableVectorStoreFileBatchObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileContentResponseObject?), TypeInfoPropertyName = "NullableVectorStoreFileContentResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject?), TypeInfoPropertyName = "NullableVectorStoreFileObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus?), TypeInfoPropertyName = "NullableVectorStoreFileObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode?), TypeInfoPropertyName = "NullableVectorStoreFileObjectLastErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>?), TypeInfoPropertyName = "NullableOneOfStaticChunkingStrategyResponseParamOtherChunkingStrategyResponseParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreObjectObject?), TypeInfoPropertyName = "NullableVectorStoreObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreObjectStatus?), TypeInfoPropertyName = "NullableVectorStoreObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>?), TypeInfoPropertyName = "NullableOneOfComparisonFilterCompoundFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker?), TypeInfoPropertyName = "NullableVectorStoreSearchRequestRankingOptionsRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType?), TypeInfoPropertyName = "NullableVectorStoreSearchResultContentObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject?), TypeInfoPropertyName = "NullableVectorStoreSearchResultsPageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType?), TypeInfoPropertyName = "NullableMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoresOrder?), TypeInfoPropertyName = "NullableListVectorStoresOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder?), TypeInfoPropertyName = "NullableListFilesInVectorStoreBatchOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter?), TypeInfoPropertyName = "NullableListFilesInVectorStoreBatchFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoreFilesOrder?), TypeInfoPropertyName = "NullableListVectorStoreFilesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListVectorStoreFilesFilter?), TypeInfoPropertyName = "NullableListVectorStoreFilesFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreFileObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreFileContentResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreSearchResultItem>))]
    internal sealed partial class VectorStoresSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VectorStoresSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VectorStoresSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VectorStoresSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChunkingStrategyRequestParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FiltersItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam, global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.Error, string>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.AutoChunkingStrategyRequestParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AutoChunkingStrategyRequestParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteVectorStoreFileResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteVectorStoreFileResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteVectorStoreResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeleteVectorStoreResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyRequestParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyRequestParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreExpirationAfterAnchor)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreExpirationAfterAnchor?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileContentResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileContentResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreObjectStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreObjectStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListVectorStoresOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListVectorStoresOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListVectorStoreFilesOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListVectorStoreFilesOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListVectorStoreFilesFilter)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListVectorStoreFilesFilter?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.AutoChunkingStrategyRequestParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AutoChunkingStrategyRequestParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChunkingStrategyRequestParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChunkingStrategyRequestParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChunkingStrategyRequestParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComparisonFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComparisonFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompoundFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompoundFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteVectorStoreFileResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteVectorStoreFileResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteVectorStoreResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeleteVectorStoreResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyRequestParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyRequestParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreExpirationAfterAnchor))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreExpirationAfterAnchor?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileBatchObjectStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileContentResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileContentResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileContentResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileContentResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreObjectStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreObjectStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultContentObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultContentObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultsPageObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultsPageObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListVectorStoresOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListVectorStoresOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListVectorStoresOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListVectorStoresOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListVectorStoreFilesOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListVectorStoreFilesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListVectorStoreFilesOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListVectorStoreFilesFilter))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListVectorStoreFilesFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListVectorStoreFilesFilter?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter();
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
                    0 => new VectorStoresSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}