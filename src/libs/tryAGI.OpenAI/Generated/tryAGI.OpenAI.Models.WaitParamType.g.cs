
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a wait action, this property is always set to `wait`.<br/>
    /// Default Value: wait
    /// </summary>
    public enum WaitParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WaitParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WaitParamType value)
        {
            return value switch
            {
                WaitParamType.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WaitParamType? ToEnum(string value)
        {
            return value switch
            {
                "wait" => WaitParamType.Wait,
                _ => null,
            };
        }
    }
}