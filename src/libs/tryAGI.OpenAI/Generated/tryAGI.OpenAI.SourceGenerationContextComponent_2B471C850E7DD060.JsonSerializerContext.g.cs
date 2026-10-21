
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_2B471C850E7DD060 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_49A5DF6939E196C1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4E804A0EA1F41AE1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B01007B70B407C58.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F51AB0C1BED2B99F.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_2B471C850E7DD060 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_2B471C850E7DD060 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_2B471C850E7DD060(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>>(static () => new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_SourceGenerationContextMetadataType_2B471C850E7DD060.Create_SourceGenerationContextMetadataType_2B471C850E7DD060(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_SourceGenerationContextMetadataType_EECE817C31A7267F.Create_SourceGenerationContextMetadataType_EECE817C31A7267F(options);
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