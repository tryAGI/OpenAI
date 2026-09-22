
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookEventTypeListResource
    {
        /// <summary>
        /// The object type, which is always list.<br/>
        /// Default Value: list
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WebhookEventTypeListResourceObject.List</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookEventTypeListResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.WebhookEventTypeListResourceObject Object { get; set; } = global::tryAGI.OpenAI.WebhookEventTypeListResourceObject.List;

        /// <summary>
        /// The webhook event types available to the authenticated project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventTypeListResource" /> class.
        /// </summary>
        /// <param name="data">
        /// The webhook event types available to the authenticated project.
        /// </param>
        /// <param name="object">
        /// The object type, which is always list.<br/>
        /// Default Value: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEventTypeListResource(
            global::System.Collections.Generic.IList<string> data,
            global::tryAGI.OpenAI.WebhookEventTypeListResourceObject @object = global::tryAGI.OpenAI.WebhookEventTypeListResourceObject.List)
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventTypeListResource" /> class.
        /// </summary>
        public WebhookEventTypeListResource()
        {
        }

    }
}