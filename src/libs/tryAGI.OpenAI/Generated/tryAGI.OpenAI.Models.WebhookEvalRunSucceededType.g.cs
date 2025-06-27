
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `eval.run.succeeded`.
    /// </summary>
    public enum WebhookEvalRunSucceededType
    {
        /// <summary>
        /// 
        /// </summary>
        EvalRunSucceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEvalRunSucceededTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEvalRunSucceededType value)
        {
            return value switch
            {
                WebhookEvalRunSucceededType.EvalRunSucceeded => "eval.run.succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEvalRunSucceededType? ToEnum(string value)
        {
            return value switch
            {
                "eval.run.succeeded" => WebhookEvalRunSucceededType.EvalRunSucceeded,
                _ => null,
            };
        }
    }
}