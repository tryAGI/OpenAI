
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_633F291B8DE66F3A
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
            collector.AddEnum(typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus), static () => new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallOutputStatusJsonConverter());
            collector.AddEnum(typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus?), static () => new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallOutputStatusNullableJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_BetaLocalShellToolCallOutputStatus2.Create_BetaLocalShellToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableBetaLocalShellToolCallOutputStatus2.Create_NullableBetaLocalShellToolCallOutputStatus2(options);
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