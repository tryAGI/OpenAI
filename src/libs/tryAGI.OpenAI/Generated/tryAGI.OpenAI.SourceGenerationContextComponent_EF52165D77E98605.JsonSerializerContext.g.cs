
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_EF52165D77E98605 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_075F72DF2B04B957.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_080BD58B87EF7CAD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_08F848B2FF39BAB5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_16ABB5428CB21795.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_344D2703E8637142.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3A56E8735B86EA1F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3DE9C29BEF891D37.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_45BE497D5B8663B7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4960D7A1BB3E0AA6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_49A7225623E904AF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_58E613CDCB9795A4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5B575F7444D31358.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5D0098962C8F10E6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7024AE3FE0917E3B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_74F81216183B00ED.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_777237AD3B007EA1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_77EB49864E6D7A09.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_93551D0EC89AAE76.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_968E82BF822AD2D7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9699399C1A6241C8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A10A9A065F72E109.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A3FB97C83738482C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D13FCEEA46B195E2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D2BF2F4DCF7018E2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E2788FB62F3D7F16.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E27902287771C684.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E7E77E52DAD95E97.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E8D1B7B94448AA26.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F0046A29F169734B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F7C4A5697BE162B1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FD306D21E9130FC0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FE04A73D8C100047.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_EF52165D77E98605 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_EF52165D77E98605 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_EF52165D77E98605(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.BetaItemFieldJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.BetaItemFieldJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.BetaItemField))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_BetaItemField2.Create_BetaItemField2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaItemField?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableBetaItemField2.Create_NullableBetaItemField2(options);
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