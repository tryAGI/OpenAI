
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_205658DA551B57C6 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_02C9B4E931291FA8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_02FD9B3669099389.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_176FF7FF1FDE27BE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_24264310A5F5844E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_247D209EFF727AAE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_35E01D045246FBAA.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4211282F3597B573.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4747639BA57D9386.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_47A08272360DE9EE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4A3EA690A8943CCF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_508ACFF0E2150AC9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_51168E8ED23B6B81.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_61ABDD57CF5A1B32.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_75DFC455792C4960.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7BC5EE3390CD68B4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8590D989FB4A35D7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8C07E45F45E7F765.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9411576DDF14A2BD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B4443219B7E5572B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BCF6A11C8696D6A1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C19685CFBB7B1B70.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C5B307E60AD6BDE4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CD43C7B59019433A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D62DE0118CBC8F75.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D7C71752DBF3CBED.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E35C7C88EE224249.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E443B33E789D83BE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F63CB980CE2853D3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FA5109E2B96118C5.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_205658DA551B57C6 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_205658DA551B57C6 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_205658DA551B57C6(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.ItemJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.ItemJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_Item2.Create_Item2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Item?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableItem2.Create_NullableItem2(options);
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