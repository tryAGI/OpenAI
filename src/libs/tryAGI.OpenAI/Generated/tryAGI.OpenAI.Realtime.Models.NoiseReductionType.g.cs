
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
    /// </summary>
    public enum NoiseReductionType
    {
        /// <summary>
        /// 
        /// </summary>
        FarField,
        /// <summary>
        /// 
        /// </summary>
        NearField,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NoiseReductionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NoiseReductionType value)
        {
            return value switch
            {
                NoiseReductionType.FarField => "far_field",
                NoiseReductionType.NearField => "near_field",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NoiseReductionType? ToEnum(string value)
        {
            return value switch
            {
                "far_field" => NoiseReductionType.FarField,
                "near_field" => NoiseReductionType.NearField,
                _ => null,
            };
        }
    }
}