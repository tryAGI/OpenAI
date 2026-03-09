
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a drag action, this property is always set to `drag`.<br/>
    /// Default Value: drag
    /// </summary>
    public enum DragParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Drag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DragParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DragParamType value)
        {
            return value switch
            {
                DragParamType.Drag => "drag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DragParamType? ToEnum(string value)
        {
            return value switch
            {
                "drag" => DragParamType.Drag,
                _ => null,
            };
        }
    }
}