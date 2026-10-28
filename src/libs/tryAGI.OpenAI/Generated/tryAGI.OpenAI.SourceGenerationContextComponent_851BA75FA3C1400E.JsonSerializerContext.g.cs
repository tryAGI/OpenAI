
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_851BA75FA3C1400E
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_379EC6C5F8895DEC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_45D6FF85CF62A09D.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>>(static () => new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0507.Create_SourceGenerationContextMetadataType_851BA75FA3C1400E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0496.Create_SourceGenerationContextMetadataType_695FC46B0FC75FD7(options);
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