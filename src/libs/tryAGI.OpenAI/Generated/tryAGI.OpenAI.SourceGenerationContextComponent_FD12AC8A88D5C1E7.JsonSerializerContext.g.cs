
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FD12AC8A88D5C1E7
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0248AB760E9CC891.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0894A124443F201B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1F00DD6CF17CF96F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4AA1AD2ACAB8F1B4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7F3B61E759B063D2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_882EB446B287CE20.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B42CDDE565604FD9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C236CB9A53D5F0E5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F653B8ED5526E9B9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F928175D16C32167.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0035.Create_BetaImageGenTool(options);
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