
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9ED8DB46A45D0F5B
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1A6FA192ED165947.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_683DDC29656793B4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_707314E9303DF686.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C4BF4E714D2AF49A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D6E5C51C1DC32E5E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateEvalLabelModelGrader, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>>(static () => new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateEvalLabelModelGrader, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalLabelModelGrader, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0516.Create_SourceGenerationContextMetadataType_9ED8DB46A45D0F5B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalLabelModelGrader, global::tryAGI.OpenAI.EvalGraderStringCheck?, global::tryAGI.OpenAI.EvalGraderTextSimilarity?, global::tryAGI.OpenAI.EvalGraderPython?, global::tryAGI.OpenAI.EvalGraderScoreModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0464.Create_SourceGenerationContextMetadataType_0789B9FA8FF09D10(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}