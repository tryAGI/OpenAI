
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `existing_session`.<br/>
    /// Default Value: existing_session
    /// </summary>
    public enum AutomationTargetResourceExistingSessionType
    {
        /// <summary>
        ///
        /// </summary>
        ExistingSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationTargetResourceExistingSessionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationTargetResourceExistingSessionType value)
        {
            return value switch
            {
                AutomationTargetResourceExistingSessionType.ExistingSession => "existing_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationTargetResourceExistingSessionType? ToEnum(string value)
        {
            return value switch
            {
                "existing_session" => AutomationTargetResourceExistingSessionType.ExistingSession,
                _ => null,
            };
        }
    }
}