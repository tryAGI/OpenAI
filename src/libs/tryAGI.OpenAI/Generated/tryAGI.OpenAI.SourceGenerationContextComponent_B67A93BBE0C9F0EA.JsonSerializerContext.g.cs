
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_B67A93BBE0C9F0EA
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_44E6A93D6A1572A8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C5D3DBFC94759AD2.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>>(static () => new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0525.Create_SourceGenerationContextMetadataType_B67A93BBE0C9F0EA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0536.Create_SourceGenerationContextMetadataType_D64AC8D57BC658EE(options);
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