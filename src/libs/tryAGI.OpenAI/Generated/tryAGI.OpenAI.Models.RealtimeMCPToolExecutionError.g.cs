
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeMCPToolExecutionError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"tool_execution_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_execution_error";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeMCPToolExecutionError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeMCPToolExecutionError(
            string message,
            string type = "tool_execution_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeMCPToolExecutionError" /> class.
        /// </summary>
        public RealtimeMCPToolExecutionError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RealtimeMCPToolExecutionError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RealtimeMCPToolExecutionError FromMessage(string message)
        {
            return new RealtimeMCPToolExecutionError
            {
                Message = message,
            };
        }

    }
}