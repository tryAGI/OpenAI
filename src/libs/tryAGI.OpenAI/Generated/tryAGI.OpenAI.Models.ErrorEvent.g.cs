
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when an [error](https://developers.openai.com/api/docs/guides/error-codes#api-errors) occurs. This can happen due to an internal server error or a timeout.
    /// </summary>
    public sealed partial class ErrorEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "error";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Error Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorEvent(
            global::tryAGI.OpenAI.Error data,
            string @event = "error")
        {
            this.Event = @event;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent" /> class.
        /// </summary>
        public ErrorEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ErrorEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ErrorEvent FromData(global::tryAGI.OpenAI.Error data)
        {
            return new ErrorEvent
            {
                Data = data,
            };
        }

    }
}