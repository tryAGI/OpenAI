
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: safety.case
    /// </summary>
    public enum SafetyCaseResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        SafetyCase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SafetyCaseResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetyCaseResourceObject value)
        {
            return value switch
            {
                SafetyCaseResourceObject.SafetyCase => "safety.case",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SafetyCaseResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "safety.case" => SafetyCaseResourceObject.SafetyCase,
                _ => null,
            };
        }
    }
}