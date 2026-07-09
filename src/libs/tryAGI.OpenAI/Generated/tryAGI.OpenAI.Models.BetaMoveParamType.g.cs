
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a move action, this property is always set to `move`.<br/>
    /// Default Value: move
    /// </summary>
    public enum BetaMoveParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Move,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMoveParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMoveParamType value)
        {
            return value switch
            {
                BetaMoveParamType.Move => "move",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMoveParamType? ToEnum(string value)
        {
            return value switch
            {
                "move" => BetaMoveParamType.Move,
                _ => null,
            };
        }
    }
}