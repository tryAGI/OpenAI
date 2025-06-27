
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `eval.run.failed`.
    /// </summary>
    public enum WebhookEvalRunFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        EvalRunFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEvalRunFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEvalRunFailedType value)
        {
            return value switch
            {
                WebhookEvalRunFailedType.EvalRunFailed => "eval.run.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEvalRunFailedType? ToEnum(string value)
        {
            return value switch
            {
                "eval.run.failed" => WebhookEvalRunFailedType.EvalRunFailed,
                _ => null,
            };
        }
    }
}