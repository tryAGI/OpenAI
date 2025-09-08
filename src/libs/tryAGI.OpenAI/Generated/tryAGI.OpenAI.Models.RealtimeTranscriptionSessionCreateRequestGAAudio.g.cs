
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for input and output audio.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateRequestGAAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInput? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestGAAudio" /> class.
        /// </summary>
        /// <param name="input"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateRequestGAAudio(
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInput? input)
        {
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestGAAudio" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateRequestGAAudio()
        {
        }
    }
}