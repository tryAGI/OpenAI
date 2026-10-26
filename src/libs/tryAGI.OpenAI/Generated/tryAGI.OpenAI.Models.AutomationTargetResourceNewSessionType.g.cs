
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `new_session`.<br/>
    /// Default Value: new_session
    /// </summary>
    public enum AutomationTargetResourceNewSessionType
    {
        /// <summary>
        ///
        /// </summary>
        NewSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationTargetResourceNewSessionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationTargetResourceNewSessionType value)
        {
            return value switch
            {
                AutomationTargetResourceNewSessionType.NewSession => "new_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationTargetResourceNewSessionType? ToEnum(string value)
        {
            return value switch
            {
                "new_session" => AutomationTargetResourceNewSessionType.NewSession,
                _ => null,
            };
        }
    }
}