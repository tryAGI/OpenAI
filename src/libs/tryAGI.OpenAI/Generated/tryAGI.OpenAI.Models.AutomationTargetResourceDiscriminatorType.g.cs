
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AutomationTargetResourceDiscriminatorType
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
    public static class AutomationTargetResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationTargetResourceDiscriminatorType value)
        {
            return value switch
            {
                AutomationTargetResourceDiscriminatorType.ExistingSession => "existing_session",
                AutomationTargetResourceDiscriminatorType.NewSession => "new_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationTargetResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "existing_session" => AutomationTargetResourceDiscriminatorType.ExistingSession,
                "new_session" => AutomationTargetResourceDiscriminatorType.NewSession,
                _ => null,
            };
        }
    }
}