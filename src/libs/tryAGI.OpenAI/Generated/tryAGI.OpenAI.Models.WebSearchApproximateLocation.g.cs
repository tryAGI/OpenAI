
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The approximate location of the user.
    /// </summary>
    public sealed partial class WebSearchApproximateLocation
    {
        /// <summary>
        /// Free text input for the city of the user, e.g. `San Francisco`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The two-letter [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1) of the user, e.g. `US`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Free text input for the region of the user, e.g. `California`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The [IANA timezone](https://timeapi.io/documentation/iana-timezones) of the user, e.g. `America/Los_Angeles`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// The type of location approximation. Always `approximate`.<br/>
        /// Default Value: approximate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchApproximateLocationTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchApproximateLocationType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchApproximateLocation" /> class.
        /// </summary>
        /// <param name="city">
        /// Free text input for the city of the user, e.g. `San Francisco`.
        /// </param>
        /// <param name="country">
        /// The two-letter [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1) of the user, e.g. `US`.
        /// </param>
        /// <param name="region">
        /// Free text input for the region of the user, e.g. `California`.
        /// </param>
        /// <param name="timezone">
        /// The [IANA timezone](https://timeapi.io/documentation/iana-timezones) of the user, e.g. `America/Los_Angeles`.
        /// </param>
        /// <param name="type">
        /// The type of location approximation. Always `approximate`.<br/>
        /// Default Value: approximate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchApproximateLocation(
            string? city,
            string? country,
            string? region,
            string? timezone,
            global::tryAGI.OpenAI.WebSearchApproximateLocationType? type)
        {
            this.City = city;
            this.Country = country;
            this.Region = region;
            this.Timezone = timezone;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchApproximateLocation" /> class.
        /// </summary>
        public WebSearchApproximateLocation()
        {
        }
    }
}