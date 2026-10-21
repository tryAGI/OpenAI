
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_B316549238DC4007 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_143A45280878D65F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4100481D476A6766.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4A9EAD65905DD472.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7A96997374A70C62.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A027780F802ADD0D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B0CD9698F6566C12.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B5AA1B7A839D8320.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CD2FDD51EED902DC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E9E79A1D39DE4738.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F5C532A41CAB1C11.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_B316549238DC4007 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_B316549238DC4007 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_B316549238DC4007(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.ContentItem3JsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.ContentItem3JsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.ContentItem3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_ContentItem32.Create_ContentItem32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContentItem3?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableContentItem32.Create_NullableContentItem32(options);
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