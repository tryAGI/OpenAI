
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_4258927320B545DF : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_15E67DA85618A8C5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_31CC017D171BD654.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_390B27F927E694CB.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3AB620E9DFD5C20D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3ADB8692F2DBADA0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_59AECA03ADD60AA4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6457CF0BF480F716.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_848C476CA8493567.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9C5C90286E86A938.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9E49506902EF85DC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A2D3AB8A106C6B80.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B468F3672395BF93.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_4258927320B545DF Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_4258927320B545DF Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_4258927320B545DF(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_RealtimeClientEvent2.Create_RealtimeClientEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableRealtimeClientEvent2.Create_NullableRealtimeClientEvent2(options);
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