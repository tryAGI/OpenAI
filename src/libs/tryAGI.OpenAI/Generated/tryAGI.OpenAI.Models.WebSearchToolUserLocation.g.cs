
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchToolUserLocation
    {
        /// <summary>
        /// The type of location approximation. Always `approximate`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolUserLocationTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchToolUserLocationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolUserLocation" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of location approximation. Always `approximate`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchToolUserLocation(
            global::tryAGI.OpenAI.WebSearchToolUserLocationType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolUserLocation" /> class.
        /// </summary>
        public WebSearchToolUserLocation()
        {
        }
    }
}