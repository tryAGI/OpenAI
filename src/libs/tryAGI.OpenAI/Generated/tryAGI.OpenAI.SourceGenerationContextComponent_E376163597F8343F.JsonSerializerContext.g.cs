
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E376163597F8343F
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1DF9DDF76B7F7ED2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3BB7B030BB50F4F8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3C99A7AF45661717.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_75E6E9F9BCA42397.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A5C9C81619D6E421.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveSessionClosedReasonVariant1?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant2?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant3?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant4?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant5?>>(static () => new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.LiveSessionClosedReasonVariant1?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant2?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant3?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant4?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant5?>());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveSessionClosedReasonVariant1?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant2?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant3?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant4?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant5?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0517.Create_SourceGenerationContextMetadataType_E376163597F8343F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveSessionClosedReasonVariant1?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant2?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant3?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant4?, global::tryAGI.OpenAI.LiveSessionClosedReasonVariant5?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0446.Create_SourceGenerationContextMetadataType_0D51F67B8FC7748A(options);
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