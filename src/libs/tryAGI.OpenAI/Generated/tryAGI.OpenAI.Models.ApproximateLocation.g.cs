
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApproximateLocation
    {
        /// <summary>
        /// The type of location approximation. Always `approximate`.<br/>
        /// Default Value: approximate
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ApproximateLocationType.Approximate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ApproximateLocationTypeJsonConverter))]
        public global::tryAGI.OpenAI.ApproximateLocationType Type { get; set; } = global::tryAGI.OpenAI.ApproximateLocationType.Approximate;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproximateLocation" /> class.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <param name="city"></param>
        /// <param name="timezone"></param>
        /// <param name="type">
        /// The type of location approximation. Always `approximate`.<br/>
        /// Default Value: approximate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApproximateLocation(
            string? country,
            string? region,
            string? city,
            string? timezone,
            global::tryAGI.OpenAI.ApproximateLocationType type = global::tryAGI.OpenAI.ApproximateLocationType.Approximate)
        {
            this.Type = type;
            this.Country = country;
            this.Region = region;
            this.City = city;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproximateLocation" /> class.
        /// </summary>
        public ApproximateLocation()
        {
        }
    }
}