
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_3F3B52FD51437CF9 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_04CBE6C516006494.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_13529CBFADF0C1E8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4DE1A4FB0B55F216.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_55CB0D7D6EE404CF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5977319AC9124F43.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5A4F33C106415327.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5E43D0150748588B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B1E233522BCB5CB8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C9C7E30DA5BCA78D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DBFAE4B90A54B04F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E16BAAE715B730C7.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_3F3B52FD51437CF9 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_3F3B52FD51437CF9 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_3F3B52FD51437CF9(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.ContentItem7JsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.ContentItem7JsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.ContentItem7))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_ContentItem72.Create_ContentItem72(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContentItem7?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableContentItem72.Create_NullableContentItem72(options);
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