
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StaticChunkingStrategyResponseParam
    {
        /// <summary>
        /// Always `static`.
        /// </summary>
        /// <default>"static"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "static";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("static")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.StaticChunkingStrategy Static { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticChunkingStrategyResponseParam" /> class.
        /// </summary>
        /// <param name="static"></param>
        /// <param name="type">
        /// Always `static`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StaticChunkingStrategyResponseParam(
            global::tryAGI.OpenAI.StaticChunkingStrategy @static,
            string type = "static")
        {
            this.Type = type;
            this.Static = @static ?? throw new global::System.ArgumentNullException(nameof(@static));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticChunkingStrategyResponseParam" /> class.
        /// </summary>
        public StaticChunkingStrategyResponseParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="StaticChunkingStrategyResponseParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static StaticChunkingStrategyResponseParam FromStatic(global::tryAGI.OpenAI.StaticChunkingStrategy @static)
        {
            return new StaticChunkingStrategyResponseParam
            {
                Static = @static,
            };
        }

    }
}