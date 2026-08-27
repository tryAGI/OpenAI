
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a keypress action, this property is always set to `keypress`.<br/>
    /// Default Value: keypress
    /// </summary>
    public enum BetaKeyPressActionType
    {
        /// <summary>
        ///
        /// </summary>
        Keypress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaKeyPressActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaKeyPressActionType value)
        {
            return value switch
            {
                BetaKeyPressActionType.Keypress => "keypress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaKeyPressActionType? ToEnum(string value)
        {
            return value switch
            {
                "keypress" => BetaKeyPressActionType.Keypress,
                _ => null,
            };
        }
    }
}