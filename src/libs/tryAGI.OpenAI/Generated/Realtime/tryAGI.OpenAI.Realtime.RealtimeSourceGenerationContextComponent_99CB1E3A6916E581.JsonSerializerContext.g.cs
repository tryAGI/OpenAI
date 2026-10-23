
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class RealtimeSourceGenerationContextComponent_99CB1E3A6916E581
    {

        internal static readonly global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_0AB17242EAF56D7B.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_17752726F4FD0D0F.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_585BBB460BC3D6EF.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_72D99E85884262B5.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_882E0772B6768DEF.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_9DD1CB86B2D71239.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_A73A2B34E3F99A24.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_AFA369DB844E4648.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_B039D697FD595EB1.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_BA2AEAFD29170135.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_DA0CFDCD2AEDBA03.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_F1ABE44BAE45F51E.MetadataScope,
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
                if (type == typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGA))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0Factory_RealtimeSessionCreateRequestGA.Create_RealtimeSessionCreateRequestGA(options);
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