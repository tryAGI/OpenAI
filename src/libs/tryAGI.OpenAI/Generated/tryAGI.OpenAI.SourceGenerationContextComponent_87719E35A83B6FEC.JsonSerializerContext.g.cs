
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_87719E35A83B6FEC : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_00316FE537144EC0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_02C9B4E931291FA8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1C083C85BF0DEC97.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_247D209EFF727AAE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2BB49AC94BBECE10.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2BF8023E7A0471AB.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2F1343A1BEEA6930.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2FC0AD881F78FA9C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_35E01D045246FBAA.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4747639BA57D9386.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_47A08272360DE9EE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4878EFF16E56F26F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_59054E1D2F0349F6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5E4D266C4159B300.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_605DC0EC4C0174F1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_61ABDD57CF5A1B32.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_64532FC7ABB384AD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_75DFC455792C4960.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_78EBBA7CBF35AEC8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7BC5EE3390CD68B4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8B6E0B5970264201.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8C07E45F45E7F765.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AA4301DE3489EA08.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BD303339A20C0C37.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D017B4420FCFD790.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D62DE0118CBC8F75.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E35C7C88EE224249.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F63CB980CE2853D3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FA5109E2B96118C5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FBCBDA1DAA3E0750.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_87719E35A83B6FEC Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_87719E35A83B6FEC Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_87719E35A83B6FEC(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.ConversationItemJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.ConversationItemJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.ConversationItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_ConversationItem2.Create_ConversationItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ConversationItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableConversationItem2.Create_NullableConversationItem2(options);
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