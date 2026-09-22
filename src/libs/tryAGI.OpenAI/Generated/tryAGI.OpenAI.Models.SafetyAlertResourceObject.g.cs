
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: safety.alert
    /// </summary>
    public enum SafetyAlertResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        SafetyAlert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SafetyAlertResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetyAlertResourceObject value)
        {
            return value switch
            {
                SafetyAlertResourceObject.SafetyAlert => "safety.alert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SafetyAlertResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "safety.alert" => SafetyAlertResourceObject.SafetyAlert,
                _ => null,
            };
        }
    }
}