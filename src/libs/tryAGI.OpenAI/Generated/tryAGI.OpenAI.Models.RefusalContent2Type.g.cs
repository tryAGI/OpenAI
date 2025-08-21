
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the refusal. Always `refusal`.<br/>
    /// Default Value: refusal
    /// </summary>
    public enum RefusalContent2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RefusalContent2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefusalContent2Type value)
        {
            return value switch
            {
                RefusalContent2Type.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefusalContent2Type? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => RefusalContent2Type.Refusal,
                _ => null,
            };
        }
    }
}