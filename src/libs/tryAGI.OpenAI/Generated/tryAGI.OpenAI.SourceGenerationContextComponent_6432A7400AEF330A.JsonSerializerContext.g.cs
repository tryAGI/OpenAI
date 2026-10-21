
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_6432A7400AEF330A
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_229F74DC4C31B594.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2F70375A6C5B368B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_84A69B09C2A0A93C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DB67C2C9421C50C8.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.VoiceIdsShared?, global::tryAGI.OpenAI.CreateSpeechRequestVoice?>?, global::tryAGI.OpenAI.CreateSpeechRequestVoice2>>(static () => new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.VoiceIdsShared?, global::tryAGI.OpenAI.CreateSpeechRequestVoice?>?, global::tryAGI.OpenAI.CreateSpeechRequestVoice2>());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.VoiceIdsShared?, global::tryAGI.OpenAI.CreateSpeechRequestVoice?>?, global::tryAGI.OpenAI.CreateSpeechRequestVoice2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_SourceGenerationContextMetadataType_6432A7400AEF330A.Create_SourceGenerationContextMetadataType_6432A7400AEF330A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.VoiceIdsShared?, global::tryAGI.OpenAI.CreateSpeechRequestVoice?>?, global::tryAGI.OpenAI.CreateSpeechRequestVoice2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_SourceGenerationContextMetadataType_BE5890B4E5171505.Create_SourceGenerationContextMetadataType_BE5890B4E5171505(options);
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