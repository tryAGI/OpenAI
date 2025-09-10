
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for input audio for the session.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponseGAAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInput? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseGAAudio" /> class.
        /// </summary>
        /// <param name="input"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateResponseGAAudio(
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInput? input)
        {
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseGAAudio" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponseGAAudio()
        {
        }
    }
}