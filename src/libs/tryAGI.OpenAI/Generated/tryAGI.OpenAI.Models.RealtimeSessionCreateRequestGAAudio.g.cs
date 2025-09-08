
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for input and output audio.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestGAAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInput? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestGAAudio" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequestGAAudio(
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInput? input,
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioOutput? output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestGAAudio" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestGAAudio()
        {
        }
    }
}