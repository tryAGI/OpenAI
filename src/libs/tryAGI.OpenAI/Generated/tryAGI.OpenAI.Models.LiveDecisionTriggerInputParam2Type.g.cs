
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decisions
    /// </summary>
    public enum LiveDecisionTriggerInputParam2Type
    {
        /// <summary>
        ///
        /// </summary>
        Decisions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionTriggerInputParam2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionTriggerInputParam2Type value)
        {
            return value switch
            {
                LiveDecisionTriggerInputParam2Type.Decisions => "decisions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionTriggerInputParam2Type? ToEnum(string value)
        {
            return value switch
            {
                "decisions" => LiveDecisionTriggerInputParam2Type.Decisions,
                _ => null,
            };
        }
    }
}