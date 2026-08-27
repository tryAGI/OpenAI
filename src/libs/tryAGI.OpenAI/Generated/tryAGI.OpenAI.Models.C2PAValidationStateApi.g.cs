
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum C2PAValidationStateApi
    {
        /// <summary>
        ///
        /// </summary>
        Invalid,
        /// <summary>
        ///
        /// </summary>
        NotPresent,
        /// <summary>
        ///
        /// </summary>
        Trusted,
        /// <summary>
        ///
        /// </summary>
        Valid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class C2PAValidationStateApiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this C2PAValidationStateApi value)
        {
            return value switch
            {
                C2PAValidationStateApi.Invalid => "invalid",
                C2PAValidationStateApi.NotPresent => "not_present",
                C2PAValidationStateApi.Trusted => "trusted",
                C2PAValidationStateApi.Valid => "valid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static C2PAValidationStateApi? ToEnum(string value)
        {
            return value switch
            {
                "invalid" => C2PAValidationStateApi.Invalid,
                "not_present" => C2PAValidationStateApi.NotPresent,
                "trusted" => C2PAValidationStateApi.Trusted,
                "valid" => C2PAValidationStateApi.Valid,
                _ => null,
            };
        }
    }
}