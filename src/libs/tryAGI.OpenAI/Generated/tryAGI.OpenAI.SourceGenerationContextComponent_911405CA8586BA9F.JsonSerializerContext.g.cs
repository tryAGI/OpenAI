
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_911405CA8586BA9F
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_599D8CB6B4A9508C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7196CC0D78D21FD7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_85C18300945B80AD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_987C37289C2EB236.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A2015C0C8FDF8076.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AB0E00786D51C108.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B668ACE32176FE67.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DCA12F0F59F4F747.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F4F6409D57C7CDEF.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.ToolChoiceParamJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.ToolChoiceParamJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0567.Create_ToolChoiceParam(options);
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