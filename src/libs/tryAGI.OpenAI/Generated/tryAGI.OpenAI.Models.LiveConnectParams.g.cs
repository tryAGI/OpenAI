
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Primary Live WebSocket connections accept no query parameters. Supply the model and startup configuration in the first session.start event.
    /// </summary>
    public sealed partial class LiveConnectParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}