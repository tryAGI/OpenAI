
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A wait action.
    /// </summary>
    public sealed partial class WaitParam
    {
        /// <summary>
        /// Specifies the event type. For a wait action, this property is always set to `wait`.<br/>
        /// Default Value: wait
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WaitParamType.Wait</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WaitParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.WaitParamType Type { get; set; } = global::tryAGI.OpenAI.WaitParamType.Wait;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a wait action, this property is always set to `wait`.<br/>
        /// Default Value: wait
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WaitParam(
            global::tryAGI.OpenAI.WaitParamType type = global::tryAGI.OpenAI.WaitParamType.Wait)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitParam" /> class.
        /// </summary>
        public WaitParam()
        {
        }
    }
}