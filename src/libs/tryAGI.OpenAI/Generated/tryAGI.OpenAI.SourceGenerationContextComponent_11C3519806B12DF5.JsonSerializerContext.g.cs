
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_11C3519806B12DF5 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_305B0C66F5E48B5A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_486492238D4A999B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6459644EF43514AA.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_785704050774C4C5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A4F3EC0F9BD0135E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AD531DDC20955E0D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B77C8FBB1665DAB8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DD9CF95430FF533D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DE83E25827581054.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EB33438917EE7CA9.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_11C3519806B12DF5 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_11C3519806B12DF5 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_11C3519806B12DF5(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_RealtimeConversationItem2.Create_RealtimeConversationItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableRealtimeConversationItem2.Create_NullableRealtimeConversationItem2(options);
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