
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Task entry that appears within a TaskGroup.
    /// </summary>
    public sealed partial class TaskGroupTask
    {
        /// <summary>
        /// Subtype for the grouped task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TaskTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.TaskType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heading")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Heading { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskGroupTask" /> class.
        /// </summary>
        /// <param name="type">
        /// Subtype for the grouped task.
        /// </param>
        /// <param name="heading"></param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskGroupTask(
            global::tryAGI.OpenAI.TaskType type,
            string? heading,
            string? summary)
        {
            this.Type = type;
            this.Heading = heading ?? throw new global::System.ArgumentNullException(nameof(heading));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskGroupTask" /> class.
        /// </summary>
        public TaskGroupTask()
        {
        }
    }
}