
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class RealtimeSourceGenerationContextComponent_33BE503CD30526BF
    {

        internal static readonly global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope>[] {
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
                if (type == typeof(global::tryAGI.OpenAI.Realtime.MCPToolHeaders))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0Factory_MCPToolHeaders.Create_MCPToolHeaders(options);
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