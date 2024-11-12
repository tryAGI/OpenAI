
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The payload used to create the project.
    /// </summary>
    public sealed partial class AuditLogProjectCreatedData
    {
        /// <summary>
        /// The project name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The title of the project as seen on the dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProjectCreatedData" /> class.
        /// </summary>
        /// <param name="name">
        /// The project name.
        /// </param>
        /// <param name="title">
        /// The title of the project as seen on the dashboard.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AuditLogProjectCreatedData(
            string? name,
            string? title)
        {
            this.Name = name;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProjectCreatedData" /> class.
        /// </summary>
        public AuditLogProjectCreatedData()
        {
        }
    }
}