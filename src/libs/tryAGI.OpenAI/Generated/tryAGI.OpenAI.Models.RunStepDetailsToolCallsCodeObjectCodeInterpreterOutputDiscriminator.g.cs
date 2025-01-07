
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorTypeJsonConverter))]
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator(
            global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator" /> class.
        /// </summary>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator()
        {
        }
    }
}