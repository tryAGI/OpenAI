
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaUrlCitationParam
    {
        /// <summary>
        /// The citation type. Always `url_citation`.<br/>
        /// Default Value: url_citation
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaUrlCitationParamType.UrlCitation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaUrlCitationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaUrlCitationParamType Type { get; set; } = global::tryAGI.OpenAI.BetaUrlCitationParamType.UrlCitation;

        /// <summary>
        /// The index of the first character of the citation in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// The index of the last character of the citation in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// The URL of the cited resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The title of the cited resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUrlCitationParam" /> class.
        /// </summary>
        /// <param name="startIndex">
        /// The index of the first character of the citation in the message.
        /// </param>
        /// <param name="endIndex">
        /// The index of the last character of the citation in the message.
        /// </param>
        /// <param name="url">
        /// The URL of the cited resource.
        /// </param>
        /// <param name="title">
        /// The title of the cited resource.
        /// </param>
        /// <param name="type">
        /// The citation type. Always `url_citation`.<br/>
        /// Default Value: url_citation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUrlCitationParam(
            int startIndex,
            int endIndex,
            string url,
            string title,
            global::tryAGI.OpenAI.BetaUrlCitationParamType type = global::tryAGI.OpenAI.BetaUrlCitationParamType.UrlCitation)
        {
            this.Type = type;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUrlCitationParam" /> class.
        /// </summary>
        public BetaUrlCitationParam()
        {
        }

    }
}