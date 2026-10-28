
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_190375F5C83D652F
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::tryAGI.OpenAI.LiveResponseItemCreateParamType), static () => new global::tryAGI.OpenAI.JsonConverters.LiveResponseItemCreateParamTypeJsonConverter());
            collector.AddEnum(typeof(global::tryAGI.OpenAI.LiveResponseItemCreateParamType?), static () => new global::tryAGI.OpenAI.JsonConverters.LiveResponseItemCreateParamTypeNullableJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.LiveResponseItemCreateParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0187.Create_LiveResponseItemCreateParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveResponseItemCreateParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0300.Create_NullableLiveResponseItemCreateParamType2(options);
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