
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a move action, this property is always set to `move`.<br/>
    /// Default Value: move
    /// </summary>
    public enum MoveParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Move,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MoveParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoveParamType value)
        {
            return value switch
            {
                MoveParamType.Move => "move",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoveParamType? ToEnum(string value)
        {
            return value switch
            {
                "move" => MoveParamType.Move,
                _ => null,
            };
        }
    }
}