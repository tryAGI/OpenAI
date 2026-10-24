
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_AC1801051777BDA1
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_253921678236C021.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_59292D3562DCACC1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6974696F148B228D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6D6C5DC24811098D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_876EF3A555071AAE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C3E83B7675880483.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EC0E39BE6D4483FA.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0083.Create_ChatCompletionRequestMessage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessage?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0247.Create_NullableChatCompletionRequestMessage2(options);
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