
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantToolsFunction
    {
        /// <summary>
        /// The type of tool being defined: `function`
        /// </summary>
        /// <default>"function"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "function";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FunctionObject Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFunction" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type">
        /// The type of tool being defined: `function`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantToolsFunction(
            global::tryAGI.OpenAI.FunctionObject function,
            string type = "function")
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFunction" /> class.
        /// </summary>
        public AssistantToolsFunction()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AssistantToolsFunction"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AssistantToolsFunction FromFunction(global::tryAGI.OpenAI.FunctionObject function)
        {
            return new AssistantToolsFunction
            {
                Function = function,
            };
        }

    }
}