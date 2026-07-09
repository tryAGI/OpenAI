
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a wait action, this property is always set to `wait`.<br/>
    /// Default Value: wait
    /// </summary>
    public enum BetaWaitParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWaitParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWaitParamType value)
        {
            return value switch
            {
                BetaWaitParamType.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWaitParamType? ToEnum(string value)
        {
            return value switch
            {
                "wait" => BetaWaitParamType.Wait,
                _ => null,
            };
        }
    }
}