
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_5C2656E11D0F5BE1
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_205658DA551B57C6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3A181B0A3DE100F2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_54515F7B0BBED5D7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A4E06BB9E494D86F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A5F5F690BC7AD5AD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E9C9ADD2E97C055A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F58181BB3B8AE9CA.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.InputItemJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.InputItemJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.InputItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_InputItem2.Create_InputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableInputItem2.Create_NullableInputItem2(options);
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