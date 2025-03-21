
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Defines a function in your own code the model can choose to call. Learn more<br/>
    /// about [function calling](/docs/guides/function-calling).
    /// </summary>
    public sealed partial class FunctionTool
    {
        /// <summary>
        /// The type of the function tool. Always `function`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.FunctionToolType Type { get; set; }

        /// <summary>
        /// The name of the function to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the function. Used by the model to determine whether<br/>
        /// or not to call the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A JSON schema object describing the parameters of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Parameters { get; set; }

        /// <summary>
        /// Whether to enforce strict parameter validation. Default `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the function tool. Always `function`.
        /// </param>
        /// <param name="name">
        /// The name of the function to call.
        /// </param>
        /// <param name="description">
        /// A description of the function. Used by the model to determine whether<br/>
        /// or not to call the function.
        /// </param>
        /// <param name="parameters">
        /// A JSON schema object describing the parameters of the function.
        /// </param>
        /// <param name="strict">
        /// Whether to enforce strict parameter validation. Default `true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionTool(
            string name,
            object parameters,
            bool strict,
            global::tryAGI.OpenAI.FunctionToolType type,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Strict = strict;
            this.Type = type;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionTool" /> class.
        /// </summary>
        public FunctionTool()
        {
        }
    }
}