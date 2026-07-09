
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The approximate location of the user.
    /// </summary>
    public sealed partial class BetaWebSearchApproximateLocationWebSearchApproximateLocation
    {
        /// <summary>
        /// The type of location approximation. Always `approximate`.<br/>
        /// Default Value: approximate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaWebSearchApproximateLocationWebSearchApproximateLocationTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaWebSearchApproximateLocationWebSearchApproximateLocation" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of location approximation. Always `approximate`.<br/>
        /// Default Value: approximate
        /// </param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <param name="city"></param>
        /// <param name="timezone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebSearchApproximateLocationWebSearchApproximateLocation(
            global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType? type,
            string? country,
            string? region,
            string? city,
            string? timezone)
        {
            this.Type = type;
            this.Country = country;
            this.Region = region;
            this.City = city;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebSearchApproximateLocationWebSearchApproximateLocation" /> class.
        /// </summary>
        public BetaWebSearchApproximateLocationWebSearchApproximateLocation()
        {
        }

    }
}