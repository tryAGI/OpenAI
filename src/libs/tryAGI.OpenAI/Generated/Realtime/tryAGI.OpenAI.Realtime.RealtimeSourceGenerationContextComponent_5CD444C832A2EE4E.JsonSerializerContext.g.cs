
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class RealtimeSourceGenerationContextComponent_5CD444C832A2EE4E
    {

        internal static readonly global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_3D15134CF0A21F1E.MetadataScope,
                }, null);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0Factory_RealtimeSourceGenerationContextMetadataType_5CD444C832A2EE4E.Create_RealtimeSourceGenerationContextMetadataType_5CD444C832A2EE4E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0Factory_RealtimeSourceGenerationContextMetadataType_54E8C5A10A993CFF.Create_RealtimeSourceGenerationContextMetadataType_54E8C5A10A993CFF(options);
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