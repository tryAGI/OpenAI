
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_B181DB4D0B7843B2
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2F17CEFE86AEFF3F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_68A1ECDC3812BE08.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_920F67239757014F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_94C36D67DA6F4033.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A23D59B45785C884.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AA9101FD6682FD39.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BC1B3F1E026130F9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D2FABAAF17C53B73.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DF8272E486A1417F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFAA59AB7B5EA351.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.ComputerActionJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.ComputerActionJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.ComputerAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0091.Create_ComputerAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerAction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0251.Create_NullableComputerAction2(options);
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