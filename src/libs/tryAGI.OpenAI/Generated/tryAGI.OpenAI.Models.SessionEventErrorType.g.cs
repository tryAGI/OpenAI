
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `error`.<br/>
    /// Default Value: error
    /// </summary>
    public enum SessionEventErrorType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventErrorType value)
        {
            return value switch
            {
                SessionEventErrorType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventErrorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => SessionEventErrorType.Error,
                _ => null,
            };
        }
    }
}