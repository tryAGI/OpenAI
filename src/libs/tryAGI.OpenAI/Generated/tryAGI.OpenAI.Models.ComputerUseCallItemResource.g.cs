
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// One execution of the platform-provided computer-use capability.
    /// </summary>
    public sealed partial class ComputerUseCallItemResource
    {
        /// <summary>
        /// The item type. Always `computer_use_call`.<br/>
        /// Default Value: computer_use_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUseCallItemResourceType.ComputerUseCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseCallItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseCallItemResourceType Type { get; set; } = global::tryAGI.OpenAI.ComputerUseCallItemResourceType.ComputerUseCall;

        /// <summary>
        /// The ID of the activity item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the turn that contains this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// A model-generated description of the activity, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The execution status of the activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FunctionCallStatusResource Status { get; set; }

        /// <summary>
        /// The last screenshot emitted by the model. Null when screenshot inclusion is disabled or the call emitted no screenshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::tryAGI.OpenAI.ComputerScreenshotResource? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseCallItemResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the activity item.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn that contains this item.
        /// </param>
        /// <param name="status">
        /// The execution status of the activity.
        /// </param>
        /// <param name="title">
        /// A model-generated description of the activity, when available.
        /// </param>
        /// <param name="output">
        /// The last screenshot emitted by the model. Null when screenshot inclusion is disabled or the call emitted no screenshot.
        /// </param>
        /// <param name="type">
        /// The item type. Always `computer_use_call`.<br/>
        /// Default Value: computer_use_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUseCallItemResource(
            string id,
            string turnId,
            global::tryAGI.OpenAI.FunctionCallStatusResource status,
            string? title,
            global::tryAGI.OpenAI.ComputerScreenshotResource? output,
            global::tryAGI.OpenAI.ComputerUseCallItemResourceType type = global::tryAGI.OpenAI.ComputerUseCallItemResourceType.ComputerUseCall)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Title = title;
            this.Status = status;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseCallItemResource" /> class.
        /// </summary>
        public ComputerUseCallItemResource()
        {
        }

    }
}