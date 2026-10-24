
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AutomationTargetParamDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ExistingSession,
        /// <summary>
        ///
        /// </summary>
        NewSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationTargetParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationTargetParamDiscriminatorType value)
        {
            return value switch
            {
                AutomationTargetParamDiscriminatorType.ExistingSession => "existing_session",
                AutomationTargetParamDiscriminatorType.NewSession => "new_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationTargetParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "existing_session" => AutomationTargetParamDiscriminatorType.ExistingSession,
                "new_session" => AutomationTargetParamDiscriminatorType.NewSession,
                _ => null,
            };
        }
    }
}