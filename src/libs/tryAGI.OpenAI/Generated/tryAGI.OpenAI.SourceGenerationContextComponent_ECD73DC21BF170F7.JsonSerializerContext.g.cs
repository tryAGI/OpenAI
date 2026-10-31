
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_ECD73DC21BF170F7
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0B5C5455EACFC5F9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0BA0C696F140D6F2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2A6AB4067AD37EBE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_50DFB1CC49E9DCBF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5297316E708C644D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5E7FD689BAE72752.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5F2E7918C5FBDE02.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_635A9AD4B4EE8F6F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_822F5B222B0CC8B5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8C1292AB30E33FC1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BD9DF5DB49F045F5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C22F6B1388B6207C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CFA0AC14AF840A57.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E34691CFB83A06C9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EDC211673ED81056.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FB056AA29F9C1B39.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseVariant3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0067.Create_BetaResponseVariant3(options);
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