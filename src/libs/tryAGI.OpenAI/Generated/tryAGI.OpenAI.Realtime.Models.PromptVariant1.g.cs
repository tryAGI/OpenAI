
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Reference to a prompt template and its variables.<br/>
    /// [Learn more](/docs/guides/text?api-mode=responses#reusable-prompts).
    /// </summary>
    public sealed partial class PromptVariant1
    {
        /// <summary>
        /// The unique identifier of the prompt template to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the prompt template to use.
        /// </param>
        /// <param name="version"></param>
        /// <param name="variables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVariant1(
            string id,
            string? version,
            object? variables)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVariant1" /> class.
        /// </summary>
        public PromptVariant1()
        {
        }
    }
}