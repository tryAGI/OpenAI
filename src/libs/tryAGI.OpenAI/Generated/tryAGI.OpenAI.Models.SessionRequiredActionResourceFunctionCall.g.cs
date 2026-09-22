
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Run a function tool and submit its result.
    /// </summary>
    public sealed partial class SessionRequiredActionResourceFunctionCall
    {
        /// <summary>
        /// The type of the object. Always `function_call`.<br/>
        /// Default Value: function_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType.FunctionCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceFunctionCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType Type { get; set; } = global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType.FunctionCall;

        /// <summary>
        /// The ID of the turn that requested the function call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The ID to include when submitting the function result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The function name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The arguments supplied by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequiredActionResourceFunctionCall" /> class.
        /// </summary>
        /// <param name="turnId">
        /// The ID of the turn that requested the function call.
        /// </param>
        /// <param name="callId">
        /// The ID to include when submitting the function result.
        /// </param>
        /// <param name="name">
        /// The function name.
        /// </param>
        /// <param name="arguments">
        /// The arguments supplied by the model.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `function_call`.<br/>
        /// Default Value: function_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionRequiredActionResourceFunctionCall(
            string turnId,
            string callId,
            string name,
            object arguments,
            global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType type = global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType.FunctionCall)
        {
            this.Type = type;
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequiredActionResourceFunctionCall" /> class.
        /// </summary>
        public SessionRequiredActionResourceFunctionCall()
        {
        }

    }
}