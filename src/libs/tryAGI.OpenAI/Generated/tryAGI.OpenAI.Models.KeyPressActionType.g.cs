
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a keypress action, this property is always set to `keypress`.<br/>
    /// Default Value: keypress
    /// </summary>
    public enum KeyPressActionType
    {
        /// <summary>
        /// 
        /// </summary>
        Keypress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyPressActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyPressActionType value)
        {
            return value switch
            {
                KeyPressActionType.Keypress => "keypress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyPressActionType? ToEnum(string value)
        {
            return value switch
            {
                "keypress" => KeyPressActionType.Keypress,
                _ => null,
            };
        }
    }
}