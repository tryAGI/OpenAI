
#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, object>))]
        public global::tryAGI.OpenAI.AnyOf<string, object>? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, object>))]
        public global::tryAGI.OpenAI.AnyOf<string, object>? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, object>))]
        public global::tryAGI.OpenAI.AnyOf<string, object>? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, object>))]
        public global::tryAGI.OpenAI.AnyOf<string, object>? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproximateLocation" /> class.
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
        public ApproximateLocation(
            global::tryAGI.OpenAI.AnyOf<string, object>? country,
            global::tryAGI.OpenAI.AnyOf<string, object>? region,
            global::tryAGI.OpenAI.AnyOf<string, object>? city,
            global::tryAGI.OpenAI.AnyOf<string, object>? timezone,
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