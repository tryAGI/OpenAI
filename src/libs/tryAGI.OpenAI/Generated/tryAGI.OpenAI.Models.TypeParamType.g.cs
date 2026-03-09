
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a type action, this property is always set to `type`.<br/>
    /// Default Value: type
    /// </summary>
    public enum TypeParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Type,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TypeParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypeParamType value)
        {
            return value switch
            {
                TypeParamType.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TypeParamType? ToEnum(string value)
        {
            return value switch
            {
                "type" => TypeParamType.Type,
                _ => null,
            };
        }
    }
}