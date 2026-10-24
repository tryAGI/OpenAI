
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `new_session`.<br/>
    /// Default Value: new_session
    /// </summary>
    public enum AutomationTargetParamNewSessionType
    {
        /// <summary>
        ///
        /// </summary>
        NewSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationTargetParamNewSessionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationTargetParamNewSessionType value)
        {
            return value switch
            {
                AutomationTargetParamNewSessionType.NewSession => "new_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationTargetParamNewSessionType? ToEnum(string value)
        {
            return value switch
            {
                "new_session" => AutomationTargetParamNewSessionType.NewSession,
                _ => null,
            };
        }
    }
}