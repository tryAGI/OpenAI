
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A dictionary of moderation categories to booleans, True if the input is flagged under this category.
    /// </summary>
    public sealed partial class ModerationResultBodyCategories
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}