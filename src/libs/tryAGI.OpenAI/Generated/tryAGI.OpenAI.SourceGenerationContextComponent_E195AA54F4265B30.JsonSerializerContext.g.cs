
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_E195AA54F4265B30 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0246451F5ED5D6E2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CE42DC6CC8FA3B4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2DECBE399360342B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_68E6E608449B3CE3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_88DE3147ADF0AD0E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9103EACFD8BEB5A0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F68AE084A4601A23.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_E195AA54F4265B30 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_E195AA54F4265B30 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_E195AA54F4265B30(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);
        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_RunStepStreamEvent2.Create_RunStepStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableRunStepStreamEvent2.Create_NullableRunStepStreamEvent2(options);
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