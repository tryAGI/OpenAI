
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Approximate user location used to localize web search results.
    /// </summary>
    public sealed partial class WebSearchLocationParam
    {
        /// <summary>
        /// The two-letter ISO country code, such as `US`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The region or state name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The city name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The IANA timezone, such as `America/Los_Angeles`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchLocationParam" /> class.
        /// </summary>
        /// <param name="country">
        /// The two-letter ISO country code, such as `US`.
        /// </param>
        /// <param name="region">
        /// The region or state name.
        /// </param>
        /// <param name="city">
        /// The city name.
        /// </param>
        /// <param name="timezone">
        /// The IANA timezone, such as `America/Los_Angeles`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchLocationParam(
            string? country,
            string? region,
            string? city,
            string? timezone)
        {
            this.Country = country;
            this.Region = region;
            this.City = city;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchLocationParam" /> class.
        /// </summary>
        public WebSearchLocationParam()
        {
        }

    }
}