
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The aggregated code interpreter sessions usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageCodeInterpreterSessionsResult
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"organization.usage.code_interpreter_sessions.result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "organization.usage.code_interpreter_sessions.result";

        /// <summary>
        /// The number of code interpreter sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumSessions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCodeInterpreterSessionsResult" /> class.
        /// </summary>
        /// <param name="numSessions">
        /// The number of code interpreter sessions.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageCodeInterpreterSessionsResult(
            int numSessions,
            string? projectId,
            string @object = "organization.usage.code_interpreter_sessions.result")
        {
            this.Object = @object;
            this.NumSessions = numSessions;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCodeInterpreterSessionsResult" /> class.
        /// </summary>
        public UsageCodeInterpreterSessionsResult()
        {
        }

        /// <summary>
        /// Creates a new <see cref="UsageCodeInterpreterSessionsResult"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static UsageCodeInterpreterSessionsResult FromNumSessions(int numSessions)
        {
            return new UsageCodeInterpreterSessionsResult
            {
                NumSessions = numSessions,
            };
        }

    }
}