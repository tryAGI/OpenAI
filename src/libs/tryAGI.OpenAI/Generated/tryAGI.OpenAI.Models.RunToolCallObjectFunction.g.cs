
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The function definition.
    /// </summary>
    public sealed partial class RunToolCallObjectFunction
    {
        /// <summary>
        /// The arguments that the model expects you to pass to the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunToolCallObjectFunction" /> class.
        /// </summary>
        /// <param name="arguments">
        /// The arguments that the model expects you to pass to the function.
        /// </param>
        /// <param name="name">
        /// The name of the function.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunToolCallObjectFunction(
            string arguments,
            string name)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunToolCallObjectFunction" /> class.
        /// </summary>
        public RunToolCallObjectFunction()
        {
        }
    }
}