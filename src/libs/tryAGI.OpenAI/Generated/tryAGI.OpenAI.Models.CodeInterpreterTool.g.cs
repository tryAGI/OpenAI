
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that runs Python code to help generate a response to a prompt.
    /// </summary>
    public sealed partial class CodeInterpreterTool
    {
        /// <summary>
        /// The code interpreter container. Can be a container ID or an object that<br/>
        /// specifies uploaded file IDs to make available to your code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CodeInterpreterToolAuto>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CodeInterpreterToolAuto> Container { get; set; }

        /// <summary>
        /// The type of the code interpreter tool. Always `code_interpreter`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.CodeInterpreterToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterTool" /> class.
        /// </summary>
        /// <param name="container">
        /// The code interpreter container. Can be a container ID or an object that<br/>
        /// specifies uploaded file IDs to make available to your code.
        /// </param>
        /// <param name="type">
        /// The type of the code interpreter tool. Always `code_interpreter`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterTool(
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CodeInterpreterToolAuto> container,
            global::tryAGI.OpenAI.CodeInterpreterToolType type)
        {
            this.Container = container;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterTool" /> class.
        /// </summary>
        public CodeInterpreterTool()
        {
        }
    }
}