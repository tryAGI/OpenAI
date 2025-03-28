
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The set of modalities the model can respond with. To disable audio,<br/>
    /// set this to ["text"].
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponseModalities
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}