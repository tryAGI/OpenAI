
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `eval.run.canceled`.
    /// </summary>
    public enum WebhookEvalRunCanceledType
    {
        /// <summary>
        /// 
        /// </summary>
        EvalRunCanceled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEvalRunCanceledTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEvalRunCanceledType value)
        {
            return value switch
            {
                WebhookEvalRunCanceledType.EvalRunCanceled => "eval.run.canceled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEvalRunCanceledType? ToEnum(string value)
        {
            return value switch
            {
                "eval.run.canceled" => WebhookEvalRunCanceledType.EvalRunCanceled,
                _ => null,
            };
        }
    }
}