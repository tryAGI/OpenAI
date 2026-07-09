
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Combine multiple filters using `and` or `or`.
    /// </summary>
    public sealed partial class BetaCompoundFilter
    {
        /// <summary>
        /// Type of operation: `and` or `or`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaCompoundFilterTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaCompoundFilterType Type { get; set; }

        /// <summary>
        /// Array of filters to combine. Items can be `ComparisonFilter` or `CompoundFilter`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem2> Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompoundFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of operation: `and` or `or`.
        /// </param>
        /// <param name="filters">
        /// Array of filters to combine. Items can be `ComparisonFilter` or `CompoundFilter`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCompoundFilter(
            global::tryAGI.OpenAI.BetaCompoundFilterType type,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem2> filters)
        {
            this.Type = type;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompoundFilter" /> class.
        /// </summary>
        public BetaCompoundFilter()
        {
        }

    }
}