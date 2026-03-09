
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Status discriminator that is always `active`.<br/>
    /// Default Value: active
    /// </summary>
    public enum ActiveStatusType
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActiveStatusTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActiveStatusType value)
        {
            return value switch
            {
                ActiveStatusType.Active => "active",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActiveStatusType? ToEnum(string value)
        {
            return value switch
            {
                "active" => ActiveStatusType.Active,
                _ => null,
            };
        }
    }
}