
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decision.item.deleted
    /// </summary>
    public enum LiveDecisionItemDeletedType
    {
        /// <summary>
        ///
        /// </summary>
        DecisionItemDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionItemDeletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionItemDeletedType value)
        {
            return value switch
            {
                LiveDecisionItemDeletedType.DecisionItemDeleted => "decision.item.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionItemDeletedType? ToEnum(string value)
        {
            return value switch
            {
                "decision.item.deleted" => LiveDecisionItemDeletedType.DecisionItemDeleted,
                _ => null,
            };
        }
    }
}