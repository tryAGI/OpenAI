
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A function call produced by the agent.
    /// </summary>
    public sealed partial class FunctionCallItemResource
    {
        /// <summary>
        /// The item type. Always `function_call`.<br/>
        /// Default Value: function_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.FunctionCallItemResourceType.FunctionCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.FunctionCallItemResourceType Type { get; set; } = global::tryAGI.OpenAI.FunctionCallItemResourceType.FunctionCall;

        /// <summary>
        /// The ID of the function call item.
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
        /// The ID used to submit the function result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The name of the function to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The arguments to pass to the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// The status of the function call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FunctionCallStatusResource Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallItemResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the function call item.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn that contains this item.
        /// </param>
        /// <param name="callId">
        /// The ID used to submit the function result.
        /// </param>
        /// <param name="name">
        /// The name of the function to call.
        /// </param>
        /// <param name="arguments">
        /// The arguments to pass to the function.
        /// </param>
        /// <param name="status">
        /// The status of the function call.
        /// </param>
        /// <param name="type">
        /// The item type. Always `function_call`.<br/>
        /// Default Value: function_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallItemResource(
            string id,
            string turnId,
            string callId,
            string name,
            object arguments,
            global::tryAGI.OpenAI.FunctionCallStatusResource status,
            global::tryAGI.OpenAI.FunctionCallItemResourceType type = global::tryAGI.OpenAI.FunctionCallItemResourceType.FunctionCall)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallItemResource" /> class.
        /// </summary>
        public FunctionCallItemResource()
        {
        }

    }
}